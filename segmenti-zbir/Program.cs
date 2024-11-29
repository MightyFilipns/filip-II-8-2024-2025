namespace segmenti_zbir;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int trazeno = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        int segments = 0;
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < n; i++)
        {
            int zbir = 0;
            for (int j = n; j < n; j++)
            {
                zbir += list[j];
            }

            if (zbir == trazeno)
            {
                segments++;
            }
        }
        Console.WriteLine(segments);
    }
}