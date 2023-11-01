namespace Laboratorium4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie7();
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
        static void Zadanie5(){
            int n;
            Console.Write("Wprowadź liczbę całkowitą n: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0){
                Console.Write("Błąd! Jeszcze raz: ");
            }
            for(int i = 0; i < n - 1; i++){
                Console.Write("|");
                for(int k = 0; k < i; k++){
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            Console.Write("|");
            for(int i = 0; i < n - 1; i++){
                Console.Write("_");
            }
            Console.Write("\\");
        }
        static void Zadanie6(){
            int n;
            Console.WriteLine("Podaj liczbę całkowitą n: ");
            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0){
                Console.WriteLine("Błąd! Podaj poprawną liczbe: ");
            }
            double[] values = new double[n];
            for(int i = 0; i < n; i++){
                Console.Write($"Podaj {i+1}/{n} liczbe typu double: ");
                values[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            for(int k = n - 1; k >= 0; k -= 2){
                Console.Write($"{values[k]} ");
            }
        }
        static void Zadanie7(){
            int n;
            int m;
            Console.Write("Podaj liczbę całkowitą n: ");
            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Błąd! Podaj poprawną liczbe: ");
                Console.ResetColor();
            }
            Console.Write("Podaj liczbę całkowitą m: ");
            while(!int.TryParse(Console.ReadLine(), out m) || m <= 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Błąd! Podaj poprawną liczbe: ");
                Console.ResetColor();
            }
            char[,] rectangle = new char[n,m];
        }
    }
}