using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace Univer.PlanTask.Core.Store.Impl
{
    /// <summary>
    /// Файловое хранилище
    /// </summary>
    public class FileStore<T> : IBaseStore where T: class, IEntity 
    {
        private IList<IEntity> store = new List<IEntity>();

        private JavaScriptSerializer Serializer = new JavaScriptSerializer();

        private string filePath { get; set; }

        private void Flush()
        {
            var json = Serializer.Serialize(store);
            File.WriteAllText(filePath, json);
        }

        public FileStore()
        {
            filePath = @"E:\path.json";
            Init();
        }
        public FileStore(string path)
        {
            filePath = path;
            Init();
        }

        public void Init()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var data = Serializer.Deserialize<T[]>(json);

                foreach (var item in data)
                {
                    store.Add(item);
                }
            }
        }

        ///<inheritdoc/>
        public void Create(IEntity model)
        {
            if (model != null)
            {
                store.Add(model);
                Flush();
            }
        }

        ///<inheritdoc/>
        public bool Delete(long Id)
        {
            var item = Get(Id);
            if (item != null)
            {
                store.Remove(item);
                Flush();
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
