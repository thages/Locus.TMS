using Locus.TMS.Domain.Fleet.DataTransferObjects;
using Locus.TMS.Domain.Fleet.Models;
using Riok.Mapperly.Abstractions;

namespace Locus.TMS.Application.Fleet.Mappers;

[Mapper]
public partial class FleetMapper
{
    public partial FleetItem Map(Vehicle entity);
    public partial IEnumerable<FleetItem> Map(IEnumerable<Vehicle> vehicles);
}