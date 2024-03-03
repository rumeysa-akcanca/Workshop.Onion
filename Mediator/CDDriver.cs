namespace Mediator
{
    public class CDDriver : Unit //Concrete Colleague //farazi dataları okuyarak anakartı bilgilendirir
    {
        public CDDriver(IMorherboard morherboard) : base(morherboard)
        {
           
        }
        private string _cdData;
        public string cdData => _cdData;
        public void ReadCD()
        {
            _cdData = "görüntü1, görüntü2,gürüntü3*ses1, ses2,ses3";
            _motherboard.Change(this);
        }
    }
}
