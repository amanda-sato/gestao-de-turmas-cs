using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gerenciador_de_Turmas
{
    public class Repo<T> : IEnumerable<T> where T : IRegistro, new()
    {
        int nextId = 1;
        protected readonly List<T> _list = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int getNextId() => nextId;

        public void Add(T item)
        {
            if (item.getId() < 0)
            {
                item.setId(nextId++);
            }

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

        public void salvarPara(string arquivoTxt)
        {
            FileStream fs = File.Create(arquivoTxt);
            Aes cod = Aes.Create();
            CryptoStream cr = new CryptoStream(fs, cod.CreateEncryptor(), CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cr);

            foreach (T item in _list)
            {
                sw.WriteLine(item.paraTxt());
            }

            sw.Close();
            fs.Close();

            FileStream fsChave = File.Create($"{arquivoTxt}.key");

            BinaryWriter bw = new BinaryWriter(fsChave);

            bw.Write(cod.Key);
            bw.Write(cod.IV);
            bw.Close();
            fsChave.Close();
        }

        public void carregarDe(string arquivoTxt)
        {
            if (!File.Exists(arquivoTxt)) return;

            FileStream fich = File.OpenRead(arquivoTxt);
            FileStream chave = File.OpenRead($"{arquivoTxt}.key");

            //AesCryptoServiceProvider cod = new AesCryptoServiceProvider();
            Aes cod = Aes.Create();
            BinaryReader brKey = new BinaryReader(chave);
            cod.Key = brKey.ReadBytes(32);
            cod.IV = brKey.ReadBytes(16);

            CryptoStream cs = new CryptoStream(fich, cod.CreateDecryptor(), CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(cs);

            int maxId = -1;

            while (sr.Peek() >= 0)
            {
                string raw = sr.ReadLine();

                T novo = new T();
                novo.deTxt(raw);

                _list.Add(novo);

                if (novo.getId() > maxId) {
                    maxId = novo.getId();
                }
            }

            nextId = maxId + 1;

            sr.Close();
            fich.Close();
            chave.Close();
        }
    }
}
