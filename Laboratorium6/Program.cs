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

        }
    }

    class Car {
        public int Power;
        public int Volume;
    }
}