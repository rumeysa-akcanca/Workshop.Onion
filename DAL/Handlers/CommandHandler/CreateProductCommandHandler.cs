using DAL.Commands.Request;
using DAL.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Handlers.CommandHandler
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProdcut(CreateProductCommandRequest createProductCommandRequest) 
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {

                Id = id,
                Name = createProductCommandRequest.Name,
                Price = createProductCommandRequest.Price,
                Stock = createProductCommandRequest.Stock,
                CreateTime = DateTime.Now
            });
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id,
            };
            
        
        }
    }
}
