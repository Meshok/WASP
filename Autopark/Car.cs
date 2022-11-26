
namespace WASP_PR_2
{
    class Car
    {
        public string Brand { get; set; }
        public double? Power { get; set; }
        public int? YearOfProduction { get; set; }

        public Car(string brand, double? power, int? year)
        {
            Brand = brand;
            Power = power;
            YearOfProduction = year;
        }

        public Car() : this(null, null, null) { }

        public override string ToString()
        {
            return $"Марка машины: {Brand}, мощность: {Power}, год производства: {YearOfProduction}";
        }
    }
}
