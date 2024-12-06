using Console = System.Console;

namespace broj_rastucih_segmenata;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> lista = new List<int>();
        for (int i = 0; i < n; i++)
        {
            lista.Add(int.Parse(Console.ReadLine()));
        }
        //------------------BROKEN------------------//
        int cnt = 0;
        int len = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (lista[j] <= lista[j-1])
                {
                    if (len != 0)
                    {
                        cnt++;
                        len = 0;
                        break;
                    }   
                }
                else if (len != 0)
                {
                    cnt++;
                }
                len++;
            }
        }
        Console.WriteLine(cnt);
    }
}