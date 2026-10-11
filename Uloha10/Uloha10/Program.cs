namespace Uloha10;

using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Knihovna knihovna = new Knihovna();
        knihovna.Nazev = "Mestska knihovna";

        string[] nazvy = {
            "Harry Potter", "Hobit", "1984",
            "Farma zvirat", "Maly princ", "Zaklinac",
            "Robinson Crusoe", "Kytice", "Babicka",
            "Romeo a Julie"
        };

        string[] autori = {
            "J. K. Rowling", "J. R. R. Tolkien", "George Orwell",
            "George Orwell", "Antoine de Saint-Exupery",
            "Andrzej Sapkowski", "Daniel Defoe",
            "Karel Jaromir Erben", "Bozena Nemcova",
            "William Shakespeare"
        };

        for (int i = 0; i < nazvy.Length; i++)
        {
            Kniha k = new Kniha();
            k.Nazev = nazvy[i];
            k.Autor = autori[i];
            k.RokVydani = 2000;
            k.PocetStran = 200;

            knihovna.PridejKnihu(k);
        }

        int volba = 0;

        while (volba != 6)
        {
            Console.WriteLine("\n1 - Pridat knihu");
            Console.WriteLine("2 - Odebrat knihu");
            Console.WriteLine("3 - Hledat knihu");
            Console.WriteLine("4 - Hledat podle autora");
            Console.WriteLine("5 - Vypsat vsechny knihy");
            Console.WriteLine("6 - Konec");

            volba = int.Parse(Console.ReadLine());

            switch (volba)
            {
                case 1:
                    Kniha nova = new Kniha();

                    Console.WriteLine("Nazev:");
                    nova.Nazev = Console.ReadLine();

                    Console.WriteLine("Autor:");
                    nova.Autor = Console.ReadLine();

                    Console.WriteLine("Rok vydani:");
                    nova.RokVydani = int.Parse(Console.ReadLine());

                    Console.WriteLine("Pocet stran:");
                    nova.PocetStran = int.Parse(Console.ReadLine());

                    knihovna.PridejKnihu(nova);
                    break;

                case 2:
                    Console.WriteLine("Zadej nazev knihy:");
                    string nazev = Console.ReadLine();

                    knihovna.OdeberKnihu(nazev);
                    break;

                case 3:
                    Console.WriteLine("Zadej nazev knihy:");
                    string hledana = Console.ReadLine();

                    knihovna.NajdiKnihuPodleNazvu(hledana);
                    break;

                case 4:
                    Console.WriteLine("Zadej autora:");
                    string autor = Console.ReadLine();

                    knihovna.VypisKnihyOdAutora(autor);
                    break;

                case 5:
                    knihovna.VypisVsechnyKnihy();
                    break;

                case 6:
                    Console.WriteLine("Konec programu.");
                    break;

                default:
                    Console.WriteLine("Spatna volba.");
                    break;
            }
        }
    }
}

