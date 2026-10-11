namespace Uloha3
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int velikost = 10;
            int[] pole = VytvorPole(velikost);
            VytvorPole(velikost);
            VypisPole(pole);
            int min = 100000;
            int max = 0;
            double prumer = 0;
            Console.WriteLine(NajdiMinimum(min, pole));
            Console.WriteLine(NajdiMaximum(max, pole));
            Console.WriteLine(VypocitejPrumer(prumer,pole));
        }
        static int[] VytvorPole(int velikost)
        {
            int[] pole1 = new int[velikost];
            for (int i = 0; i < pole1.Length; i++)
            {
                pole1[i] = rnd.Next(1, 100);
            }
            return pole1;
        }
        static void VypisPole(int[] pole1)
        {
            foreach (var cislo in pole1)
            {
                Console.WriteLine(cislo);
            }
        }
        static int NajdiMinimum(int min1, int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i]<min1)
                {
                    min1 = pole[i];
                }
            }
            return min1;
        }
        static int NajdiMaximum(int max1, int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max1)
                {
                    max1 = pole[i];
                }
            }
            return max1;
        }
        static double VypocitejPrumer(double prumer, int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                prumer += pole[i];
            }
            prumer = prumer / pole.Length;
            return prumer;
        }
    }
}
