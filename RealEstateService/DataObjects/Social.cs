using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RealEstateService.DataObjects
{
    public class Social : EntityData
    {
        [MaxLength(100)]
        public string FaceBook { get; set; }

        [MaxLength(100)]
        public string Micrsoft { get; set; }

        [MaxLength(100)]
        public string Twitter { get; set; }

        [MaxLength(100)]
        public string Instagram { get; set; }

        [MaxLength(100)]
        public string GooglePlus { get; set; }

        [MaxLength(100)]
        public string Yahoo { get; set; }
    }
}