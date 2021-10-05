
namespace AbstractFabric
{
    internal class ControllerBase
    {
        private RepositoryType _repType = RepositoryType.empty;
        private RepositoryManager dataRepository = null;
        internal ControllerBase(RepositoryType repType)
        {
            _repType = repType;
            dataRepository = new RepositoryManager(_repType);
        }

        public void GetMessageBase(IMessage model)
        {
            dataRepository.Save(model);
        }
        public void SendMessageBase(IMessage model)
        {
            dataRepository.Save(model);

        }

        public void DeleteMessageBase(IMessage model)
        {
            dataRepository.Delete(model);
        }

        public void UpdateMessageBase(IMessage model)
        {
            dataRepository.Update(model);
        }
    }
}
