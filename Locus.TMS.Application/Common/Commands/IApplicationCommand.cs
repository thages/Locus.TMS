using MediatR;

namespace Locus.TMS.Application.Common.Commands
{
    public interface IApplicationCommand<ReturnObjectType> : IRequest<ReturnObjectType> { }
}
