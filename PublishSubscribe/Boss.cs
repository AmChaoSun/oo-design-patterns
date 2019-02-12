namespace OO_Design_Patterns.PublishSubscribe
{
    public class Boss : ISubject
    {
        public string SubjectState { get; set; }
        public delegate void EventHandler();
        public event EventHandler Update;
        public void Notify()
        {
            Update();
        }
    }
}