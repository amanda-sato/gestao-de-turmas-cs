using System.Text.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Gerenciador_de_Turmas
{
    public class Repo<T> : IEnumerable<T> where T : IRegistro, new()
    {
        int nextId = 1;
        protected List<T> _list = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int getNextId() => nextId;

        public virtual void Add(T item)
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

        public void salvarPara(string arquivoJson)
        {
            FileStream fs = File.Create(arquivoJson);
            Aes cod = Aes.Create();
            CryptoStream cr = new CryptoStream(fs, cod.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cr);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<T>));
            ser.WriteObject(sw.BaseStream, _list);

            sw.Close();
            fs.Close();

            FileStream fsChave = File.Create($"{arquivoJson}.key");

            BinaryWriter bw = new BinaryWriter(fsChave);

            bw.Write(cod.Key);
            bw.Write(cod.IV);
            bw.Close();
            fsChave.Close();
        }

        public void carregarDe(string arquivoJson)
        {
            if (!File.Exists(arquivoJson)) return;

            FileStream fich = File.OpenRead(arquivoJson);
            FileStream chave = File.OpenRead($"{arquivoJson}.key");

            Aes cod = Aes.Create();
            BinaryReader brKey = new BinaryReader(chave);
            cod.Key = brKey.ReadBytes(32);
            cod.IV = brKey.ReadBytes(16);

            CryptoStream cryptoStream = new CryptoStream(fich, cod.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader streamReader = new StreamReader(cryptoStream);
            
            string json = streamReader.ReadToEnd();

            MemoryStream memoryStream  = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<T>));

            _list = (List<T>)serializer.ReadObject(memoryStream);

            int maxId = _list.Max(item => item.getId());
            nextId = maxId + 1;

            streamReader.Close();
            fich.Close();
            chave.Close();
        }
    }
}
