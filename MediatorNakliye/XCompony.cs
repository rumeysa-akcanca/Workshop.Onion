namespace MediatorShipping
{
    public class XCompony : Company
    {
        public XCompony(IShipping shipping) : base(shipping)
        {

        }
        public override void StartShipping()
        {
            Console.WriteLine("Araç  Iğdır'tan kalktı.Sivasa doğru yola çıktı");
            _shipping.Transfer(this);
        }
    }
}
