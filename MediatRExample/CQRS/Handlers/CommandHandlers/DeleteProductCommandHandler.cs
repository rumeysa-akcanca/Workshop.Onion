using DAL;
using MediatR;
using MediatRExample.CQRS.Command.Request;
using MediatRExample.CQRS.Command.Response;

namespace MediatRExample.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public  async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteProduct = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == request.Id);
            ApplicationDbContext.ProductList.Remove(deleteProduct);
            return  new DeleteProductCommandResponse
            { 
                IsSuccess = true ,
            };
        }
    }
}
