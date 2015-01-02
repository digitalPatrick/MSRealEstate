using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace RealEstateService.DataObjects
{
    public class Image : EntityData
    {
        public string ImageUrl { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public bool IsLeadImage { get; set; }

        public string ApartmentId { get; set; }

        [ForeignKey("ApartmentId")]
        public virtual Apartment Appartment { get; set; }
    }
}