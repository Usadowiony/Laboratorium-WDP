namespace Laboratorium_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Zadanie4();
            Zadanie5();
            Zadanie6();
        }
        public static void Zadanie1() {
            Console.WriteLine("==== Zadanie 1 ====");
            int number = 146;
            int cyfraSetek;
            int cyfraJedności;
            int cyfraDziesiątek;

            cyfraSetek = number / 100;
            cyfraDziesiątek = (number % 100) / 10;
            cyfraJedności = number % 10;

            Console.WriteLine(cyfraSetek);
            Console.WriteLine(cyfraDziesiątek);
            Console.WriteLine(cyfraJedności);
        }
        public static void Zadanie2()
        {
            Console.WriteLine("\n==== Zadanie 2 ====");
            double degree = 45;
            double sinValue;

            sinValue = Math.Sin(degree);
            Console.WriteLine(sinValue);

        }
        public static void Zadanie3()
        {
            Console.WriteLine("\n==== Zadanie 3 ====");
            double area = 189;
            double radius;

            radius = Math.Sqrt(area / Math.PI);
            Console.WriteLine(radius);
        }
        public static void Zadanie4()
        {
            Console.WriteLine("\n==== Zadanie 4 ====");
            double x = 0.45;
            double a = 1.5;
            double b = 3.2;
            double c = 4;
            double y;

            y = a * (x*x) + b * x + c;
            Console.WriteLine(y);
        }
        public static void Zadanie5()
        {
            Console.WriteLine("\n==== Zadanie 5 ====");
            int a = 9;
            int b = 6;
            int c = 2;
            int max;
            int min;
            max = Math.Max(Math.Max(a, b), c);
            min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine("=======");
            int d = 12;
            int e = 11;
            int f = 29;
            max = Math.Max(Math.Max(d, e), f);
            min = Math.Min(Math.Min(d, e), f);
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }
        public static void Zadanie6()
        {
            Console.WriteLine("\n==== Zadanie 6 ====");
            double time = 1234.45; // czas w minutach
            int hours;
            int minutes;
            int seconds;

            hours = (int)time / 60;
            minutes = (int)time % 60;
            seconds = (int)((time % 1) * 60);
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
// Wojciech Pietrzak