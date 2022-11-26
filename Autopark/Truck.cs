using System;
using System.Collections.Generic;

namespace WASP_PR_2
{
    class Truck : Car
    {
        public int? MaxCapacity { get; set; }

        public string DriverName { get; set; }

        public Dictionary<string, int> CurrentCargo { get; set; }

        public Truck(string brand, double? power, int? year, int? capacity, string driver, Dictionary<string, int> cargo) : base(brand, power, year)
        {
            MaxCapacity = capacity;
            DriverName = driver;
            CurrentCargo = cargo;
        }

        public Truck() : this(null, null, null, null, null, null)
        {

        }

        public void ChangeDriver(string newDriver)
        {
            DriverName = newDriver;
        }

        public void AddCargo(string name, int weight)
        {
            CurrentCargo ??= new Dictionary<string, int>();

            if (name != null)
            {
                CurrentCargo.Add(name, weight);
            }
        }

        public void DeleteCargo(string name)
        {
            CurrentCargo?.Remove(name);
        }

        public void PrintCurrentCargo()
        {
            foreach(KeyValuePair<string, int> cargo in CurrentCargo)
            {
                Console.WriteLine($"Груз: {cargo.Key}, вес: {cargo.Value}");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", максимальная грузоподъемность: {MaxCapacity}, имя водителя: {DriverName}";
        }
    }
}
