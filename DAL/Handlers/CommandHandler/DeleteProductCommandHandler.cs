using DAL.Commands.Request;
using DAL.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Handlers.CommandHandler
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest deleteProductCommandRequest)
        {
            var deletePsouct = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == deleteProductCommandRequest.Id);
                ApplicationDbContext.ProductList.Remove(deletePsouct);
            return new DeleteProductCommandResponse
            {
                IsSuccess = true,
            };

        }
    }
}
