namespace MediatorShipping
{
    public class ZCompony : Company
    {
        public ZCompony(IShipping shipping) : base(shipping)
        {
        }
        public override void StartShipping()
        {
            Console.WriteLine("Araç Ankara'dan kalktı. Edirne'ye yola çıktı.");
            _shipping.Transfer(this);
        }
    }
}
