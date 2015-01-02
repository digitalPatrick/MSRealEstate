using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstateService.DTO
{
    public class AddressDTO
    {
        [MaxLength(100), Required]
        public string Street1 { get; set; }

        [MaxLength(100)]
        public string Street2 { get; set; }

        [MaxLength(50), Required]
        public string City { get; set; }

        [MaxLength(50), Required]
        public string State { get; set; }

        public string ZipCode { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
    }
}