using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using RealEstateService.DataObjects;
using RealEstateService.DTO;
using RealEstateService.Models;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http.Description;

namespace RealEstateService.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class ApartmentAPIController : ApiController
    {
        MobileServiceContext context = new MobileServiceContext();
        public ApiServices Services { get; set; }

        // GET api/?
        public IQueryable<ApartmentDTO> GetAllAgentApartment(string username, int pageIndex, int pageSize)
        {
            int skipSize = pageIndex * pageSize;

            string agentId = context.People.Where(a => a.UserName == username).Select(b => b.Id).FirstOrDefault();

            var query = context.Apartments.Where(a => a.PersonId == agentId)
                .Select(c => new ApartmentDTO
                {
                    Id = c.Id,
                    Price = c.Price,
                    Description = c.Description,
                    Featured = c.Featured,
                    NumOfRooms = c.NumOfRooms,
                    CreatedAt = c.CreatedAt,
                    MainImage = context.Images.Where(i => i.ApartmentId == c.Id && i.IsLeadImage == true)
                        .Select(i => new MainImageDTO
                        {
                            ImageUrl = i.ImageUrl,
                            ShortDescription = i.ShortDescription
                        }).FirstOrDefault(),
                    ApartmentAddress = new AddressDTO
                        {
                            Street1 = c.ApartmentAddress.Street1,
                            Street2 = c.ApartmentAddress.Street2,
                            State = c.ApartmentAddress.State,
                            City = c.ApartmentAddress.City,
                            ZipCode = c.ApartmentAddress.ZipCode,
                            Latitude = c.ApartmentAddress.Latitude,
                            Longitude = c.ApartmentAddress.Longitude
                        },
                    Images = context.Images.Where(i => i.ApartmentId == c.Id).Select(i => new ImageDTO
                        {
                            ImageUrl = i.ImageUrl,
                            LongDescription = i.LongDescription,
                            ShortDescription = i.ShortDescription
                        }).ToList()
                }).OrderByDescending(o=>o.CreatedAt).Skip(skipSize).Take(pageSize).AsQueryable();

            return query;
        }

        //
        public IQueryable<ApartmentDTO> GetAllApartment(int pageIndex, int pageSize)
        {
            int skipSize = pageIndex * pageSize;

            var query = context.Apartments
                .Select(c => new ApartmentDTO
                {
                    Id = c.Id,
                    Price = c.Price,
                    Description = c.Description,
                    Featured = c.Featured,
                    NumOfRooms = c.NumOfRooms,
                    CreatedAt = c.CreatedAt,
                    MainImage = context.Images.Where(i => i.ApartmentId == c.Id && i.IsLeadImage == true)
                        .Select(i => new MainImageDTO
                        {
                            ImageUrl = i.ImageUrl,
                            ShortDescription = i.ShortDescription
                        }).FirstOrDefault(),
                    ApartmentAddress = new AddressDTO
                    {
                        Street1 = c.ApartmentAddress.Street1,
                        Street2 = c.ApartmentAddress.Street2,
                        State = c.ApartmentAddress.State,
                        City = c.ApartmentAddress.City,
                        ZipCode = c.ApartmentAddress.ZipCode,
                        Latitude = c.ApartmentAddress.Latitude,
                        Longitude = c.ApartmentAddress.Longitude
                    },
                    Images = context.Images.Where(i => i.ApartmentId == c.Id).Select(i => new ImageDTO
                    {
                        ImageUrl = i.ImageUrl,
                        LongDescription = i.LongDescription,
                        ShortDescription = i.ShortDescription
                    }).ToList()
                }).OrderByDescending(o => o.CreatedAt).Skip(skipSize).Take(pageSize).AsQueryable();

            return query;
        }

        // GET api/AgentProfileAPI?agentname=digitalpatrick1
        [ResponseType(typeof(ApartmentDTO))]
        public async Task<IHttpActionResult> GetSingleApartment(string apartmentId)
        {
            var query = await context.Apartments
                .Select(c => new ApartmentDTO
                {
                    Id = c.Id,
                    Price = c.Price,
                    Description = c.Description,
                    Featured = c.Featured,
                    NumOfRooms = c.NumOfRooms,
                    CreatedAt = c.CreatedAt,
                    MainImage = context.Images.Where(i => i.ApartmentId == c.Id && i.IsLeadImage == true)
                        .Select(i => new MainImageDTO
                        {
                            ImageUrl = i.ImageUrl,
                            ShortDescription = i.ShortDescription
                        }).FirstOrDefault(),
                    ApartmentAddress = new AddressDTO
                    {
                        Street1 = c.ApartmentAddress.Street1,
                        Street2 = c.ApartmentAddress.Street2,
                        State = c.ApartmentAddress.State,
                        City = c.ApartmentAddress.City,
                        ZipCode = c.ApartmentAddress.ZipCode,
                        Latitude = c.ApartmentAddress.Latitude,
                        Longitude = c.ApartmentAddress.Longitude
                    },
                    Images = context.Images.Where(i => i.ApartmentId == c.Id).Select(i => new ImageDTO
                    {
                        ImageUrl = i.ImageUrl,
                        LongDescription = i.LongDescription,
                        ShortDescription = i.ShortDescription
                    }).ToList()
                }).SingleOrDefaultAsync(a => a.Id == apartmentId);

            return Ok(query);
        }
    }
}
