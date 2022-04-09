using System;
using System.Collections.Generic;
using System.Text;

namespace Lynq
{
    class Day25Task
    {
        public static void Main()
        {
            int Legs, Eyes, Animals, Goat, Duck, Tlegs, i;
            Legs = 80;
            Eyes = 52;
            Animals = Eyes / 2;
            for (i = 1; i <= Legs; i++)
            {
                Goat = i / 4;
                Duck = (Legs - i) / 2;
                Tlegs = (Goat * 4) + (Duck * 2);
                if ((Goat + Duck) == Animals && Tlegs == Legs)
                {
                    Console.WriteLine("Goat=" + Goat + "\n" + "Duck=" + Duck);
                }
            }

        }
    }
}
