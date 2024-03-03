using MediatR;
using MediatRExample.CQRS.Query.Response;

namespace MediatRExample.CQRS.Query.Request
{
    public class GetByIdProductQueryRequest :IRequest<GetByIdProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
