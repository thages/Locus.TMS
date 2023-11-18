using Locus.TMS.Domain.Transportation.Models;

namespace Locus.TMS.Infrastructure.EntityConfigurations.Transportation
{
    internal class LoadEntityTypeConfiguration : IEntityTypeConfiguration<Load>
    {
        public void Configure(EntityTypeBuilder<Load> builder)
        {
            builder.ToTable("loads", TmsContext.SCHEMA);

            builder.HasKey(e => e.Id);

            builder.Property(e => e._LoadStatus).HasColumnName("LoadStatus");
            
            builder.Property(e => e._VehicleStatus).HasColumnName("VehicleStatus");
            
            builder.Property(e => e._Commodity).HasColumnName("Commodity");

            builder.OwnsOne(e => e.EquipamentInformation);

            builder.Property(e => e.EquipamentInformation._EquipamentType).HasColumnName("EquipamentType");

            builder.OwnsOne(e => e.EquipamentSize);
        }
    }
}
