namespace Laboratorium7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Zdefiniuj klasę Point z właściwościami X, Y typu int oraz metodami instancyjnymi:
            - Move, która przesuwa obie współrzędne punktu o argument
            - Quadrant, która zwraca numer ćwiartki układu współrzędnych (od 1 do 4), w którym znajduje się punkt. Jeśli punkt jest na osi X lub Y metoda zwraca 0.
            - MirrorY, która zwraca nowy punkt, który jest odbiciem lustrzany punktu względem osi Y
            - MirrorX, która zwraca nowy punkt, który jest odbiciem lustrzany punktu względem osi X 
            */
        }
    }
public class Point{
    public int X{get; set;}
    public int Y{get; set;}

    public void Move(int val){
        X += val;
        Y += val;
    }
    public int Quadrant(){
        if(X > 0 && Y > 0){
            return 1;
        }else if(X < 0 && Y > 0){
            return 2;
        }else if(X < 0 && Y < 0){
            return 3;
        }
        else if(X > 0 && Y < 0){
            return 4;
        }else{
            return 0;
        }
    }
    public Point MirrorX(){
        return new Point {X = -X, Y = Y};
    }
    public Point MirrorY(){
        return new Point {X = X, Y = -Y};
    }
}
public class Audio{
    public int Volume { get; private set; }
    public static readonly int MinVolume = 0;
    public static readonly int MaxVolume = 100;
    
    public Audio(){
        Volume = MinVolume;
    }

        public void VolumeUp(){
            if(Volume < MaxVolume){
                Volume++;
            }
        }
        public void VolumeDown(){
            if(Volume > MinVolume){
                Volume--;
            }
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