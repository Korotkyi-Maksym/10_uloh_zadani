using System;
using System.Collections.Generic;
using System.Text;

namespace Uloha6
{
    internal class Kruh
    {
       
            public double Polomer;

            public void VypocitejObvod()
            {
                double obvod = 2 * 3.14 * Polomer;
                Console.WriteLine("Obvod: " + obvod);
            }

            public void VypocitejObsah()
            {
                double obsah = 3.14 * Polomer * Polomer;
                Console.WriteLine("Obsah: " + obsah);
            }
        
    }
}
