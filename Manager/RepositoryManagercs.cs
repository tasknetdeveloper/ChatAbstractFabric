using System.Collections.Generic;

namespace AbstractFabric
{
    internal class RepositoryManager
    {
        private SqlManager sql = new SqlManager();
        private RepositoryType _RepositoryType;
        internal RepositoryManager(RepositoryType RepositoryType_)
        {
            _RepositoryType = RepositoryType_;
        }

        internal void Save(IMessage model)
        {
            if (_RepositoryType == RepositoryType.db)
            {
                if (model.Type == Type.chat) sql.SaveInChat(model);
                if (model.Type == Type.channel) sql.SaveInChannel(model);
                if (model.Type == Type.group) sql.SaveInGroup(model);
            }
        }
        internal void Delete(IMessage model)
        {
            if (_RepositoryType == RepositoryType.db)
            {

            }
        }
        internal void Update(IMessage model)
        {
            if (_RepositoryType == RepositoryType.db)
            {
                if (model.Type == Type.chat) sql.UpdateInChat(model);
                if (model.Type == Type.channel) sql.UpdateInChannel(model);
                if (model.Type == Type.group) sql.UpdateInGroup(model);
            }
        }
        internal List<T> Get<T>()
        {
            List<T> result = null;

            return result;
        }

    }
}
