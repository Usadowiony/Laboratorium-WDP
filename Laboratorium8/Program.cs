using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        /*StringCreation();
        StringIteration();
        StringShiftByContatenation();
        StringShiftByStringBuilder();
        StringInstanceMethods();
        StringStaticMethods();
        DateTimeDemo();*/
        //Console.WriteLine(Zadanie2("abbbcddddefggggaaaaauijjj"));
        Console.WriteLine(Zadanie2("deemoooo"));
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
        string[] tokens = email.Split("@");
        Console.WriteLine(tokens[0]);
        Console.WriteLine(tokens[1]);
        string input = "line 1\n line 2\n line 3";
        string[] lines = input.Split("\n ");
        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
        Console.WriteLine(lines[2]);
    }

    public static void StringStaticMethods()
    {
        string[] names = { "adam", "ewa", "karol"};
        Console.WriteLine(string.Concat(names));
        Console.WriteLine(string.Join(", ", names));
        string a1 = "abcd";
        string a2 = "ab";
        Console.WriteLine(string.Compare(a1, a2));
    }

    public static void DateTimeDemo()
    {
        DateTime now = DateTime.Now;
        DateTime past = new DateTime(2010, 02, 28);
        DateTime parsedDate = DateTime.Parse("2000-10-20");
        DateTime birth = new DateTime(2010-02-28);
        Console.WriteLine(now);
        Console.WriteLine(past);
        Console.WriteLine(parsedDate);
        /*string input = Console.ReadLine();
        if (DateTime.TryParse(input, out var inputDate)) {
            Console.WriteLine($"Poprawnie wpisałeś datę: {inputDate}");
            Console.WriteLine($"Różnica lat od dzisiaj{ now.Year - inputDate.Year}");
            Console.WriteLine($"Data za 100 dni {now.AddDays(100)}");
            Console.WriteLine($"Okres pomiedzy datami {now - inputDate}");
            Console.WriteLine($"Czy now jest większe od inputDate: {now > inputDate}");
        }
        else
        {
            Console.WriteLine($"Błąd, źle wpisałeś datę!");
        }*/
    }
    public static string Zadanie2(string input){
        StringBuilder compressed = new StringBuilder();
        int countC = 1;

        for(int i = 0; i < input.Length - 1; i++){
            if(input[i] == input[i + 1]){
                    countC++;
                }else{
                    if(countC == 1){
                        compressed.Append(input[i]);
                    }else{
                        compressed.Append(countC.ToString());
                        compressed.Append(input[i-1]);
                        countC = 1;
                    }
            }
            if (i == input.Length - 2)
            {
                if (countC == 1)
                {
                    compressed.Append(input[i + 1]);
                }
                else
                {
                    compressed.Append(countC.ToString());
                    compressed.Append(input[i + 1]);
                }
            }
        }
        return compressed.ToString();
    }
}