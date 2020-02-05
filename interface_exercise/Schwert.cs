using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Aufgabe_Videospielgegenstand
{
    class Schwert : IGegenstand
    {
        public Schwert(int _goldwert, string _name)
        {
            Goldwert = _goldwert;
            Name = _name;
        }
        public int Goldwert { get; set; }
        public string Name { get; set; }

        public void Benutzen()
        {
            Console.WriteLine("Du greifst an!");
        }

        public void Verkaufen()
        {
            Console.WriteLine("Gegenstand Verkauft für {0}", Goldwert);
        }
    }
}
