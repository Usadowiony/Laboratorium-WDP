internal class Program
{
    private static void Main(string[] args)
    {
        StringCreation();
        StringIteration();
    }

    public static void StringCreation()
    {
        string Message = "abcd";
        string MessageInterpolated = $"Value of Message '{Message}'";
        string MessageRaw =
@"line 1
line2";
        char[] Chars = { 'a', 'b', 'c', 'd' };
        string MessageFromChars = new string(Chars);
    }

    public static void StringIteration()
    {
        string msg = "abcd";
        for(int i =0; i < msg.Length; i++)
        {
            char c = msg[i];
            int d = msg[i];
        }
        foreach(char c in msg)
        {
            Console.WriteLine(c);
        }
        foreach (int d in msg)
        {
            Console.WriteLine(d);
        }
    }
}