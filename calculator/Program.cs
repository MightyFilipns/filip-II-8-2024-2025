namespace calculator;

class Program
{
    static void Main(string[] args)
    {
        List<(String op, Delegate del)> ops = new List<(String op, Delegate del)>();
        ops.Add(("+", delegate (Object op1, Delegate op2) { return op1.ToString() + op2.ToString(); }));
        var b = GetNum();
        var a = GetNum();
        ops[0].del.DynamicInvoke(b);
    }

    private static int GetNum()
    {
        Console.Write("Enter Integer:");
        int a= int.Parse(Console.ReadLine());
        return a;
    }
}