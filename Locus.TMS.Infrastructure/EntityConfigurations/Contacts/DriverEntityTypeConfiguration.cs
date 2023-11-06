namespace Locus.TMS.Infrastructure.EntityConfigurations.Contacts
{
    internal class DriverEntityTypeConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("drivers", TmsContext.SCHEMA);

            builder.HasKey(v => v.Id);

            builder.OwnsOne(v => v.Address);
        }
    }
}
