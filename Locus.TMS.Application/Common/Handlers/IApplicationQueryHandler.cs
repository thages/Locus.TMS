using MediatR;

namespace Locus.TMS.Application.Common.Handlers
{
    public interface IApplicationQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        new Task<TResponse> Handle(TRequest query, CancellationToken cancellationToken);
    }
}
