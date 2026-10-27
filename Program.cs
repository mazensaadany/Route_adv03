namespace Route_adv03;
internal class Program
{
    static void Main(string[] args)
    {
        #region 1st ex
        List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
        Console.WriteLine($"students grades:  {string.Join(", ", grades)}");
        Console.WriteLine($"grades count is:{grades.Count}");
        Console.WriteLine($"first grade is: {grades.First()}");
        Console.WriteLine($"last grade is: {grades.Last()}");
        grades.Sort();
        Console.WriteLine($"sorted students grades:  {string.Join(", ", grades)}");
        Console.WriteLine($"first grade above 90 is :{grades.First(g => g > 90)}");
        Console.WriteLine($"all grades below 75 :[{string.Join(", ", grades.Where(g => g < 75))}]");
        grades.RemoveAll(g => g < 75);
        Console.WriteLine(grades.Contains(100));
        List<string> strGrades = new List<string>();
        foreach (int g in grades)
        {
            strGrades.Add($"Grade:{g}");
        }
        strGrades.ForEach(g => Console.WriteLine(g));
        #endregion
        Console.WriteLine("==========================================");

        #region 2nd ex
        SortedDictionary<int, string> players = new SortedDictionary<int, string>();
        players.Add(500, "Ahmad");
        players.Add(200, "Sara");
        players.Add(800, "Ali");
        players.Add(350, "Mona");

        foreach (var p in players)
        {
            Console.WriteLine($"score:{p.Key} | player:{p.Value}");
        }

        var firstPlayer = players.First();
        Console.WriteLine($"first key:{firstPlayer.Key}");
        Console.WriteLine($"first value:{firstPlayer.Value}");

        Console.WriteLine(players.ContainsKey(500));

        bool find999 = players.TryGetValue(999, out var player);
        if (find999)
            Console.WriteLine($"player with score 999 is:{player}");
        players.Remove(200);
        foreach (var p in players)
        {
            Console.WriteLine($"score:{p.Key} | player:{p.Value}");
        }
        #endregion
        Console.WriteLine("==========================================");

        #region 3rd ex
        Dictionary<string, string> PhoneBook = new Dictionary<string, string>
    {
        { "Ahmed", "01011111111" },
        { "Sara", "01122222222" },
        { "Ali", "01233333333" },
        { "Mona", "01544444444" }
    };

        PhoneBook["mazen"] = "01117249908";

        try
        {
            PhoneBook.Add("Sara", "01122222222");
        }
        catch (Exception)
        {
            Console.WriteLine("this contact already exists");
        }

        bool adding = PhoneBook.TryAdd("Sara", "01122222222");
        Console.WriteLine(adding);

        Console.WriteLine(PhoneBook.ContainsKey("lara"));

        Console.WriteLine(PhoneBook.GetValueOrDefault("lara", "Not Found"));

        Console.WriteLine($"keys are : {string.Join(", ", PhoneBook.Keys)}");
        Console.WriteLine($"values are : {string.Join(", ", PhoneBook.Values)}");
        #endregion
        Console.WriteLine("==========================================");

        #region 4th ex
        HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        emails.Add("ahmed@test.com");
        emails.Add("ahmed@test.com");
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.com");

        
        Console.WriteLine($"number of emails is :{emails.Count()}");

        HashSet<int> A = new HashSet<int>{ 1, 2, 3, 4, 5 };
        HashSet<int> B = new HashSet<int>{4,5,6,7,8 };

        HashSet<int> unionSet = new HashSet<int>(A);
        unionSet.UnionWith(B);
        Console.WriteLine(string.Join(", ", unionSet));

        HashSet<int> intersectSet = new HashSet<int>(A);
        intersectSet.IntersectWith(B);
        Console.WriteLine(string.Join(", ", intersectSet));

        HashSet<int> exceptSet = new HashSet<int>(A);
        exceptSet.ExceptWith(B);
        Console.WriteLine(string.Join(", ", exceptSet));

        HashSet<int> C = new HashSet<int> { 1, 2, };
        bool isSubset = C.IsSubsetOf(A);
        Console.WriteLine(isSubset);
        #endregion
        Console.WriteLine("==========================================");

        #region 5th ex
        Queue<string> printer = new Queue<string>();

        printer.Enqueue("Report.pdf");
        printer.Enqueue("Invoice.pdf");
        printer.Enqueue("Letter.docx");
        printer.Enqueue("Resume.pdf");
        printer.Enqueue("Photo.jpg");

        Console.WriteLine($"queue contents : {string.Join(", ",printer)}");
        Console.WriteLine("--------------");

        Console.WriteLine(printer.Peek());
        Console.WriteLine("--------------");

        while (printer.Count > 0)
        {
            Console.WriteLine($"printing:[{printer.Dequeue()}]");
        }
        Console.WriteLine("--------------");

        bool tryDequeue = printer.TryDequeue(out string? doc);
        Console.WriteLine($"Success? {tryDequeue}");
        #endregion
    }
}
