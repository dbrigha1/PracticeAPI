using Microsoft.AspNet.Identity.EntityFramework;
using PracticeAPI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace PracticeAPI.Models
{
    public class PracticeContext : DbContext
    {
        public DbSet<PracticeEntity> Practice { get; set; }

        public async Task<int> SaveChangesAsync(string userId, CancellationToken cancellationToken = new CancellationToken())
        {
            var addedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();

            //populate the CreatedDate, UpdatedDate, and UserId for all new entities
            addedEntities.ForEach(e =>
            {
                if (e.Entity.GetType().GetProperty("UserId") != null)
                {
                    e.Property("UserId").CurrentValue = userId ?? "00000";
                }
            });
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}