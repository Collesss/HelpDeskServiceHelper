using HelpDeskServiceHelper.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDeskServiceHelper.Repository.Db.ConfigurationsModels
{
    public class ManufacturerEntityConfiguration : IEntityTypeConfiguration<ManufacturerEntity>
    {
        public void Configure(EntityTypeBuilder<ManufacturerEntity> builder)
        {
            builder.HasKey(manuf => manuf.Id);

            builder.Property(manuf => manuf.Name)
                .IsRequired();
        }
    }
}
