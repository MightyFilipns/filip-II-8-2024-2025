namespace selectionsort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> tosort = new List<int>() { 354,345,7,1,2312,3,678798,22,55,67,89};
            for (int i = 0; i < tosort.Count; i++)
            {
                for (int j = i; j > 0 && tosort[j-1] > tosort[j]; j--)
                {
                    int a = tosort[j - 1];
                    tosort[j - 1] = tosort[j];
                    tosort[j] = a;
                }
            }
            foreach (var item in tosort)
            {
                Console.WriteLine(item);
            }
        }

    }
}
