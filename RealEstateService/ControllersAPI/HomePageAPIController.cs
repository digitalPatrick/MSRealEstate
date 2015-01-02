using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using RealEstateService.DTO;
using System.Web.Http.Description;
using System.Threading.Tasks;
using RealEstateService.Models;
using System.Data.Entity;
using Microsoft.WindowsAzure.Mobile.Service.Security;

namespace RealEstateService.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class HomePageAPIController : ApiController
    {
        public ApiServices Services { get; set; }
        MobileServiceContext context = new MobileServiceContext();

        // GET api/HomePageAPI
        [ResponseType(typeof(HomePageDTO))]
        public async Task<IHttpActionResult> GetHomePage()
        {
            var query = await context.People.Select(a => new HomePageDTO
            {
                FeaturedAgents = context.People.Where(s => s.Featured == true).Select(b => new PersonDTO
                {
                    Id = b.Id,
                    AvatarUrl = b.AvatarUrl,
                    FirstName = b.FirstName,
                    LastName = b.LastName,
                    UserName = b.UserName,
                    CreatedAt = b.CreatedAt

                }).OrderBy(c => c.CreatedAt).Take(4).ToList(),

                Blogs = context.People.Select(d => new PersonDTO
                {
                    Id = d.Id,
                    AvatarUrl = d.AvatarUrl,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    UserName = d.UserName,
                    CreatedAt = d.CreatedAt

                }).OrderByDescending(e => e.CreatedAt).Take(3).ToList(),

                LatestApartments = context.Apartments.Select(f => new ApartmentDTO
                {
                    Id = f.Id,
                    Description = f.Description,
                    CreatedAt = f.CreatedAt,
                    MainImage = context.Images.Where(i => i.ApartmentId == f.Id && i.IsLeadImage == true)
                        .Select(i => new MainImageDTO
                        {
                            ImageUrl = i.ImageUrl,
                            ShortDescription = i.ShortDescription
                        }).FirstOrDefault(),

                }).OrderByDescending(g => g.CreatedAt).Take(4).ToList(),

                ApartmentsNearYou = context.Apartments.Select(f => new ApartmentDTO
                {
                    Id = f.Id,
                    Description = f.Description,
                    CreatedAt = f.CreatedAt,
                    MainImage = context.Images.Where(i => i.ApartmentId == f.Id && i.IsLeadImage == true)
                        .Select(i => new MainImageDTO
                        {
                            ImageUrl = i.ImageUrl,
                            ShortDescription = i.ShortDescription
                        }).FirstOrDefault(),

                }).OrderByDescending(g => g.CreatedAt).Take(3).ToList(),

            }).FirstOrDefaultAsync();
                

            return Ok(query);
        }

    }
}
