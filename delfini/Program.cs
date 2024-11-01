namespace delfini;

class Program
{
    public class Member
    {
        public Member(int fd,int pd)
        {
            first_day = fd;
            per_day = pd;
        }

        public int first_day;
        public int per_day;
    }

    static void Main(string[] args)
    {
        int train_days = int.Parse(Console.ReadLine());
        List<Member> members = new List<Member>();
        while (true)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
            {
                break;
            }
            int[] days = line.Split(" ").Select(int.Parse).ToArray();
            members.Add(new Member(days[0], days[1]));
        }

        foreach (var member in members)
        {
            int total_swum = member.first_day;
            for (int i = 1; i < train_days; i++)
            {
                total_swum += total_swum + member.per_day;
            }
            Console.WriteLine(total_swum);
        }
    }
}