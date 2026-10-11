namespace Uloha8;

using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[,] matice = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matice[i, j] = rnd.Next(1, 10);
            }
        }

        int nejvetsi = 0;
        int radek = 0;

        for (int i = 0; i < 4; i++)
        {
            int soucet = 0;

            for (int j = 0; j < 4; j++)
            {
                Console.Write(matice[i, j] + " ");
                soucet = soucet + matice[i, j];
            }

            Console.WriteLine(" Soucet: " + soucet);

            if (i == 0 || soucet > nejvetsi)
            {
                nejvetsi = soucet;
                radek = i;
            }
        }

        Console.WriteLine("Nejvetsi soucet: " + nejvetsi);
        Console.WriteLine("Cislo radku: " + (radek + 1));
    }
}

