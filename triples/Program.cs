namespace triples;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < 9; i++)
        {
            for (int j = 1; j < 9; j++)
            {
                var v = Math.Sqrt(i*i + j*j);
                if (v < 17)
                {
                    Console.WriteLine($"{i} + {j} = {v}");
                }
            }
        }
    }
}