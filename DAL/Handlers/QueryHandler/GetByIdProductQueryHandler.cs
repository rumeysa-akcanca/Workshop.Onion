using DAL.Queries.Request;
using DAL.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Handlers.QueryHandler
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse  GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryrequest)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == getByIdProductQueryrequest.Id);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CreateTime = DateTime.Now,
            };

        }
    }
}
