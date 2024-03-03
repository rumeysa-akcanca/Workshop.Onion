
namespace DAL.Queries.Response
{
    public class GetAllProductQueryResponse
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public int Stok { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }    
    }
}
