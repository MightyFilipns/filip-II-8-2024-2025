namespace pokretni_prozor;

class Program
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        str2.ToCharArray().ToList().ForEach(x =>
        {
            if(!dict.TryAdd(x, 0))
                dict[x]++;
        });
        int cnt = 0;
        Dictionary<char, int> dict2 = new Dictionary<char, int>(dict);
        foreach (var t in str1)
        {
            if (dict.ContainsKey(t) && dict2[t] > 0)
            {
                dict[t]--;
                if (dict.All(a => a.Value == 0))
                {
                    cnt++;
                }
            }
            else
            {
                dict = new(dict2);
            }
        }
        Console.WriteLine(cnt);
    }
}