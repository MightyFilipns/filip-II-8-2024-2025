namespace min_max_selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9 };
            list.Sort();
            List<int> final = Enumerable.Repeat(0, list.Count).ToList();
            for (int i = 0; i < final.Count; i++)
            {
                int min = list.Min();
                int fi = -1;
                if (i % 2 == 0)
                {
                    fi = i/2;
                }
                else
                {
                    fi = final.Count - (i+1)/2;
                }
                final[fi] = min;
                list.Remove(min);
            }
            foreach (var item in final)
            {
                Console.WriteLine(item);
            }
        }
    }
}
