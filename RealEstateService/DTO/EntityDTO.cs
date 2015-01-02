using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateService.DTO
{
    public abstract class EntityDTO
    {
        public DateTimeOffset? CreatedAt { get; set; }
        public bool Deleted { get; set; }
        public string Id { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public byte[] Version { get; set; }
    }
}