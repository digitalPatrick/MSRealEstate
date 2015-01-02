using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using RealEstateService.DTO;
using RealEstateService.Models;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http.Description;
using Microsoft.WindowsAzure.Mobile.Service.Security;

namespace RealEstateService.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class AgentProfileAPIController : ApiController
    {
        MobileServiceContext context = new MobileServiceContext();
        public ApiServices Services { get; set; }

        // GET api/AgentProfileAPI?agentname=digitalpatrick1
        [ResponseType(typeof(PersonDTO))]
        public async Task<IHttpActionResult> GetAgentProfile(string agentName)
        {
            var query = await context.People
                .Select(b => new PersonDTO
                {
                    Id = b.Id,
                    UserName = b.UserName,
                    AvatarUrl = b.AvatarUrl,
                    Featured = b.Featured,
                    FirstName = b.FirstName,
                    LastName = b.LastName,
                    Contact = new ContactDTO
                    {
                        BusinessPhone = b.Contact.BusinessPhone,
                        CellPhone = b.Contact.CellPhone,
                        EmailAddress = b.Contact.EmailAddress,
                        FaxPhone = b.Contact.FaxPhone,
                    },
                    Social = new SocialDTO
                    {
                        Micrsoft = b.Social.Micrsoft,
                        GooglePlus = b.Social.GooglePlus,
                        Yahoo = b.Social.Yahoo,
                        FaceBook = b.Social.FaceBook,
                        Instagram = b.Social.Instagram,
                        Twitter = b.Social.Twitter
                    },
                    BusinessAddress = new AddressDTO
                    {
                        Street1 = b.BusinessAddress.Street1,
                        Street2 = b.BusinessAddress.Street2,
                        State = b.BusinessAddress.State,
                        City = b.BusinessAddress.City,
                        ZipCode = b.BusinessAddress.ZipCode,
                        Latitude = b.BusinessAddress.Latitude,
                        Longitude = b.BusinessAddress.Longitude
                    }
                }).SingleOrDefaultAsync(b=>b.UserName == agentName);

            if (query==null)
            {
                return NotFound();
            }
            return Ok(query);
        }

    }
}
