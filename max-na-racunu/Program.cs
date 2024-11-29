namespace max_na_racunu;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        int max = 0;
        int racun = 0;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            max = Math.Max(racun, x);
            racun += x;
            list.Add(x);
        }
        Console.WriteLine(max);
    }
}