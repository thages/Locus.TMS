using Locus.TMS.Infrastructure.EntityConfigurations;
using Locus.TMS.Infrastructure.EntityConfigurations.Contacts;
using Locus.TMS.Infrastructure.EntityConfigurations.Fleet;
using Microsoft.EntityFrameworkCore.Design;

namespace Locus.TMS.Infrastructure
{
    public class TmsContext : DbContext
    {
        public const string SCHEMA = "tms";
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public TmsContext(DbContextOptions<TmsContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(SCHEMA);
            modelBuilder.ApplyConfiguration(new VehicleEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DriverEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CarrierEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
    public class TmsContextContextDesignFactory : IDesignTimeDbContextFactory<TmsContext>
    {
        public TmsContext CreateDbContext(string[] args)
        {
           
            var optionsBuilder = new DbContextOptionsBuilder<TmsContext>()
                .UseSqlServer("Server=localhost;Initial Catalog=LocusTms;Integrated Security=true; TrustServerCertificate=True");

            return new TmsContext(optionsBuilder.Options);
        }
    }
}