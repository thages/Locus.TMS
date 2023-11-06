using Autofac;
using Autofac.Features.Variance;
using Locus.TMS.Application.Contacts.Mappers;
using Locus.TMS.Application.Fleet.Mappers;
using Locus.TMS.Domain.Contacts.Repositories;
using Locus.TMS.Domain.Fleet.Repositories;
using Locus.TMS.Infrastructure;
using Locus.TMS.Infrastructure.Repositories.Contacts;
using Locus.TMS.Infrastructure.Repositories.Fleet;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Locus.TMS.Application
{
    public class AutofacModule : Module
    {
        private readonly IConfiguration _configuration;

        public AutofacModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var applicationAssembly = AppDomain.CurrentDomain.Load($"Locus.TMS.Application");
            var domainAssembly = AppDomain.CurrentDomain.Load($"Locus.TMS.Domain");
            var infraAssembly = AppDomain.CurrentDomain.Load($"Locus.TMS.Infrastructure");

            #region MediatR
            builder
                .RegisterSource(new ContravariantRegistrationSource());

            builder
              .RegisterType<Mediator>()
              .As<IMediator>()
              .InstancePerLifetimeScope();

            var openHandlersType = new[] { typeof(IRequestHandler<,>), typeof(INotificationHandler<>) };
            foreach (var openHandler in openHandlersType)
            {
                builder.RegisterAssemblyTypes(applicationAssembly)
                    .AsClosedTypesOf(openHandler)
                    .InstancePerDependency();
            }
            #endregion

            #region EF
            var optionBuilder = new DbContextOptionsBuilder<TmsContext>();

            optionBuilder.UseSqlServer(_configuration["ConnectionStrings:LocusSqlConnection"]);
            builder.Register(x =>
            {
                return new TmsContext(optionBuilder.Options);
            }).As<TmsContext>().InstancePerLifetimeScope();

            new TmsContext(optionBuilder.Options).Database.Migrate();
            #endregion

            #region Repositories
            builder.RegisterType<VehicleRepository>().As<IVehicleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DriverRepository>().As<IDriverRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CarrierRepository>().As<ICarrierRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();
            #endregion

            #region Mappers
            builder.RegisterType<VehicleMapper>().InstancePerLifetimeScope();
            builder.RegisterType<DriverMapper>().InstancePerLifetimeScope();
            #endregion
        }
    }
}