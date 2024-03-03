using DAL;
using MediatR;
using MediatRExample.CQRS.Query.Request;
using MediatRExample.CQRS.Query.Response;

namespace MediatRExample.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.ProductList.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Stock,
                CreateTime =product.CreateTime
            }).ToList();
        }
    }
}
