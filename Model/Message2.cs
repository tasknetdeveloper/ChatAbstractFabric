
namespace AbstractFabric
{
    internal class Message2 : IMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public Type Type { get; set; }
    }
}
