using MediatR;
using MediatRExample.CQRS.Command.Response;

namespace MediatRExample.CQRS.Command.Request
{
    public class DeleteProductCommandRequest :IRequest<DeleteProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
