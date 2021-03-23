﻿using System;
using System.ComponentModel.DataAnnotations;
using Pds.Core.Enums;

namespace Pds.Api.Contracts.Person
{
    public class CreateContentRequest
    {
        [Required]
        public Guid? ChannelId { get; set; }

        [Required, EnumDataType(typeof(ContentType))]
        public ContentType Type { get; set; }

        [Required, EnumDataType(typeof(SocialMediaType))]
        public SocialMediaType SocialMediaType { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime? EndDateUtc { get; set; }

        [Required]
        public string OrderContact { get; set; }

        [Required, EnumDataType(typeof(ContactType))]
        public ContactType OrderContactType { get; set; }
        
        [Required]
        [Range(0.00, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public decimal OrderCost { get; set; }
        
        public string OrderComment { get; set; }
    }
}