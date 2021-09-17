using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsTSM
{
    public class KnopenGenerator
    {
        public Knoop[] GeneerKnopen(int aantalKnopen)
        {
            Knoop[] knopen_gen = new Knoop[aantalKnopen];

            //de knopen liggen tussen x-coordinaten 100 en 900 en y-coordinaten 100 en 900 
            System.Random rnd = new System.Random();
            for (int i = 0; i <= aantalKnopen - 1; i++)
            {
                knopen_gen[i] = (new Knoop(rnd.Next(100, 900), rnd.Next(100, 900)));
            }
            return knopen_gen;
        }
    }
}
