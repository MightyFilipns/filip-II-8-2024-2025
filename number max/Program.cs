namespace number_max;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(arr.Max());
    }
}