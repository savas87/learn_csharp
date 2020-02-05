using System;

namespace Enumeratoren
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variable from enum 
            Wochentag day = Wochentag.Montag;
            Console.WriteLine("Es ist " + day); // Write es ist montag
            Console.WriteLine(day + " hat den Wert " + (int)day); // take value from montag
            Console.ReadKey();
        }
    }

    //enum declaration
    enum Wochentag
    {
        Montag = 10, 
        Dienstag,
        Mittwoch,
        Donnerstag,
        Freitag,
        Samstag,
        Sonntag
    }
}
