using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateService.DTO
{
    public class ContactDTO
    {
        public string EmailAddress { get; set; }

        public string CellPhone { get; set; }

        public string FaxPhone { get; set; }

        public string BusinessPhone { get; set; }
    }
}