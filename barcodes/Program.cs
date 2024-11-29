using System.Collections.Generic;

namespace barcodes;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> barcodes = new List<int>();
        foreach (var i in Console.ReadLine().Split(" ").Select(int.Parse))
        {
            barcodes.Add(i);
        }
        List<int> barcodes2 = new List<int>();
        string inp = "";
        while ((inp = Console.ReadLine()) != "")
        {
            barcodes2.Add(int.Parse(inp));
        }
        var for_sale = barcodes2.Intersect(barcodes).ToList();
        Console.WriteLine(for_sale.Count); 
    }
}