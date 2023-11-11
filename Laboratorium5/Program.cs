namespace Laboratorium5{
    internal class Program{
        static void Main(string[] arg)
        {
            Console.WriteLine(CircleArea(2.2));
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
    }
}
