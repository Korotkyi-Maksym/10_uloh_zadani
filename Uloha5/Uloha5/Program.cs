namespace Uloha5;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> studenti = new Dictionary<string, int>();

        studenti.Add("Petr", 1);
        studenti.Add("Jan", 2);
        studenti.Add("Eva", 3);
        studenti.Add("Anna", 1);
        studenti.Add("Martin", 4);

        Console.WriteLine("Seznam studentu:");

        foreach (var student in studenti)
        {
            Console.WriteLine(student.Key + " - znamka: " + student.Value);
        }

        Console.WriteLine("Zadej jmeno studenta:");
        string jmeno = Console.ReadLine();

        if (studenti.ContainsKey(jmeno))
        {
            Console.WriteLine("Zadej novou znamku:");
            int znamka = int.Parse(Console.ReadLine());

            studenti[jmeno] = znamka;
        }
        else
        {
            Console.WriteLine("Student nebyl nalezen.");
        }

        Console.WriteLine("Aktualizovany seznam:");

        foreach (var student in studenti)
        {
            Console.WriteLine(student.Key + " - znamka: " + student.Value);
        }
    }
}

