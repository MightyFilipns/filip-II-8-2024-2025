namespace anagram;

class Program
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine().Replace(" ","").ToLower();
        string str2 = Console.ReadLine().Replace(" ","").ToLower();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var c in str1)
        {
            if (!dict.TryAdd(c, 1))
            {
                dict[c]++;
            }
        }
        foreach (var c in str2)
        {
            if (!dict.ContainsKey(c))
            {
                Console.WriteLine("No");
                return;
            }
            
            dict[c]--;
            
            if (dict[c] < 0)
            {
                Console.WriteLine("No");
                return;
            }
        }
        Console.WriteLine("Da");
    }
}