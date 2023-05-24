using System.Collections;
using System.Collections.Generic;

namespace Gerenciador_de_Turmas
{
    public class Repo<T> : IEnumerable<T>
    {
        private readonly List<T> _list = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }
    }
}
