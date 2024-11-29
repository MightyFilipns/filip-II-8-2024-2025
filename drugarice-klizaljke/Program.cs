namespace drugarice_klizaljke;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double chance = 1;
        double current_fact = 1;
        for (int i = 1; i <= n; i++) // Krece od 1 zbog faktorijala
        {
            current_fact *= i;
            chance += Math.Pow(-1, i)/current_fact;
        }
        Console.WriteLine(chance);
    }
}