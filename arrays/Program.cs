namespace arrays;

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

        numbers.Reverse();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
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