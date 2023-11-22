namespace Laboratorium6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car3 = new Car(200, 2000, 60, 7.5);
            car3.Drive(15);
            car3.Drive(25);
            Console.WriteLine(car3.GetMileage());
            car3.Refuel();
            car3.Drive(120);
            car3.Drive(200);
            Console.WriteLine($"Car Mileage: { car3.GetMileage()}");
            Console.WriteLine($"Car FuelLevel: {car3.GetFuelLevel()}");
        }
    }

    class Car {
        public int Power;
        public int Volume;
        private double _mileage;
        private double _fuelLevel;
        public readonly double FuelTankCapacity;
        public readonly double FuelConsumption;
        public void Refuel(){
            _fuelLevel = FuelTankCapacity;
        }
        public double GetMileage(){
            return _mileage;
        }
        public double GetFuelLevel()
        {
            return _fuelLevel;
        }
        public Car(int power, int volume, double fuelTankCapasity, double fuelConsumption){
            Power = power;
            Volume = volume;
            _mileage = 0;
            FuelTankCapacity = fuelTankCapasity;
            FuelConsumption = fuelConsumption;
        }
        public Car(){
            Power = 50;
            Volume = 500;
        }
        public void Drive(int distance){
            double fuel = distance / 100 * FuelConsumption;
            //Dodaj logike sprawdzającą czy mamy tyle paliwa i obliczenie ile rzeczywiście przejechał samochód
            _fuelLevel -= fuel;
            _mileage += distance;

        }
    }
}