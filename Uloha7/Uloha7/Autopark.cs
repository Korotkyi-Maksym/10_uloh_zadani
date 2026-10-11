using System;
using System.Collections.Generic;
using System.Text;

namespace Uloha7
{
    internal class Autopark
    {
        public List<Auto> Auta = new List<Auto>();

        public void PridejAuto(Auto auto)
        {
            Auta.Add(auto);
        }

        public void OdeberAuto(string znacka)
        {
            for (int i = 0; i < Auta.Count; i++)
            {
                if (Auta[i].Znacka == znacka)
                {
                    Auta.RemoveAt(i);
                    Console.WriteLine("Auto odebrano.");
                    return;
                }
            }

            Console.WriteLine("Auto nenalezeno.");
        }

        public void VypisAuta()
        {
            foreach (Auto a in Auta)
            {
                Console.WriteLine(a.Znacka + " " + a.Model
                    + " " + a.RokVyroby
                    + " " + a.NajeteKilometry + " km");
            }
        }
    }
}
