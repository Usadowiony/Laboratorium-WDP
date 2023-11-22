﻿namespace Laboratorium6
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
            car.Drive(15);
            car.Drive(25);
            Console.WriteLine(car.GetMileage());
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
        public Car(int power, int volume, double fuelTankCapasity){
            Power = power;
            Volume = volume;
            _mileage = 0;
            FuelTankCapacity = fuelTankCapasity;
        }
        public Car(){
            Power = 50;
            Volume = 500;
        }
        public void Drive(int distance){
            double fuel = distance / 100 * FuelConsumption;
            _mileage += distance;

        }
    }
}