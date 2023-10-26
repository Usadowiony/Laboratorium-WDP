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
Zadanie1();
Console.WriteLine("========");
Zadanie2();
Console.WriteLine("========");
Zadanie3();