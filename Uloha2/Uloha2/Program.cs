namespace Uloha2
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] pole = new int[5, 5];
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = rnd.Next(1, 50);
                }
            }
            int min = 100000;
            int max = 0;
            int soucet = 0;
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    soucet += pole[i, j];
                    if (min > pole[i,j])
                    {
                        min = pole[i, j];
                    }
                    else if (max < pole[i,j])
                    {
                        max = pole[i, j];
                    }
                    Console.Write($"| {pole[i,j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Minimalni cislo v pole je: {min}, maximalni je: {max} a soucet vsech cisel je: {soucet}");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.WriteLine(pole[i, j]);
                    }
                    else if (i == 1&&j==1)
                    {
                        Console.WriteLine(pole[i, j]);
                    }
                    else if (i==2&&j==2)
                    {
                        Console.WriteLine(pole[i, j]);
                    }
                    else if (i == 3 && j == 3)
                    {
                        Console.WriteLine(pole[i, j]);
                    }
                    else if (i == 4 && j == 4)
                    {
                        Console.WriteLine(pole[i, j]);
                    }
                }
            }
        }
    }
}
