namespace binary_input;

class Program
{
    static void Main(string[] args)
    {
        String inp = Console.ReadLine();
        if(!inp.All(a=> a is '1' or '0'))
        {
            Console.WriteLine("error input");
            return;
        }

        if (inp.First() != '1')
        {
            Console.WriteLine("error input");
            return;
        }
        
        int start = 0;
        int endi = 1;
        while (start < inp.Length)
        {
            int ind = inp.IndexOf('1', endi);
            if (ind < 0)
            {
                start = inp.IndexOf('1', start+1);;
                if (start < 0)
                {
                    break;
                }
                endi = start+1;
            }
            else
            {
                endi = ind +1;
                Console.WriteLine(inp.Substring(start, ind - start + 1));
            }
        }

        return;
        int n = 0;
        int i = 0;
        foreach (var chr in inp)
        {
            n |= byte.Parse(chr.ToString()) << i;
            i++;
        }
        Console.WriteLine(n);
    }

    public void input2()
    {
        
    }
}