using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace max_clique
{
    internal class Program
    {
        static bool[,] AdjMatrix = null;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            AdjMatrix = new bool[n,n];
            for (int i = 0; i < n; i++)
            {
                var d = Console.ReadLine().Where(char.IsAsciiDigit).ToList().Select(a => a == '1').ToList();
                for (var i1 = 0; i1 < d.Count(); i1++)
                {
                    AdjMatrix[i, i1] = d[i1];
                }
            } 

            int best = -1;
            for (int i = 0; i < n; i++)
            {
                int current = 0;
                List<int> current_cliquies = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (current_cliquies.All(a => AdjMatrix[a, j] || j == a))
                    {
                        current_cliquies.Add(j);
                    }
                }

                current = current_cliquies.Count();

                if (current > best)
                {
                    best = current;
                }
            }
            Console.WriteLine(best);
        }
    }
}
