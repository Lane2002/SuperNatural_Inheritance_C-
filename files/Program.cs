using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[10];
            int stormsIndex = 0;

            Pupil p = new Pupil("Mezil-Kree", "Icecrown");

            storms[stormsIndex] = p.CastWindStorm();
            stormsIndex++;

            Mage m = new Mage("Gul'dan", "Draenor");

            Console.WriteLine(m.Origin);

            storms[stormsIndex] = m.CastRainStorm();
            stormsIndex++;

            Archmage a = new Archmage("Nielas Aran");

            storms[stormsIndex] = a.CastWindStorm();
            stormsIndex++;

            storms[stormsIndex] = a.CastRainStorm();
            stormsIndex++;

            storms[stormsIndex] = a.CastLightningStorm();
            stormsIndex++;

            for (int i = 0; i < stormsIndex; i++)
            {
                // storms[0]
                Console.WriteLine(storms[i].Announce());
            }

        }
    }
}