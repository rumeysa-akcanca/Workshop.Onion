namespace MediatorShipping
{
    public class Shipping : IShipping
    {
        XCompony _XCompony;
        YCompany _yCompany;
        ZCompony _zCompany;
        public XCompony XCompony { set { _XCompony = value; } }
        public YCompany YCompany { set => _yCompany = value; }
        public ZCompony ZCompony { set => _zCompany = value; }
        public void Transfer(Company company)
        {
            if(company is XCompony)
            {
                Console.WriteLine("Eşyalar Sivas'ta tekrar nakledilmek üzere indirildi.");
                _yCompany.StartShipping();
              
                
            }
            else if(company is YCompany)
            {
                Console.WriteLine("Eşyalar Ankara'da tekrar nakledilmek üzere indirildi.");
                _zCompany.StartShipping();   
            }
            else
            {
                Console.WriteLine("Eşyalar Edirne' ye vardı. Şükür");
            }
        }
       
    }
}
