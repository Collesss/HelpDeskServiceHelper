using HelpDeskServiceHelper.Repository.Db.ConfigurationsModels;
using HelpDeskServiceHelper.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskServiceHelper.Repository.Db
{
    public class RepositoryDbContext : DbContext
    {
        public DbSet<ManufacturerEntity> Manufacturers { get; set; }

        public DbSet<ModelEntity> Models { get; set; }


        public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ManufacturerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ModelEntityConfiguration());
        }
    }
}
