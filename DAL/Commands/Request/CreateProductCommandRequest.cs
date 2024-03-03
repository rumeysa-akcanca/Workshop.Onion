
namespace DAL.Commands.Request
{
    public class CreateProductCommandRequest
    {
        //product ekleme isteklerinde kullanılmakta
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
