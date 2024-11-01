namespace _3_arrs;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> arr = new List<int>();
        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine()));
        }
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        arr.Sort();
        var arr1 = arr.FindAll(t => t < a);
        var arr2 = arr.FindAll(t => a < t && t < b);
        var arr3 = arr.FindAll(t => b < t);

        void Printer(List<int> ints)
        {
            foreach (var toprint in ints)
            {
                Console.WriteLine(toprint);
            }
        }

        Printer(arr1);
        Printer(arr2);
        Printer(arr3);
    }
}