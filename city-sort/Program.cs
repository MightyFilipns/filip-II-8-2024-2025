namespace city_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            cities.Sort();
            foreach (var item in cities)
            {
                Console.WriteLine($"X:{item.x} - Y:{item.y}");
            }
        }
    }

    struct City : IComparable<City>
    {
        public int x, y;

        public int CompareTo(City other)
        {
            int comp = (int)(Math.Sqrt(x^2+y^2) - Math.Sqrt(x^2+y^2));
            if (comp == 0)
            {
                if (x == other.x) 
                {
                    return y - other.y;
                }
                return x - other.x;
            }
            return comp;
        }
    }
}
