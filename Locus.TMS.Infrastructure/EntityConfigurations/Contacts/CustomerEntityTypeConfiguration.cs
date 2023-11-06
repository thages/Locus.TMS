namespace Locus.TMS.Infrastructure.EntityConfigurations.Contacts
{
    internal class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers", TmsContext.SCHEMA);

            builder.HasKey(v => v.Id);

            builder.OwnsOne(v => v.Address);
        }
    }
}
