using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using RealEstateService.DataObjects;
using RealEstateService.Models;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using GeocodeSharp.Google;

namespace RealEstateService.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class AddressController : TableController<Address>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Address>(context, Request, Services);
        }

        // GET tables/Address
        public IQueryable<Address> GetAllAddress()
        {
            return Query(); 
        }

        // GET tables/Address/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Address> GetAddress(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Address/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Address> PatchAddress(string id, Delta<Address> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Address
        public async Task<IHttpActionResult> PostAddress(Address item)
        {
            var client = new GeocodeClient();
            var address = item.Street1 + ' ' + item.Street2 + ',' + item.City + ',' + item.State;
            var response = await client.GeocodeAddress(address);

            try
            {
                if (response.Status == GeocodeStatus.Ok)
                {
                    var firstResult = response.Results.First();
                    var location = firstResult.Geometry.Location;
                    item.Latitude = location.Latitude;
                    item.Longitude = location.Longitude;
                }
            }
            catch (System.Exception)
            {
                Services.Log.Warn("Could not find cordinates for " + address, null, "GeoCode Client");
            }

            Address current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Address/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAddress(string id)
        {
             return DeleteAsync(id);
        }

    }
}