using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        /*StringCreation();
        StringIteration();
        StringShiftByContatenation();
        StringShiftByStringBuilder();*/
        StringInstanceMethods();
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
        Console.WriteLine(Message);
        Console.WriteLine(MessageInterpolated);
        Console.WriteLine(MessageRaw);
        Console.WriteLine(MessageFromChars);
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

    public static void StringShiftByContatenation()
    {
        string source = "abcd";
        string target = "";
        for(int i=0; i < source.Length; i++)
        {
            int c = source[i];
            c += 3;
            target += (char) c; //konkatenacja, powoduje utworzenie nowego łańcucha i przypisanie go do target
        }
        Console.WriteLine(target);
    }

    public static void StringShiftByStringBuilder()
    {
        string source = "abcd";
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < source.Length; i++)
        {
            int c = source[i];
            c += 3;
            sb.Append((char) c);
        }
        Console.WriteLine(sb.ToString());
    }

    public static void StringInstanceMethods()
    {
        string msg = "abcdął0ć12343%^&*ą";
        Console.WriteLine(msg.ToUpper());
        Console.WriteLine(msg.ToLower());
        Console.WriteLine(msg.Replace("12", "89"));
        Console.WriteLine("abcdd  ty   lkj".Replace(" ", ""));
        Console.WriteLine("abcdd  ty   lkj     \n".Trim());
        Console.WriteLine(msg.IndexOf('ą'));
        Console.WriteLine(msg.LastIndexOf('ą'));
        Console.WriteLine(msg.Substring(6, 5));

        string email = "adam@wsei.edu.pl";
        string domain = email.Substring(email.IndexOf("@") + 1);
        Console.WriteLine(domain);
    }
}