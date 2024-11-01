namespace uneven_count;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        int total = 0;
        for (int i = 0; i < n; i++)
        {
           int v = int.Parse(Console.ReadLine());
           if (v % 2 == 1)
           {
               total += v;
           }
        }
        Console.WriteLine(total);
    }
}