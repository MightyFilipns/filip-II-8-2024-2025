namespace competition;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        while (true)
        {
            var a = GetNum();
            if (!a.Item2)
            {
                break;
            }
            numbers.Add(a.Item1);
        }
        Console.WriteLine($"Number of participants: {numbers.Count}");
        Console.WriteLine($"Average score: {numbers.Average()}");
        Console.WriteLine($"Lowest score: {numbers.Min()}");
        Console.WriteLine($"Highest score: {numbers.Max()}");
    }
    private static (int,bool) GetNum()
    {
        Console.Write("Enter Integer:");
        int a = 0;
        try
        {
            a = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            return (0,false);
        }
        return (a, true);
    }
}