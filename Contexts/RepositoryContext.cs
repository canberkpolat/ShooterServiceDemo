using Microsoft.EntityFrameworkCore;
using ShooterServiceDemo.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShooterServiceDemo.Contexts
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ShootingRecord> ShootingRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(b => {
                b.HasMany(x => x.Shootings)
                .WithOne()
                .HasForeignKey(u => u.ShooterID);
            });
        }
    }
}
