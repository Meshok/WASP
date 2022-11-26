using System;
using System.Collections.Generic;

namespace WASP_PR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Opel", 7.99, 1985);
            PassengerCar pcar = new PassengerCar("Scoda",
                                                 9.99,
                                                 1999,
                                                 4,
                                                 new Dictionary<string, int>());
            pcar.AddReplacedPart("Двигатель", 2002);
            Truck truck = new Truck("Man",
                                    19.97,
                                    1997,
                                    2000,
                                    "Ерофеев Пётр",
                                    new Dictionary<string, int>());
            truck.AddCargo("Кока-Кола", 200);
            Autopark park = new Autopark("Автопарк Сказка",
                                         new List<Car> { car, pcar, truck });
            Console.WriteLine(park);
        }
    }
}
