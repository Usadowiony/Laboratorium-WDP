namespace Laboratorium5{
    internal class Program{
        static void Main(string[] arg)
        {
            Example();
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
    }
}
