namespace arthimetic_triangle;

class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        var higherIndex = GetHigherIndex(k);
        var lowerIndex = GetLowerIndex(k);
        int n = (higherIndex - lowerIndex);
        int c = higherIndex + lowerIndex;
        double rez = n * c * 0.5F;
        Console.WriteLine(rez);
    }

    private static int GetLowerIndex(int r)
    {
        int ret = 1;
        for (int i = 1; i < r; i++)
        {
            ret = ret + 2;
        }
        return ret;
    }
    private static int GetHigherIndex(int r)
    {
        int ret = 0;
        for (int i = 1; i <= r; i++)
        {
            ret = ret + 2;
        }
        return ret;
    }
}