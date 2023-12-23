using Locus.TMS.Application.Common.Queries;
using Locus.TMS.Domain.Transportation.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.TMS.Application.Transportation.Queries
{
    public class ListAllLoadsQuery : IApplicationQuery<IEnumerable<LoadItem>>
    {
    }
}
