﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeAPI.Models.Entity
{
    public class AuditInfo
    {
        [Required]
        public string UserId { get; set; }
    }
}