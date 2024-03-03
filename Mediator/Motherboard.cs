namespace Mediator
{
    public class Motherboard : IMorherboard  //Concrete Mediator
    {
        CDDriver _cdDriver;
        CPU _cpu;
        DisplayCard _displayCard;
        AudioCard _audioCard;

        public CDDriver CDDriver { set =>  _cdDriver = value; }
        public CPU CPU { set => _cpu = value; }
        public DisplayCard DisplayCard { set => _displayCard = value; }
        public AudioCard AudioCard { set => _audioCard = value; }
        public void Change(Unit unit)
        {
            if(unit is CDDriver)
            {
                string cdData = _cdDriver.cdData;
                _cpu.DataHandler(cdData);
            }
            else if(unit is CPU) 
            {
                string videoData = _cpu.videoData;
                string audioData = _cpu.audioData;
                _displayCard.GetVisual(videoData);
                _audioCard.GetAudio(audioData);
            }
        }
    }
}
