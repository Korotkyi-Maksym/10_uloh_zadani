namespace Uloha1
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] pole = new int[10];
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(1, 101);
            }
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }
            int min = 100000;
            int max = 0;
            double prumer = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i]<min)
                {
                    min = pole[i];
                }
                else if (pole[i]> max)
                {
                    max = pole[i];
                }
                prumer += pole[i];
            }
            Console.WriteLine($"Minimalni cislo v poli je: {min} a nejvetsi cislo je: {max}");
            prumer = prumer / pole.Length;
            Console.WriteLine($"Prumer je: {prumer}");
            Array.Sort(pole);
            foreach (int cisla in pole)
            {
                Console.WriteLine(cisla);
            }
        }
    }
}
