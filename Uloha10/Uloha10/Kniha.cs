using System;
using System.Collections.Generic;
using System.Text;

namespace Uloha10
{
    internal class Kniha
    {
        public string Nazev;
        public string Autor;
        public int RokVydani;
        public int PocetStran;

        public void VypisInformace()
        {
            Console.WriteLine(Nazev + " - " + Autor
                + ", rok: " + RokVydani
                + ", stran: " + PocetStran);
        }
    }
}
