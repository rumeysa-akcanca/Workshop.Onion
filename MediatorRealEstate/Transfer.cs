using System.ComponentModel.Design;

namespace MediatorRealEstate
{
    public class Transfer : ITransfer
    {
        Receiver _receiver;
        Realtor _realtor;
        HomeOwner _homeOwner;
        public Receiver Receiver { set =>  _receiver = value; }
        public Realtor Realtor {  set => _realtor = value; }
        public HomeOwner HomeOwner { set => _homeOwner = value; }

        public void MoneyTransfer(Person person, int balance)
        {
            if (person is Receiver && balance > 100000)
                _receiver.PayTheHouse(balance);
            else if(person is Receiver && balance <= 100000)
            {
                _realtor.GetCommission(balance*10/100);
                _homeOwner.GetMoney(balance);
            }
            else if(person is HomeOwner && balance >100000)
            {
                _realtor.GetCommission(balance * 3 / 100);
            }
           
        }
    }
}
