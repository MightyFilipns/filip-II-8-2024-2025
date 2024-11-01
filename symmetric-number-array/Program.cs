namespace symmetric_number_array;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            numbers.Add(v);
        }

        for (int i = 0; i < numbers.Count()/2; i++)
        {
            if (numbers[i] != numbers[numbers.Count()-1-i])
            {
                Console.WriteLine("nije");
                return;
            }
        }
        Console.WriteLine("jeste");
    }
}