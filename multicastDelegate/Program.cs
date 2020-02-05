using System;

namespace MulticastDelegate
{
    delegate void Ausgabe();
    class Program
    {
        static void Main(string[] args)
        {
            Ausgabe aufrufer = Begrüßung; //equal Begrüßung method
            aufrufer += Smalltalk;
            aufrufer += Verabschiedung;
            aufrufer(); // all the mehtods are called
            Console.ReadKey();
        }

        static void Begrüßung()
        {
            Console.WriteLine("Hallo!");
        }

        static void Smalltalk()
        {
            Console.WriteLine("Das ist echt schön hier!");
        }

        static void Verabschiedung()
        {
            Console.WriteLine("Tschüß");
        }
    }
}
