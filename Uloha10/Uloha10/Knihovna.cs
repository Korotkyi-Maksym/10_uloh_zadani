using System;
using System.Collections.Generic;
using System.Text;

namespace Uloha10
{
    internal class Knihovna
    {
        public string Nazev;
        public List<Kniha> Knihy = new List<Kniha>();

        public void PridejKnihu(Kniha k)
        {
            Knihy.Add(k);
        }

        public void OdeberKnihu(string nazev)
        {
            for (int i = 0; i < Knihy.Count; i++)
            {
                if (Knihy[i].Nazev == nazev)
                {
                    Knihy.RemoveAt(i);
                    Console.WriteLine("Kniha odebrana.");
                    return;
                }
            }

            Console.WriteLine("Kniha nenalezena.");
        }

        public void VypisVsechnyKnihy()
        {
            foreach (Kniha k in Knihy)
            {
                k.VypisInformace();
            }
        }

        public void NajdiKnihuPodleNazvu(string nazev)
        {
            foreach (Kniha k in Knihy)
            {
                if (k.Nazev == nazev)
                {
                    k.VypisInformace();
                    return;
                }
            }

            Console.WriteLine("Kniha nenalezena.");
        }

        public void VypisKnihyOdAutora(string autor)
        {
            bool nalezena = false;

            foreach (Kniha k in Knihy)
            {
                if (k.Autor == autor)
                {
                    k.VypisInformace();
                    nalezena = true;
                }
            }

            if (nalezena == false)
            {
                Console.WriteLine("Knihy nenalezeny.");
            }
        }
    }
}
