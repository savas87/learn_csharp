using System;
using System.Collections.Generic;
using System.Text;

namespace Fortgeschritten
{
    class Haushund : ITier
    {
        //Konstruktor
        public Haushund(int _alter, string _geschlecht)
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
            Console.WriteLine("Der Hund isst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt...");
        }
    }
}
