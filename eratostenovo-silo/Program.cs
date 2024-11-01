namespace eratostenovo_silo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nums = Enumerable.Range(0, n).ToList();
            for (int i = 2; i < n; i++)
            {
                nums = nums.Where(a => a % i != 0 || a == i).ToList();
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
