using Locus.TMS.Application.Common.Queries;
using Locus.TMS.Domain.DataTransferObjects.Fleet;

namespace Locus.TMS.Application.Fleet.Queries
{
    public class ListAllVehiclesQuery : IApplicationQuery<IEnumerable<VehicleItem>> { }
}
