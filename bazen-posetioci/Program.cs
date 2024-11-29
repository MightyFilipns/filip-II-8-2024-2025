namespace bazen_posetioci;

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
        int time = 0;
        list.Sort((c, d) =>
        {
            return c.start.CompareTo(d.start);
        });
        List<(int start,int end)> currently = new List<(int start,int end)>();
        int max = 0;
        foreach (var valueTuple in list)
        {
            time = valueTuple.start;
            currently.Add(valueTuple);
            currently.RemoveAll(a => a.end <= time);
            max = Math.Max(max, currently.Count);
        }
        Console.WriteLine(max);
    }
}