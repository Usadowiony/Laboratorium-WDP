namespace Laboratorium5{
    internal class Program{
        static void Main(string[] arg)
        {
           Console.WriteLine(QuadraticEquation());
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
    }
}
