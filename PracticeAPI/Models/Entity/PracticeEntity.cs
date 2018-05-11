using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeAPI.Models.Entity
{
    public class PracticeEntity
    {
        [Key]
        public int PracticeId { get; set; }
        public string PracticeName { get; set; }
    }
}