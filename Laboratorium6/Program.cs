namespace Laboratorium6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car3 = new Car{
                Power = 200,
                Volume = 2000,
                FuelConsumption = 7.5,
                FuelTankCapacity = 60,
            };
            car3.Drive(15);
            car3.Drive(25);
            car3.Refuel();
            car3.Drive(120);
            car3.Drive(200);
            Console.WriteLine($"Car Mileage: {car3.GetMileage}");
            Console.WriteLine($"Car FuelLevel: {car3.GetFuelLevel}");
            Console.WriteLine($"Car CanDrive: {car3.Distance}");

            Rectangle square = Rectangle.Squere(10);
        }
    }

    class Rectangle{
        public int Width{get; set;}
        public int Height{get; set;}
        public static Rectangle Squere(int size){
            return new Rectangle()
            {
                Height = size,
                Width = size,
            };
        }
    }

    class Car {
        public readonly static int MaxPower = 1000;
        private int _power;
        public int Power{
            get{
                return _power;
            }
            set{
                if (_power > 0){
                    _power = value;
                }
            }
        }

        private int _volume;
        public int Volume{
            get{
                return _volume;
            }
            set{
                if( _volume > 0 && _volume < MaxPower){
                    _volume = value;
                }
            }
        }
        public int Distance{
            get{
                return (int) (100 * _fuelLevel / FuelConsumption);
            }
            set{
                
            }
        }
        private double _mileage;
        private double _fuelLevel;
        public double FuelTankCapacity {get; init;}
        public double FuelConsumption {get; init;}
        public void Refuel(){
            _fuelLevel = FuelTankCapacity;
        }
        public double GetMileage{
            get{
                return _mileage;
            }
            set{
                if ( _mileage > 0){
                    _mileage = value;
                }
            }
        }
        public double GetFuelLevel{
            get{
                return _fuelLevel;
            }
            set{
                if (_fuelLevel > 0){
                    _fuelLevel= value;
                }
            }
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