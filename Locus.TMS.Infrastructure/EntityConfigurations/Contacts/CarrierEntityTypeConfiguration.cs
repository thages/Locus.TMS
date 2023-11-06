namespace Locus.TMS.Infrastructure.EntityConfigurations.Contacts
{
    internal class CarrierEntityTypeConfiguration : IEntityTypeConfiguration<Carrier>
    {
        public void Configure(EntityTypeBuilder<Carrier> builder)
        {
            builder.ToTable("carriers", TmsContext.SCHEMA);

            builder.HasKey(v => v.Id);

            builder.OwnsOne(v => v.Address);

            builder.OwnsOne(v => v.Responsible);
        }
    }
}
