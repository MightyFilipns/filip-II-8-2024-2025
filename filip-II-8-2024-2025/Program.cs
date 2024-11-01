namespace filip_II_8_2024_2025;

static class Program
{
    static void Main(string[] args)
    {
        ImperalSystem(186);
        MagicSquare();
        CashRegister(556,0);
        Console.WriteLine( Factorial(5));
        var st= Console.ReadLine().ToArray();
        for (var i = 0; i < st.Length; i+=2)
        {
            Console.Write(st[i]);
        }
    }

    static void MatrixMul()
    {
        int[,] ma = new int[3, 3];
        int[,] mb = new int[3, 3];
        int[,] mc = new int[3, 3];

        for (int i = 0; i < mc.Length; i++)
        {
            for (int j = 0; j < mc.Length; j++)
            {
                mc[i,j] = ma[i,j]*mb[i,j] + ma[i,j]*mb[j,j];
            }
        }
    }

    static int Factorial(int n)
    {
        return FactRecursion(1,1,n);
    }

    static int FactRecursion(int v, int depth, int maxdepth)
    {
        return depth > maxdepth ? v : FactRecursion(v*depth,depth+1,maxdepth);
    }

    static void CashRegister(int togive, int price)
    {
        int[] arr = [100, 50, 20, 10, 5, 2, 1];
        togive -= price;
        foreach (var bill in arr)
        {
            Console.WriteLine(togive/bill);
            togive %= bill;
        }
    }

    static void MagicSquare()
    {
        int[,] m = { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } };
        int sumr = 0, sumc = 0, oldsumc =-1;
        bool issquare = true;
        var l = m.GetLength(0);
        for (var i = 0; i < l; i++)
        {
            for (var j = 0; j < l; j++)
            {
                sumc += m[i, j];
                sumr += m[j, i];
            }

            if ((sumc != sumr || sumc != oldsumc) && oldsumc != -1)
            {
                issquare = false;
                break;
            }

            oldsumc = sumc;
            sumc = sumr = 0;
        }
        Console.WriteLine(issquare);
    }

    static void ImperalSystem(int incm)
    {
        int feet = (int)(incm/30.48);
        double inches = (int)((incm % 30.48)/2.54);
        Console.WriteLine(feet + "-" + inches);
    }
}