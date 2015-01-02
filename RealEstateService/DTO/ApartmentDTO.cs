using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateService.DTO
{
    //rename Apartment to Property
    //add propertyType enum { town house, studio apartment etc }
    public class ApartmentDTO : EntityDTO
    {
        public ApartmentDTO()
        {
            Images = new List<ImageDTO>();
        }

        public AddressDTO ApartmentAddress { get; set; }
        public string Description { get; set; }

        [Range(1, 99)]
        public int NumOfRooms { get; set; }

        public double Price { get; set; }

        public bool Featured { get; set; }

        public string PersonId { get; set; }

        public MainImageDTO MainImage { get; set; }

        public ICollection<ImageDTO> Images { get; set; }
    }
}