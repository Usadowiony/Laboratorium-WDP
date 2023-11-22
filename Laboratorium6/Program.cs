namespace Laboratorium6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            car.Power = 100;
            car2.Power = 200;
            Console.WriteLine(car.Power);
            Console.WriteLine(car2.Power);
            Car car3 = new Car(200, 2000);
        }
    }

    class Car {
        public int Power;
        public int Volume;
        private double _mileage;
        public Car(int power, int volume){
            Power = power;
            Volume = volume;
            _mileage = 0;
        }
        public Car(){
            Power = 50;
            Volume = 500;
        }
    }
}