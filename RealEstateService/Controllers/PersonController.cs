﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using RealEstateService.DataObjects;
using RealEstateService.Models;
using RealEstateService.Helpers;

namespace RealEstateService.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class PersonController : TableController<Person>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Person>(context, Request, Services);
        }

        // GET tables/Person
        public IQueryable<Person> GetAllPerson()
        {       
            return Query(); 
        }

        // GET tables/Person/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Person> GetPerson(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Person/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Person> PatchPerson(string id, Delta<Person> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Person
        public async Task<IHttpActionResult> PostPerson(Person item)
        {
            Person current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Person/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletePerson(string id)
        {
             return DeleteAsync(id);
        }

    }
}