
namespace AbstractFabric
{
    internal class Group : ControllerBase, IController
    {
        internal Group(RepositoryType repType) : base(repType) { }
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
