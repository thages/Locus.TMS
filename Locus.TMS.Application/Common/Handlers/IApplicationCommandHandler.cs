using MediatR;

namespace Locus.TMS.Application.Common.Handlers
{
    public interface IApplicationCommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        new Task<TResponse> Handle(TRequest command, CancellationToken cancellationToken);
    }
}
