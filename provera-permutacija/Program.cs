namespace provera_permutacija;

class Program
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>();
        
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            lista.Add(Console.ReadLine());
        }
        
        string target = Console.ReadLine();
        lista.Sort();

        foreach (var chr in target)
        {
            int rez = 0;
            if ((rez = lista.BinarySearch(chr.ToString())) > 0)
            {
                lista.RemoveAt(rez);
            }
            else
            {
                Console.WriteLine("NE");
                return;
            }
        }

        if (lista.Count != 0)
        {
            Console.WriteLine("NE");
            return;
        }
        Console.WriteLine("DA");
    }
}