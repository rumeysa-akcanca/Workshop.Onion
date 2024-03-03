namespace Mediator
{
    public class CPU : Unit  //Concrete Colleague
    {
        //CD'de gelen veriler , ses ve video datalarına ayrıştırarak anakart vasıtasıyla ekran kartı ve ses kartına
        //gönderiyor
        public CPU(IMorherboard morherboard) : base(morherboard)
        {
        }
        private string _videoData;
        private string _audioData;
        public string videoData => _videoData;
        public string audioData => _audioData;

        public void DataHandler(string cdData)
        {
            string[] array = cdData.Split('*');
            _videoData = array[0]; //görüntü değerleri video data olarak alınıyor
            _audioData = array[1]; //ses değerleri ses data olarak alınıyor
            _motherboard.Change(this);

        }
    }
}
