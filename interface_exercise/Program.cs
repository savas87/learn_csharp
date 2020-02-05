using System;

namespace Interface_Aufgabe_Videospielgegenstand
{
    class Program
    {
        static void Main(string[] args)
        {
            IGegenstand[] gegenstand = new IGegenstand[3];
            gegenstand[0] = new Trank(100, "Redbull");
            gegenstand[1] = new Schwert(2350, "Goldschwert");
            gegenstand[2] = new Schwert(125, "Plastikschwert");

            foreach(IGegenstand element in gegenstand)
            {
                if(element is Trank)
                {
                    Console.WriteLine("Der Trank ist {0} hat einen Wert von {1} ", element.Name, element.Goldwert);
                } else if(element is Schwert)
                {
                    Console.WriteLine("Das Schwert ist ein {0} hat einen Wert von {1} ", element.Name, element.Goldwert);

                }
                Console.ReadKey();
            }
        }
    }
}
