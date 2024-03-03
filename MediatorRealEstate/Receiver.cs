namespace MediatorRealEstate
{
    public class Receiver : Person
    {
        public Receiver(ITransfer transfer) : base(transfer)
        {
        }

        public  void PayTheHouse(int balance)
        {
            Console.WriteLine($"Alıcı : ödeme yapılmıştır.");
            _transfer.MoneyTransfer(this,balance);
        }
    }
}
