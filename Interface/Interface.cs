
namespace AbstractFabric
{
    internal interface IMessage
    {
        string From { get; set; }
        string To { get; set; }
        Type Type { get; set; }
    }
    internal interface IController
    {
        void GetMessage(IMessage msg);
        void SendMessage(IMessage msg);
        void UpdateMessage(IMessage msg);
        void DeleteMessage(IMessage msg);
    }
}
