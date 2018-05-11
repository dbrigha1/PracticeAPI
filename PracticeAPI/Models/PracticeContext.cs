using PracticeAPI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticeAPI.Models
{
    public class PracticeContext : DbContext
    {
        public DbSet<PracticeEntity> Practice { get; set; }
    }
}