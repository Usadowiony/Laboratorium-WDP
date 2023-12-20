internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> evens = Evens();
        foreach (int number in evens)
        {
            Console.WriteLine(number * number);
        }

        for (IEnumerator<int> enumerator = evens.GetEnumerator(); enumerator.MoveNext();)
        {
            int number = enumerator.Current;
            Console.WriteLine(number);
        }

        foreach (int number in EvensGenerator(1, 7))
        {
            Console.WriteLine(number * number);
        }
        foreach (string name in NamesGenerator())
        {
            Console.WriteLine(name);
        }

        ICollection<string> names = NamesCollection();
        if (names.Contains("Beata"))
        {
            Console.WriteLine("Jest");
        }
        else
        {
            Console.WriteLine("Brak");
        }
        names.Add("Robert");
        names.Remove("Adam");
        Console.WriteLine("==========");
        Console.WriteLine(names.Count);
        foreach (string name in names)
        {
            Console.WriteLine(name.ToUpper());
        }
        var collection = NamesCollection();
        RemoveWithA(collection);
        Console.WriteLine("===Usuwanie z kolekcji===");
        Console.WriteLine(string.Join(", ", names));
        IList<string> listNames = NameList();
        Console.WriteLine(listNames[0]);
        listNames[0] = "Alicja";
        listNames.Insert(2, "Tomek");
        int index = listNames.IndexOf("Ewa");
        Console.WriteLine(string.Join(", ", listNames));
        if (index > -1)
        {
            if (index + 1 < listNames.Count())
            {
                listNames.RemoveAt(index + 1);
            }
        }
        Console.WriteLine("===Usunięcie imienia za Ewa ===");
        Console.WriteLine(string.Join(", ", listNames));
    }

    public static IList<string> NameList()
    {
        return new List<string>(NamesCollection());
    }
       static void RemoveWithA(ICollection<string> collection)
        {
            List<string> removed = new List<string>(collection);
            foreach(string name in collection)
            {
                if (name.StartsWith("A"))
                {
                    removed.Add(name);
                }
            }
            foreach(string name in removed) { 
                collection.Remove(name);
            }
        }

    static ICollection<string> NamesCollection()
    {
        List<string> names = new List<string>(){
            "Adam",
            "Ewa",
            "Karol",
            "Beata",
        };
        return names;
    }

    public static IEnumerable<int> Evens()
    {
        int[] result = { 2, 4, 6, 8 };
        return result;
    }

    public static IEnumerable<string> NamesGenerator()
    {
        yield return "Adam";
        yield return "Ewa";
        yield return "Karol";
    }
    public static IEnumerable<int> EvensGenerator(int start, int end)
    {
        for (int i = start + start % 2; i <= end; i += 2)
        {
            yield return i;
        }
    }
}
