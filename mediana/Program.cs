namespace mediana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 45, 56, 78 , 89, 86};
            nums.Sort();
            int median = 0;
            if (nums.Count % 2 == 0)
            {
                median = nums[nums.Count / 2] + nums[nums.Count / 2 + 1];
            }
            else
            {
                median = nums[(nums.Count / 2)];
            }
            Console.WriteLine(median);
        }
    }
}
