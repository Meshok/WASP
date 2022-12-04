using System;
using System.Collections.Generic;
using System.Text;

namespace WASP_PR_3
{
    class Store
    {
        private string _storeName;
        private string _address;
        private List<Audio> _audios;
        private List<DVD> _dvds;

        public Store(string storeName, string address)
        {
            _storeName = storeName;
            _address = address;
            _audios = new List<Audio>();
            _dvds = new List<DVD>();
        }

        public List<Audio> GetAudios()
        {
            return _audios;
        }

        public List<DVD> GetDvds()
        {
            return _dvds;
        }

        public static Store operator+(Store store, Audio audio)
        {
            store._audios.Add(audio);
            return store;
        }

        public static Store operator-(Store store, Audio audio)
        {
            store._audios.Remove(audio);
            return store;
        }

        public static Store operator+(Store store, DVD dvd)
        {
            store._dvds.Add(dvd);
            return store;
        }

        public static Store operator-(Store store, DVD dvd)
        {
            store._dvds.Remove(dvd);
            return store;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder($"Название магазина: {_storeName}, адрес: {_address}");
            foreach(Audio audio in _audios)
            {
                stringBuilder.Append('\n');
                stringBuilder.Append(audio);
            }
            foreach (DVD dvd in _dvds)
            {
                stringBuilder.Append('\n');
                stringBuilder.Append(dvd);
            }
            return stringBuilder.ToString();
        }
    }
}
