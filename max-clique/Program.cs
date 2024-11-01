using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace max_clique
{
    internal class Program
    {
        static bool[,] AdjMatrix = null;

        private static int matrix_size = -1;

        static int max_clique = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            matrix_size = n;
            AdjMatrix = new bool[n,n];
            for (int i = 0; i < n; i++)
            {
                var d = Console.ReadLine().Split(" ");
                for (var i1 = 0; i1 < n; i1++)
                {
                    AdjMatrix[i, i1] = d[i1] == "1";
                }
            }
            DateTime ds = DateTime.Now;

            BronKerbosch([], Enumerable.Range(0, n).ToArray(), []);

            DateTime de = DateTime.Now;
            var rez = de - ds;
            Console.WriteLine(rez.Milliseconds + " ms");


            Console.WriteLine(max_clique);
        }


        public static void BronKerbosch(int[] R, int[] P, int[] X )
        {
            if (P.Length == X.Length && P.Length == 0)
            {
                max_clique = Math.Max(max_clique, R.Length);
            }

            foreach (var i in P.ToArray())
            {
                BronKerbosch(R.Union([i]).ToArray(),P.Intersect(N(i)).ToArray(),X.Intersect(N(i)).ToArray());
                P = P.Except([i]).ToArray();
                X = X.Union([i]).ToArray();
            }

            int[] N(int v)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < matrix_size; i++)
                {
                    if (AdjMatrix[v, i])
                    {
                        result.Add(i);
                    }
                }
                return result.ToArray();
            }
        }
    }
}
