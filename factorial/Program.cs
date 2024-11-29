namespace factorial;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        ulong fact = 1;
        for (int i = 0; i < n; i++)
        {
            fact *= (ulong)i;
            Console.WriteLine(fact);
        }
    }
}