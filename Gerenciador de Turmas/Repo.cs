﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public class Repo<T> : IEnumerable<T> where T : IRegistro
    {
        protected readonly List<T> _list = new List<T>();

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
            int index = _list.FindIndex(e => e.getId() == item.getId());

            if (index < 0)
            {
                throw new System.Exception($"Não há item com id {item.getId()}");
            }

            _list.RemoveAt(index);

            return true;
        }

        public void Atualizar(T item)
        {
            int index = _list.FindIndex(e => e.getId() == item.getId());

            if (index < 0)
            {
                throw new System.Exception($"Não há item com id {item.getId()}");
            }

            _list[index] = item;
        }

        public T GetPorId(int id)
        {
            foreach (T item in _list)
            {
                if (item.getId() == id)
                {
                    return item;
                }
            }

            throw new System.Exception($"Não há item com id {id}");
        }
    }
}
