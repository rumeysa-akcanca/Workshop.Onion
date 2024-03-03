
namespace MediatorRealEstate
{
    public class Realtor : Person
    {
        public Realtor(ITransfer transfer) : base(transfer)
        {
        }

        public  void GetCommission(int balance)
        {
            Console.WriteLine($"Emlakçı : {balance} TL kadar komisyon alınmıştır.");
        }
    }
}
