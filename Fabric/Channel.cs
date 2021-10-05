
namespace AbstractFabric
{
    internal class Channel : ControllerBase, IController
    {
        internal Channel(RepositoryType repType) : base(repType) { }
        public void GetMessage(IMessage model)
        {
            base.GetMessageBase(model);
        }
        public void SendMessage(IMessage model)
        {
            base.SendMessageBase(model);
        }
    }
}
