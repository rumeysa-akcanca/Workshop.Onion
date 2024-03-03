namespace Mediator
{
    public class DisplayCard : Unit
    {
        public DisplayCard(IMorherboard morherboard) : base(morherboard)
        {
        }

        public void GetVisual(string videoData)
        {
            string[] datas = videoData.Split(",");
            foreach (string data in datas)
            {
                Console.WriteLine($"Gelen görüntü : {data}");
            }

        }
    }
}