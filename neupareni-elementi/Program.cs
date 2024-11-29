namespace neupareni_elementi;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        list.Sort();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        
        for (int i = 0; i < n; i++)
        {
            dict[i]++;
        }

        Console.WriteLine(dict.First(a => a.Value == 1).Key);
    }
}