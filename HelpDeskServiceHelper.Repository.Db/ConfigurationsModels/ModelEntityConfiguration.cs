using HelpDeskServiceHelper.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDeskServiceHelper.Repository.Db.ConfigurationsModels
{
    public class ModelEntityConfiguration : IEntityTypeConfiguration<ModelEntity>
    {
        public void Configure(EntityTypeBuilder<ModelEntity> builder)
        {
            builder.HasKey(model => model.Id);

            builder.Property(model => model.Name)
                .IsRequired();

            builder.Property(model => model.ProductNumber)
                .IsRequired();

            builder.HasOne<ManufacturerEntity>()
                .WithMany()
                .HasForeignKey(model => model.ManufacturerId)
                .HasPrincipalKey(manuf => manuf.Id)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
