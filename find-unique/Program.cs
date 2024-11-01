namespace find_unique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            string toadd = null;
            do
            {
                nums.Add(int.Parse(toadd));
                toadd = Console.ReadLine();
            } while (toadd != null);
            nums.Sort();
            for (var i = 1; i < nums.Count; i++)
            {
                if (nums[i-1] == nums[i])
                {
                    Console.WriteLine(nums[i]);
                    break;
                }
            }
        }
    }
}
