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
            double[] arr = { 3.5, 1.4, 3, 67, 12 };
            int index = FindValue(arr, 4);
            Console.WriteLine($"index = {index}");
        }
        static double PowerMinusOne(double x){
            return (x * x) - 1;
        }
        static int FindValue(double[] arr, double value){
            for(int i = 0; i < arr.Length; i++){
                if (arr[i] == value){
                    return i;
                }
            }
            return -1;
        }
    }
}
