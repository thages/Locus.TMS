namespace Locus.TMS.Infrastructure.EntityConfigurations.Fleet
{
    internal class VehicleEntityTypeConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("vehicles", TmsContext.SCHEMA);

            builder.HasKey(v => v.Id);

            builder.OwnsOne(v => v.Loading);

            builder.OwnsOne(v => v.Model);

            builder.OwnsOne(v => v.Fuel);

            builder.Property(v => v.Code).ValueGeneratedOnAdd();
        }
    }
}
