
namespace AbstractFabric
{
    internal class Chat : ControllerBase, IController
    {
        internal Chat(RepositoryType repType) : base(repType) { }
        public void GetMessage(IMessage model)
        {
            base.GetMessageBase(model);
            //TODO
        }
        public void SendMessage(IMessage model)
        {
            base.SendMessageBase(model);
            //TODO - INSERT IN UI panel+
        }

        public void UpdateMessage(IMessage model)
        {
            base.SendMessageBase(model);
            //TODO - Update IN UI panel
        }

        public void DeleteMessage(IMessage model)
        {
            base.DeleteMessageBase(model);
            //TODO - Delete from UI panel
        }
    }
}
