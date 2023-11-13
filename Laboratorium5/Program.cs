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
            double[] values = new double[4];
            for(int i = 0; i < 4; i++){
                string letter = "";
                    switch (i){
                        case 0:
                            letter = "x";
                            break;
                        case 1:
                            letter = "a";
                            break;
                        case 2:
                            letter = "b";
                            break;
                        case 3:
                            letter = "c";
                            break;
                        }
                    Console.Write($"Podaj w formacie double liczbe {letter}: ");
                    while(!double.TryParse(Console.ReadLine(), out values[i])){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Niepoprawny format! Wpisz jeszcze raz: ");
                        Console.ResetColor();
                    }
                    Console.WriteLine($"Wartość dla {letter}: {values[i]}");
            }
        }
    }
}
