namespace OO_Design_Patterns.CommandMode
{
    public class AbstractCommand
    {
        protected Receiver receiver;

        public AbstractCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public virtual void Excute()
        {
            receiver.Action();
        }
    }
}