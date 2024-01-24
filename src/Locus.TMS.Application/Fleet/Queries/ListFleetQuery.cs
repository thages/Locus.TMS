using Locus.TMS.Application.Common.Queries;
using Locus.TMS.Domain.Fleet.DataTransferObjects;

namespace Locus.TMS.Application.Fleet.Queries;

public class ListFleetQuery : IApplicationQuery<IEnumerable<FleetItem>> { }