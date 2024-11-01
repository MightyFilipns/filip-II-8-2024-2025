namespace suglasnik_ili_samoglasnik;

class Program
{
    static readonly char[] vowels = ['a','e','i','o','u','A','E','I','O','U'];
    static void Main(string[] args)
    {
        string read = Console.ReadLine();
        foreach (var c in read)
        {
            if (vowels.Contains(c))
            {
                Console.WriteLine($"samoglasnik {c}");
            }
            else
            {
                Console.WriteLine($"suglasnik {c}");
            }
        }
    }
}