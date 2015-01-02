using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace RealEstateService.DTO
{
    public class ImageDTO
    {
        public string ImageUrl { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public bool IsLeadImage { get; set; }

    }
}