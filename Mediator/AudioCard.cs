namespace Mediator
{
    //Concrete Colleague
    public class AudioCard : Unit //  CPU'dan gelen ses datalarını işliyor
    {
        public AudioCard(IMorherboard morherboard) : base(morherboard)
        {
        }
        public void GetAudio(string audioData)
        {
            string[] datas = audioData.Split(",");
            foreach (string data in datas) 
            {
                Console.WriteLine($"Gelen ses : {data}");
            }
        }
    }
}
