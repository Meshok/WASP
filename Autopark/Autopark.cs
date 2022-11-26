using System;
using System.Collections.Generic;

namespace WASP_PR_2
{
    class Autopark
    {
        public string Name { get; set; }

        public List<Car> Cars { get; set; }

        public Autopark(string name, List<Car> cars)
        {
            Name = name;
            Cars = cars;
        }

        public Autopark() : this(null, null)
        {

        }

        public override string ToString()
        {
            string info = $"Название автопарка: {Name}";
            foreach (Car car in Cars)
            {
                info += "\n" + car.ToString();
            }
            return info;
        }
    }
}
