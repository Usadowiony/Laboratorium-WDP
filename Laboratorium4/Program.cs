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
static void ForStatement(){
    double[] factors = { 3, 5, 4, 6.7 };
    for(int i = 0; i < factors.Length; i++){
        factors[i] = 2;
        Console.Write($"{factors[i]} ");
    }
}
ForStatement();