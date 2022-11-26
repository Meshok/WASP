using System;
using System.Collections.Generic;

namespace WASP_PR_2
{
    class PassengerCar : Car
    {
        public int? PassengersAmount { get; set; }
        public Dictionary<string, int> RepairBook { get; set; }

        public PassengerCar(string brand, double? power, int? year, int? amount, Dictionary<string, int> book) : base(brand, power, year)
        {
            PassengersAmount = amount;
            RepairBook = book;
        }

        public PassengerCar() : this(null, null, null, null, null)
        {

        }

        public void AddReplacedPart(string part, int year)
        {
            if (part != null)
            {
                RepairBook.Add(part, year);
            }
        }

        public int? GetReplaceYear(string part)
        {
            return RepairBook?[part];
        }

        public void PrintRepairBook()
        {
            foreach (KeyValuePair<string, int> record in RepairBook)
            {
                Console.WriteLine(record.Key + " - " + record.Value + " year");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", количество пассажиров: {PassengersAmount}";
        }
    }
}
