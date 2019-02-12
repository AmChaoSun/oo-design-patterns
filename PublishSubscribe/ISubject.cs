namespace OO_Design_Patterns.PublishSubscribe
{
    public interface ISubject
    {
        void Notify();
        string SubjectState { get; set; }
    }
}