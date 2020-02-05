using System;
using System.Collections.Generic;
using System.Text;

namespace Fortgeschritten
{
    class Löwe : ITier
    {
        //Konstruktor
        public Löwe(int _alter, string _geschlecht)
        {
            Alter = _alter;
            Geschlecht = _geschlecht;
        }
        // Eigenschaften
        public int Alter { get; set; }
        public string Geschlecht { get; set; }

        //Methoden
        public void Essen()
        {
            Console.WriteLine("Der Löwe isst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Löwe trinkt...");
        }
    }
}
