namespace Route_adv03;
internal class Program
{
    static void Main(string[] args)
    {
        #region 1st ex
        List<int> grades = [85,92,78,95,88,70,100,65];
        Console.WriteLine($"students grades:  {string.Join(", " ,grades)}");
        Console.WriteLine($"grades count is:{grades.Count}");
        Console.WriteLine($"first grade is: {grades.First()}");
        Console.WriteLine($"last grade is: {grades.Last()}");
        grades.Sort();
        Console.WriteLine($"sorted students grades:  {string.Join(", ", grades)}");
        Console.WriteLine($"first grade above 90 is :{grades.First(g => g > 90)}");
        Console.WriteLine($"all grades below 75 :[{string.Join(", ",grades.Where(g=>g<75))}]");
        grades.RemoveAll(g => g < 75);
        Console.WriteLine(grades.Contains(100));
        List<string> strGrades = new List<string>();
        foreach(int g in  grades)
        {
            strGrades.Add($"Grade:{g}");
        }
        strGrades.ForEach(g => Console.WriteLine(g));
        #endregion
        Console.WriteLine("==========================================");

        #region 2nd 
        SortedDictionary<int,string> players = new SortedDictionary<int,string>();
        players.Add(500,"Ahmad");
        players.Add(200,"Sara");
        players.Add(800,"Ali");
        players.Add(350,"Mona");

        foreach(var p in players)
        {
            Console.WriteLine($"score:{p.Key} | player:{p.Value}");
        }

        var firstPlayer = players.First();
        Console.WriteLine($"first key:{firstPlayer.Key}");
        Console.WriteLine($"first value:{firstPlayer.Value}");

        Console.WriteLine(players.ContainsKey(500));

        bool find999= players.TryGetValue(999, out var player);
        if (find999)
            Console.WriteLine($"player with score 999 is:{player}");
        players.Remove(200);
        foreach (var p in players)
        {
            Console.WriteLine($"score:{p.Key} | player:{p.Value}");
        }
        #endregion
    }
}
