
namespace AbstractFabric
{
    internal class CommunicationClient
    {
        private RepositoryType repType = RepositoryType.db;
        private IController cChat;
        private IController cGroup;
        internal CommunicationClient()
        {
            cChat = new Chat(repType);
            cGroup = new Group(repType);
        }
        internal void Recieve(string msg)
        {
            //TODO
        }
        internal void Update(Type t, string msg)
        {
            if (t == Type.chat)
            {
                cChat.UpdateMessage(CreateMessage(msg, t));
            }
            else if (t == Type.group)
            {
                cGroup.UpdateMessage(CreateMessage(msg, t));
            }
        }

        internal void Send(Type t, string msg)
        {
            if (t == Type.chat)
            {
                cChat.SendMessage(CreateMessage(msg,t));
            }
            else if (t == Type.group)
            {
                cGroup.SendMessage(CreateMessage(msg, t));
            }
        }

        internal void Delete(Type t, string msg)
        {
            if (t == Type.chat)
            {
                cChat.DeleteMessage(CreateMessage(msg, t));
            }
            else if (t == Type.group)
            {
                cGroup.DeleteMessage(CreateMessage(msg, t));
            }
        }

        private Message2 CreateMessage(string msg, Type t) {
            return new Message2
            {
                From = "from",
                To = "to",
                Type = t
            };
        }
    }
}
