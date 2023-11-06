using Locus.TMS.Application.Contacts.Commands;
using Locus.TMS.Domain.Contacts.DataTransferObjects;
using Locus.TMS.Domain.Contacts.Models;
using Riok.Mapperly.Abstractions;

namespace Locus.TMS.Application.Contacts.Mappers
{
    [Mapper]
    public partial class DriverMapper
    {
        public partial Driver Map(CreateDriverCommand command);
        public partial DriverItem Map(Driver entity);
        public partial IEnumerable<DriverItem> Map(IEnumerable<Driver> list);
    }
}
