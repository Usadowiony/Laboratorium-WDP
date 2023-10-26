static void Zadanie1(){
    double[] factors = { 2.4, 1.9, -0.5};
    double x = 2.3;
    if(factors.Length < 3){
        Console.WriteLine("Nie można obliczyć równania, nie ma wszystkich współczynników.");
    }else{
        Console.WriteLine($"Wynik równania kwadratowego wynosi: {(factors[0]*x*x) + (factors[1]*x) + factors[2]}");
    }
}
Zadanie1();