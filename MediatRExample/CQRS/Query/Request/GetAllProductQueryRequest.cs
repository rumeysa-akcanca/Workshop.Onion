using MediatR;
using MediatRExample.CQRS.Query.Response;

namespace MediatRExample.CQRS.Query.Request
{
    public class GetAllProductQueryRequest :IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
