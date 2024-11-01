namespace triangle;

class Program
{
    static void Main(string[] args)
    {
        int a = GetNum();
        int b = GetNum();
        int c = GetNum();
        List<int> nums = new List<int>() { a,b,c};
        if (a==b && b==c)
        {
            Console.WriteLine("equilateral triangle");
            return;
        }
        List<int> search = new List<int>() {75,60,45};
        foreach (var num in nums)
        {
            int i = search.IndexOf(num);
            if (i >= 0)
            {
                search.RemoveAt(i);
            }
            else
            {
                break;
            }
        }

        if (search.Count == 0)
        {
            Console.WriteLine("scalene");
            return;
        }
        search = new List<int>() {30,75,75};
        foreach (var num in nums)
        {
            int i = search.IndexOf(num);
            if (i >= 0)
            {
                search.RemoveAt(i);
            }
            else
            {
                break;
            }
        }

        if (search.Count == 0)
        {
            Console.WriteLine("isosceles");
            return;
        }
        Console.WriteLine("other");
    }
    private static int GetNum()
    {
        Console.Write("Enter Integer:");
        int a= int.Parse(Console.ReadLine());
        return a;
    }
}