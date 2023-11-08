namespace Laboratorium5{
    internal class Program{
        static void Main(string[] arg)
        {
            double input;

            Console.WriteLine("Wpisz liczbę");
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Spróbuj wpisać jeszcze raz liczbę np. 12,56");
            }
            Console.WriteLine(input * input);
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
        static void Swap(ref int a , ref int b){
            int temp = a;
            a = b;
            b = temp;
        }
        static void RefFunctionExample(){
            int x = 5;
            int y = 16;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y =  {y}");
        }
        static void FillArray(int[] arr, int value){
            for(int i = 0; i < arr.Length; i++){
                arr[i] = value;
            }
        }
        static void RefArayExample(){
            int[] ints = { 1, 2, 5, 6 };
            FillArray(ints, 2);
            Console.WriteLine(ints[0] + " " + ints[1]);
        }
        static bool FindValue2(int[] arr, int value, out int index){
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false;
        }
        static void OutParameterExample(){
            int index;
            int[] ints = { 1, 5, 6, 3 };
            if (FindValue2(ints, 7, out index))
            {
                Console.WriteLine($"Znaleziono wartośc pod indeksem {index}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono wartości");
            }
        }
    }
}
