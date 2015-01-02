using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateService.DTO
{
    public class HomePageDTO
    {
        public HomePageDTO()
        {
            LatestApartments = new List<ApartmentDTO>();
            FeaturedAgents = new List<PersonDTO>();
            ApartmentsNearYou = new List<ApartmentDTO>();
            Blogs = new List<PersonDTO>();
        }

        public ICollection<ApartmentDTO> LatestApartments { get; set; }
        public ICollection<PersonDTO> FeaturedAgents { get; set; }
        public ICollection<ApartmentDTO> ApartmentsNearYou { get; set; }
        public ICollection<PersonDTO> Blogs { get; set; }
    }
}