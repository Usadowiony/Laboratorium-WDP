namespace Laboratorium5{
    internal class Program{
        static void Main(string[] arg)
        {
           Zadanie4();
        }
        //Zadnie 1
        public static void Print(double a){
            Console.WriteLine($"Wartość argumentu jest równa = {a}");
        }
        //Zadanie 2
        public static double CircleArea(double r){
            if(r <= 0){
                return double.NaN;
            }
            double area = Math.PI * (r * r);
            return area;
        }
        //Zadanie 3
        public static double QuadraticEquation(double x = 1.0, double a = 1.0, double b = 1.0, double c = 1.0){
            return a*(x*x) + b*x + c;
        }
        ///Zadanie 4
        public static void Zadanie4(){
            double x;
            Console.Write("Podaj w formacie double liczbe x: ");
            while(double.TryParse(Console.ReadLine(), out x)){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Niepoprawny format! Wpisz jeszcze raz: ");
                Console.ResetColor();
            }
            double a;
            Console.Write("Podaj w formacie double liczbe a: ");
            while(double.TryParse(Console.ReadLine(), out a)){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Niepoprawny format! Wpisz jeszcze raz: ");
                Console.ResetColor();
            }
            double b;
            Console.Write("Podaj w formacie double liczbe b: ");
            while(double.TryParse(Console.ReadLine(), out b)){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Niepoprawny format! Wpisz jeszcze raz: ");
                Console.ResetColor();
            }
            double c;
            Console.Write("Podaj w formacie double liczbe c: ");
            while(double.TryParse(Console.ReadLine(), out c)){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Niepoprawny format! Wpisz jeszcze raz: ");
                Console.ResetColor();
            }
        }
    }
}
