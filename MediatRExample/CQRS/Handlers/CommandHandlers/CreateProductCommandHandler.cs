
using DAL;
using MediatR;
using MediatRExample.CQRS.Command.Request;
using MediatRExample.CQRS.Command.Response;

namespace MediatRExample.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
           var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Quantity,
                CreateTime = DateTime.UtcNow,
            });
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id,
            };
        }
    }
}
