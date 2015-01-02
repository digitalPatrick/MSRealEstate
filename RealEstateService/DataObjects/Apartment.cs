using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateService.DataObjects
{
    //rename Apartment to Property
    //add propertyType enum { town house, studio apartment etc }
    public class Apartment : EntityData
    {
        public Apartment()
        {
            Images = new List<Image>();
        }

        public virtual Address ApartmentAddress { get; set; }
        public string Description { get; set; }

        [Range(1, 99)]
        public int NumOfRooms { get; set; }

        public double Price { get; set; }

        public bool Featured { get; set; }

        public string PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}