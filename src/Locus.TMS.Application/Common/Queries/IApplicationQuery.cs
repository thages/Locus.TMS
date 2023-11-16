using MediatR;

namespace Locus.TMS.Application.Common.Queries
{
    public interface IApplicationQuery<ReturnObjectType> : IRequest<ReturnObjectType> { }
}
