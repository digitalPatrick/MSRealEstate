using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateService.DataObjects
{
    public class Contact : EntityData
    {
        [Index(IsUnique = true), MaxLength(50)]
        public string EmailAddress { get; set; }

        public string CellPhone { get; set; }

        public string FaxPhone { get; set; }

        public string BusinessPhone { get; set; }
    }
}