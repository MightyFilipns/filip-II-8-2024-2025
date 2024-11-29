namespace broj_parova;

class Program
{
    static void Main(string[] args)
    {
        int c = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        List<int> lista = new List<int>();
        for (int i = 0; i < n; i++)
        {
            lista.Add(int.Parse(Console.ReadLine()));
        }

        int cnt = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n/2; j++)
            {
                if (lista[i] + lista[j] == c)
                {
                    cnt++;
                }
            }
        }
        Console.WriteLine(cnt);
    }
}