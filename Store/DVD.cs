using System;
using System.Collections.Generic;
using System.Text;

namespace WASP_PR_3
{
    class DVD : Disk
    {
        private string _producer;
        private string _filmCompany;
        private int _minutesCount;

        public override int DiskSize => (_minutesCount / 64) * 2;

        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
        {
            _producer = producer;
            _filmCompany = filmCompany;
            _minutesCount = minutesCount;
        }

        public override void Burn(params string[] values)
        {
            _producer = values[0];
            _filmCompany = values[1];
            _minutesCount = Convert.ToInt32(values[2]);
            _birnCount++;
        }

        public override string ToString()
        {
            return
                base.ToString() +
                $", режиссер: {_producer}, кинокомпания: {_filmCompany}" +
                $", количество минут: {_minutesCount}, количество прожигов: {_birnCount}";
        }
    }
}
