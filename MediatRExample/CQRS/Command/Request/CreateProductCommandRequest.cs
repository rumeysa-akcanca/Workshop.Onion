using MediatR;
using MediatRExample.CQRS.Command.Response;

namespace MediatRExample.CQRS.Command.Request
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
