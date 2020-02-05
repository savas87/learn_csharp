using System;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Begruessung("Jannik");
            Begruessung("Jannik", 23);
            Console.ReadKey();
        }

        // Methoden überlagerung
        // in Classe Programm muss methoden mit static anfangen
        static void Begruessung(string name)
        {
            Console.WriteLine("Hallo mein Name ist " + name);
        }
        static void Begruessung(string name, int alter)
        {
            Console.WriteLine("Hallo mein Name ist " + name + "und ich bin "+alter+" Jahre alt");
        }
    }
}
