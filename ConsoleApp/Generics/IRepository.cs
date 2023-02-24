using System;
namespace Generics
{
    public interface IRepository<T> where T : class
    {
        int id { get; set; }

        void Add(T obj);
        void Remove(T obj);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public class GenericsRepository<T> where T : class, IRepository<T> 
    {
        private List<T> repo = new List<T>();

        public void Add(T obj)
        {
            if (GetById(obj.id) == null)
            {
                repo.Add(obj);
            }
        }

        public void Remove(T obj)
        {
            T t = GetById(obj.id);
            if (t != null)
            {
                repo.Remove(t);
            }
        }

        public void Save()
        {
            Console.WriteLine("Save Successfully!");
        }

        IEnumerable<T> GetAll()
        {
            return repo;
        }

        T GetById(int id)
        {
            for (int i = 0; i < repo.Count; i++)
            {
                if (repo[i].Id == id)
                {
                    return repo[i];
                }
            }
            return null;
        }
    }
}

