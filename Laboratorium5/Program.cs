namespace Laboratorium5{
    internal class Program{
        static void Main(string[] arg)
        {
            FunctionExample();
        }
        static void Print(double x)
        {
            Console.WriteLine(x);
        }
        static void Example(){
            Print(5.5);
            double x = 2.5;
            Print(x * 2);
        }
        static double Add(double x, double y){
            return x + y;
        }
        static void FunctionExample(){
            Console.WriteLine(PowerMinusOne(4));
        }
        static double PowerMinusOne(double x){
            return (x * x) - 1;
        }
    }
}
