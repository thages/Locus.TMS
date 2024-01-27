using MediatR;

namespace Locus.TMS.Application.Common.Commands
{
    public interface IApplicationCommand<out TReturnObjectType> : IRequest<TReturnObjectType> { }
}
