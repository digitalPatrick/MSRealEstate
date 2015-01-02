using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateService.DataObjects
{
    public class Person : EntityData
    {

        public Person()
        {
            Apartments = new List<Apartment>();
        }

        public string AvatarUrl { get; set; }

        [Index(IsUnique = true), MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(50), Required]
        public string FirstName { get; set; }

        [MaxLength(50), Required]
        public string LastName { get; set; }

        public bool Featured { get; set; }

        public string ContactId { get; set; }

        public string BusinessAddressId { get; set; }

        public string SocialId { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }

        [ForeignKey("ContactId")]
        public virtual Contact Contact { get; set; }

        [ForeignKey("BusinessAddressId")]
        public virtual Address BusinessAddress { get; set; }

        [ForeignKey("SocialId")]
        public virtual Social Social { get; set; }

    }
}