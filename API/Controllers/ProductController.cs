using DAL.Commands.Request;
using DAL.Commands.Response;
using DAL.Handlers.CommandHandler;
using DAL.Handlers.QueryHandler;
using DAL.Queries.Request;
using DAL.Queries.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        CreateProductCommandHandler _createProductCommandHandler;
        DeleteProductCommandHandler _deleteProductCommandHandler;
        GetAllProductQueryHandler _getAllProductQueryHandler;
        GetByIdProductQueryHandler _getByIdProductQueryHandler;

        public ProductController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getByIdProductQueryHandler = getByIdProductQueryHandler;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] GetAllProductQueryRequest requestmodel)
        {
           List<GetAllProductQueryResponse> products = _getAllProductQueryHandler.GetAll(requestmodel);
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromQuery] GetByIdProductQueryRequest requestmodel)
        {
            GetByIdProductQueryResponse product = _getByIdProductQueryHandler.GetByIdProduct(requestmodel);
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Create([FromQuery] CreateProductCommandRequest requestmodel)
        {
            CreateProductCommandResponse product = _createProductCommandHandler.CreateProdcut(requestmodel);
            return Ok(product);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery] DeleteProductCommandRequest requestmodel)
        {
            DeleteProductCommandResponse response = _deleteProductCommandHandler.DeleteProduct(requestmodel);
            return Ok(response);
        }

    }
}
