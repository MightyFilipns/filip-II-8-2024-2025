namespace dvo_struki_student;

class Program
{
    static void Main(string[] args)
    {
        string inp;
        SortedSet<string> students = new SortedSet<string>();
        string result = "";
        while ((inp = Console.ReadLine()) != "")
        {
            if (inp.Contains(inp))
            {
                result = inp;
            }
            students.Add(inp);
        }
        Console.WriteLine(result);
    }
}