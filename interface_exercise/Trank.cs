using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Aufgabe_Videospielgegenstand
{
    class Trank : IGegenstand
    {
        public Trank(int _goldwert, string _name)
        {
            Goldwert = _goldwert;
            Name = _name;
        }
        public int Goldwert { get; set; }
        public string Name { get; set; }

        public void Benutzen()
        {
            Console.WriteLine("Du trinkst den Trank!");
        }

        public void Verkaufen()
        {
            Console.WriteLine("Gegenstand Verkauft für {0}", Goldwert);
        }
    }
}
