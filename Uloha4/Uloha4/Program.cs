namespace Uloha4
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<int> list = new List<int>(20);
            
            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(1, 100));
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"| {list[i]} |");

            }
            list.Add(rnd.Next(1, 100));
            for (int i = 0; i < list.Count; i++)
            {
                if (i %2 == 0)
                {
                    list.RemoveAt(i);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"| {list[i]} |");
            }
        }
    }
}
