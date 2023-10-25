/*int[] ints = { 1, 4, 6, 3, 7 };
Console.WriteLine(ints[0]);
char[] chars = { 'a', 'b', '&' };
Console.WriteLine(chars[1]);
Console.WriteLine(chars.Length);
if (chars.Length > 0){
    Console.WriteLine(chars[chars.Length -1 ]);
}*/
/*double[] factors = new double[5];
factors[0] = 5.5;
Console.WriteLine(factors);*/
/*static void Zadanie1()
{
    double[] factors = { 3, 5, -1.6,};
    double x = 2.4;
    double y;
    if (factors.Length < 3)
    {
        Console.WriteLine("Zbyt mało współlczynników");
    }
    else
    {
        y = factors[0] * x * x + factors[1] * x + factors[2];
        Console.WriteLine(y);
    }
}
Zadanie1();*/
/*static void ForStatement(){
    double[] factors = { 3, 5, 4, 6.7 };
    for (int i = 0; i < factors.Length; i++)
    {
        factors[i] = 2;
        Console.Write($"{factors[i]} ");
    }
    for (int i = factors.Length - 1; i >= 0; i--)
    {
        Console.Write($"{factors[i]} ");
    }
    for (int i = 11; i < 30; i += 2){
        Console.Write($"{i} ");
    }
}
ForStatement();*/
static void WhileStatement(){
    char znak = 'a';
    Console.WriteLine("q - wyjście");
    Console.WriteLine("a - wyświewtl komunikat");
    Console.WriteLine("b - oblicz kwadrat");
    while ((znak = Console.ReadKey().KeyChar) != 'q')
    {
        switch (znak)
        {
            case 'a':
                Console.WriteLine("Komunikat: Hello");
                break;
            case 'b':
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine($"{x} * {x} = {x*x}");
                break;
            default:
                Console.WriteLine("Nieznana opcja");
                break;
        }
        Console.WriteLine("q - wyjście");
        Console.WriteLine("a - wyświewtl komunikat");
    }
}
WhileStatement();