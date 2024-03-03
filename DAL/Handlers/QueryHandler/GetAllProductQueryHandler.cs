using DAL.Queries.Request;
using DAL.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Handlers.QueryHandler
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAll(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            return ApplicationDbContext.ProductList.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stok = product.Stock,
                CreateTime = DateTime.Now,
            }).ToList();
        }
    }
}
