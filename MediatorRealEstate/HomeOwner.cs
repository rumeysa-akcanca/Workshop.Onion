
namespace MediatorRealEstate
{
    public class HomeOwner : Person
    {
        public HomeOwner(ITransfer transfer) : base(transfer)
        {
        }
        public void GetMoney(int balance)
        {
            Console.WriteLine($"Satıcı :{balance} Tl kadar konut bedeli alınmıştır.");
            _transfer.MoneyTransfer(this,balance);
        }
    }
}
