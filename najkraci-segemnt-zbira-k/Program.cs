namespace najkraci_segemnt_zbira_k;

class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        int min_sum = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += list[j];
                if (sum == k)
                {
                    min_sum = Math.Min(min_sum, j - i + 1); // broken
                    break;
                }
            }
        }

        if (min_sum == Int32.MaxValue)
        {
            Console.WriteLine("-");
        }
        {
            Console.WriteLine(min_sum);
        }
    }
}