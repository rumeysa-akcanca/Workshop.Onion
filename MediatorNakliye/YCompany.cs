

namespace MediatorShipping
{
    public class YCompany : Company
    {
        public YCompany(IShipping shipping) : base(shipping)
        {
        }
        public override void StartShipping()
        {
            Console.WriteLine("Araç  Sivas'tan kalktı.Ankaraya doğru yola çıktı.");
            _shipping.Transfer(this);
        }
    }
}
