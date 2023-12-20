internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> evens = Evens();
        foreach (int number in evens) { 
            Console.WriteLine(number * number);
        }
        for (IEnumerator<int> enumerator = evens.GetEnumerator(); enumerator.MoveNext();)
        {
            int number = enumerator.Current;
            Console.WriteLine(number);
        }
    }
    public static IEnumerable<int> Evens()
    {
        int[] result = { 2, 4, 6, 8 };
        return result;
    }
    
    public static IEnumerable<string> Names()
    {
        string[] result = { "Adam", "Ewa", "Karol" };
        return result;
    }
    public static IEnumerable<int> EvensGenerator(int start, int end)
    {
        for (int i = start; i < end; i++) ;
    }
}
