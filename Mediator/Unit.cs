namespace Mediator
{
    public  abstract class Unit  //IColleague
    {
        //tüm Colleague' ler referans alır
        protected IMorherboard _motherboard; //mediator interface
        protected Unit(IMorherboard morherboard)
        {
            _motherboard = morherboard;
        }
    }
}
