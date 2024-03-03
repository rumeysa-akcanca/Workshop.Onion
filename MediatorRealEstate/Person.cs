namespace MediatorRealEstate
{
    public abstract class Person
    {
        protected ITransfer _transfer;
        protected Person(ITransfer transfer)
        {
            _transfer = transfer;
        }
       

    }
}
