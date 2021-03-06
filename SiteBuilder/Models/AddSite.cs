﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteBuilder.Models
{
    public class AddSite
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int TypeMenuId { get; set; }
        [Required]
        public int StyleTypeId { get; set; }
        [Required]
        public string Tags { get; set; }
    }
}