using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateService.DTO
{
    public class PersonDTO : EntityDTO
    {

        public string AvatarUrl { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(50), Required]
        public string FirstName { get; set; }

        [MaxLength(50), Required]
        public string LastName { get; set; }

        public bool Featured { get; set; }

        public ContactDTO Contact { get; set; }

        public AddressDTO BusinessAddress { get; set; }

        public SocialDTO Social { get; set; }

    }
}