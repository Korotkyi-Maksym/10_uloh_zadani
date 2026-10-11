namespace Uloha9;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, int> pismena = new Dictionary<char, int>();

        Console.WriteLine("Zadej slovo:");
        string slovo = Console.ReadLine();

        for (int i = 0; i < slovo.Length; i++)
        {
            char p = char.ToLower(slovo[i]);

            if (pismena.ContainsKey(p))
            {
                pismena[p] = pismena[p] + 1;
            }
            else
            {
                pismena.Add(p, 1);
            }
        }

        foreach (var p in pismena)
        {
            Console.WriteLine(p.Key + " - " + p.Value);
        }
    }
}

