using Locus.TMS.Application.Commands.Fleet;
using Locus.TMS.Domain.Fleet.DataTransferObjects;
using Locus.TMS.Domain.Fleet.Models;
using Riok.Mapperly.Abstractions;

namespace Locus.TMS.Application.Fleet.Mappers
{
    [Mapper]
    public partial class VehicleMapper
    {
        public partial Vehicle Map(CreateVehicleCommand vehicleCommand);
        public partial VehicleItem Map(Vehicle entity);
        public partial IEnumerable<VehicleItem> Map(IEnumerable<Vehicle> vehicles);
    }
}
