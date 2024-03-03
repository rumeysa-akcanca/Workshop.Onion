namespace MediatorShipping
{
    public abstract class Company
    {
       protected IShipping _shipping;
        protected Company(IShipping shipping)
        {
           _shipping = shipping;
        }
        public abstract void StartShipping();
    }
}
