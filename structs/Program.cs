using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Buch buchEins = new Buch("Title", "Autor", 1234); //aufruf des Konstruktors
            Buch buchZwei; //erzeugen ohne new 
            Console.WriteLine(buchEins.title);
            Console.WriteLine(buchEins.autor);
            Console.WriteLine(buchEins.seitenAnzahl);

        }
    }
    struct Buch
    {
        // variablen
        public string title;
        public string autor;
        public int seitenAnzahl;

        // constructor
        public Buch(string _title, string _autor, int _seitenAnzahl)
        {
            title = _title;
            autor = _autor;
            seitenAnzahl = _seitenAnzahl;
        }
    }
}
