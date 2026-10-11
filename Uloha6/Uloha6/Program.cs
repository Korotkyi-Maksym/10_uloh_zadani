namespace Uloha6;

using System;



class Program
{
    static void Main()
    {
        Kruh k = new Kruh();

        Console.WriteLine("Zadej polomer:");
        k.Polomer = double.Parse(Console.ReadLine());

        k.VypocitejObvod();
        k.VypocitejObsah();
    }
}