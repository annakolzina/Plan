using System.Collections.Generic;
using System.Linq;

namespace Univer.PlanTask.Core.Store.Impl
{
    /// <summary>
    /// Хранилище в памяти
    /// </summary>
    public class MemoryStore : IBaseStore
    {
        private IList<IEntity> store = new List<IEntity>();

        ///<inheritdoc/>
        public void Create(IEntity model)
        {
            if (model != null)
            {
                store.Add(model);
            }
        }

        ///<inheritdoc/>
        public bool Delete(long Id)
        {
            var item = Get(Id);
            if (item != null)
            {
                store.Remove(item);
            }
            return true;
        }

        ///<inheritdoc/>
        public IEnumerable<IEntity> Find(string[] args)
        {
            return store;
        }

        ///<inheritdoc/>
        public IEntity Get(long id)
        {
            return store.FirstOrDefault(item => item.Id == id);
        }

        ///<inheritdoc/>
        public IEnumerable<IEntity> GetAll()
        {
            return store;
        }

        ///<inheritdoc/>
        public void Update(IEntity model)
        {
            if (model != null)
            {
                if (Delete(model.Id))
                {
                    Create(model);
                }
            }
        }
    }
}
