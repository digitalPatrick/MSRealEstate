using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using RealEstateService.DataObjects;
using RealEstateService.Models;
using Microsoft.WindowsAzure.Mobile.Service.Security;

namespace RealEstateService.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class SocialController : TableController<Social>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Social>(context, Request, Services);
        }

        // GET tables/Social
        public IQueryable<Social> GetAllSocial()
        {
            return Query(); 
        }

        // GET tables/Social/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Social> GetSocial(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Social/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Social> PatchSocial(string id, Delta<Social> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Social
        public async Task<IHttpActionResult> PostSocial(Social item)
        {
            Social current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Social/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSocial(string id)
        {
             return DeleteAsync(id);
        }

    }
}