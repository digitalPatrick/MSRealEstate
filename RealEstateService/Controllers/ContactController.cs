﻿using System.Linq;
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
    public class ContactController : TableController<Contact>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Contact>(context, Request, Services);
        }

        // GET tables/Contact
        public IQueryable<Contact> GetAllContact()
        {
            return Query(); 
        }

        // GET tables/Contact/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Contact> GetContact(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Contact/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Contact> PatchContact(string id, Delta<Contact> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Contact
        public async Task<IHttpActionResult> PostContact(Contact item)
        {
            Contact current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Contact/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteContact(string id)
        {
             return DeleteAsync(id);
        }

    }
}