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
Zadanie1();
Console.WriteLine("========");
Zadanie2();