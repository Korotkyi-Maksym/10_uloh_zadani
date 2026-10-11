namespace Uloha7;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Autopark park = new Autopark();

        Auto a1 = new Auto();
        a1.Znacka = "Skoda";
        a1.Model = "Octavia";
        a1.RokVyroby = 2020;
        a1.NajeteKilometry = 50000;

        Auto a2 = new Auto();
        a2.Znacka = "BMW";
        a2.Model = "M3";
        a2.RokVyroby = 2022;
        a2.NajeteKilometry = 20000;

        park.PridejAuto(a1);
        park.PridejAuto(a2);

        park.VypisAuta();

        Console.WriteLine("Zadej znacku auta k odebrani:");
        string znacka = Console.ReadLine();

        park.OdeberAuto(znacka);

        park.VypisAuta();
    }
}

