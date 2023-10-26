namespace Laboratorium4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie4();
        }
        static void Zadanie1(){
            double[] factors = { 2.4, 1.9, -0.5};
            double x = 2.3;
            if(factors.Length < 3){
                Console.WriteLine("Nie można obliczyć równania, nie ma wszystkich współczynników.");
            }else{
                Console.WriteLine($"Wynik równania kwadratowego wynosi: {(factors[0]*x*x) + (factors[1]*x) + factors[2]}");
            }
        }
        static void Zadanie2(){
            double[] arr = { 12.5, 6.7, 2.89, 10.1, 2.45 };
            for(int i = arr.Length - 1; i >= 0; i--){
                Console.WriteLine(arr[i]);
            }
        }
        static void Zadanie3(){
            double x = 0;
            Console.WriteLine("Podaj dowolną liczbę całkowitą: ");
            while(int.TryParse(Console.ReadLine(), out int value)){
                Console.WriteLine("Następna liczba całkowita: ");
                x += value;
            }
            Console.WriteLine($"Nie wpisałeś liczby całkowitej, zatem wynik dodawania wynosi: {x}");
        }
        static void Zadanie4(){
            double[,] arr = { { 1.1, 3.5, 2.56 }, { 1.4, 34, 7, }, { 1.5, 56, 2.6 } };
            double b = 4.1;
            for(int i = 0; i < arr.GetLength(0); i++){
                for(int k = 0; k < arr.GetLength(1); k++){
                    if(arr[i,k] > b){
                    Console.WriteLine(arr[i,k]);
                }
                }
            }
        }
    }
}