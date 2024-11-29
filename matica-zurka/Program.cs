using System.Security.Cryptography.X509Certificates;

namespace matica_zurka;

class Program
{
    static void Main(string[] args)
    {
        string inp;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        while ((inp = Console.ReadLine()) != "")
        {
            int p = int.Parse(inp);
                
            if (dic.ContainsKey(p))
            {
                dic[p]++;
            }
            else
            {
                dic.Add(p, 1);
            }
        }

        var b= dic.First(a => a.Value == 1).Key;
        Console.WriteLine(b);
    }
}