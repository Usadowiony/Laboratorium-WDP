﻿internal class Program
{
    class Book
    {
        public string Title { get; set; }
        public int PublishingYear { get; set; }

        public override bool Equals(object? obj)
        {
            Console.WriteLine("Equals");
            if (this == obj) return false;
            Book? other = obj as Book;
            if (other == null) return false;
            return Title == other.Title && PublishingYear == other.PublishingYear;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("HashCode");
            return HashCode.Combine(Title, PublishingYear);
        }
    }
    static void Main(string[] args)
    {
        //CollectionAndListDemo();
        //SetDemo();
        //DictionaryDemo();
        //CollectionAndListDemo();
        CollectionForCustomTypesDemo();
    }

    public static void CollectionForCustomTypesDemo()
    {
        List<Book> books = new List<Book>()
        {
            new Book() { Title = "ABC", PublishingYear = 2010},
            new Book() { Title = "CDE", PublishingYear = 2021}
        };
        bool find = books.Contains(new Book() { Title = "CDE", PublishingYear = 2021 });
        Console.WriteLine(find);
    }
    public static void DictionaryDemo()
    {
        IDictionary<string, int> wordCounters = new Dictionary<string, int>()
        {
            { "ale", 2 },
            { "i", 4 },
            { "kot", 1 }
        };

        int i = wordCounters["ale"];
        Console.WriteLine(i);
        wordCounters.Remove("kot");
        foreach (KeyValuePair<string, int> item in wordCounters)
        {
            Console.WriteLine($"słowo: {item.Key}, liczba wystąpień: {item.Value}");
        }
        if (wordCounters.ContainsKey("w"))
        {
            Console.WriteLine("Jest");
        }
        else
        {
            Console.WriteLine("Nie ma");
        }
        IDictionary<int, int> counters = new Dictionary<int, int>();
        int[] arr = {1, 2, 4, 2, 5, 6, 7, 2, 5};
        ISet<int> numbers = new HashSet<int>(arr);
        foreach(int number in numbers)
        {
            counters.Add(number, 0);
        }
        foreach (var counter in counters)
        {
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == counter.Key)
                {
                    counters[counter.Key] = counters[counter.Key] +1;
                }
            }
        }
        foreach (var counter in counters)
        {
            Console.WriteLine($"Dana liczba {counter.Key} występuje {counter.Value}");
        }
    }
    public static void SetDemo()
    {
        ISet<int> ints = new HashSet<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(3);
        ints.Add(1);
        Console.WriteLine(string.Join(", ", ints));
        int[] numbers = { 1, 3, 6, 32, 2, 6, 5, 1, 4, 5, 6, 1, 4, 5, 5 };
        ISet<int> uniqeNumbers = new HashSet<int>(numbers);
        Console.WriteLine(string.Join(", ", uniqeNumbers));
        List<string> cards = new List<string>() { "A2", "B2", "R3", "A2", "B1", "B2"};
        var uniqeCards = new HashSet<string>(cards);
        Console.WriteLine(string.Join(", ", uniqeCards));
        Console.WriteLine(uniqeNumbers.Contains(5));
        uniqeNumbers.UnionWith(new int[] { 1111, 2222});
        Console.WriteLine(string.Join(", ", uniqeNumbers));
        uniqeNumbers.ExceptWith(new int[] { 32, 5 });
        Console.WriteLine(string.Join(", ", uniqeNumbers));
        foreach(string card in cards)
        {
            Console.WriteLine(card);
        }
    }
    private static void CollectionAndListDemo()
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
        List<string> processed = new List<string>() { "explorer.exe", "notepad.exe", "cmd.exe" };
        processed.AddRange(new string[] { "calculator.exe", "word.exe" });
        processed.RemoveRange(1, 2);
        processed.InsertRange(0, new List<string>() { "visualstudio.exe", "packman.exe" });
        Console.WriteLine("===Lista processed===");
        Console.WriteLine(string.Join(", ", processed));
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
