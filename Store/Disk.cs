using System;
using System.Collections.Generic;
using System.Text;

namespace WASP_PR_3
{
    class Disk : IStoreItem
    {
        private string _name;
        private string _genre;
        protected int _birnCount;

        public string GetName()
        {
            return _name;
        }

        public virtual int DiskSize { get; }
        public double Price { get; set; }

        public Disk(string name, string genre)
        {
            _name = name;
            _genre = genre;
            _birnCount = 0;
        }

        public virtual void Burn(params string[] values)
        {

        }

        public void DiscountPrice(int percent)
        {
            Price -= Price * percent / 100;
        }

        public override string ToString()
        {
            return $"Название : {_name}, жанр: {_genre}";
        }
    }
}
