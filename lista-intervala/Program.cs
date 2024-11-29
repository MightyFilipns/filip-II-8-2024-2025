namespace lista_intervala;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<(int start,int end)> list = new List<(int start,int end)>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);
            list.Add((start,end));
        }
        list.Sort((a, b) => a.start.CompareTo(b.start));
        List<(int start, int end)> overlap = new List<(int start, int end)>();
        for (int i = 1; i < list.Count; i++)
        {
            var last = list[i - 1];
            var current = list[i];
            if (last.end > current.start && last.start < current.end)
            {
                Console.WriteLine($"{last.start} -> {last.end}");
            }
        }
        overlap = overlap.Distinct().ToList();
        Console.WriteLine(string.Join("\n", overlap));
    }
}