using Locus.TMS.Application.Common.Queries;
using Locus.TMS.Domain.Contacts.DataTransferObjects;

namespace Locus.TMS.Application.Contacts.Queries
{
    public class ListAllDriversQuery : IApplicationQuery<IEnumerable<DriverItem>>
    {
    }
}
