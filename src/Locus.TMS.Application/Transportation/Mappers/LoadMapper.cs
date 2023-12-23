using Locus.TMS.Domain.Transportation.DataTransferObjects;
using Locus.TMS.Domain.Transportation.Models;
using Riok.Mapperly.Abstractions;

namespace Locus.TMS.Application.Transportation.Mappers
{
    [Mapper]
    public partial class LoadMapper
    {
        public partial LoadItem Map(Load entity);
        public partial IEnumerable<LoadItem> Map(IEnumerable<Load> list);
    }
}
