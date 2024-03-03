namespace Mediator
{
    public interface IMorherboard //IMediator
    {
        void Change(Unit unit); //birbiriyle haberleşmeyi sağlayan yapı
        // Colleague tarafından Change tetiklenirse , o zaman mediator diğer nesneyle etkileşim kuracak ve tetikleyecek
    }
}
