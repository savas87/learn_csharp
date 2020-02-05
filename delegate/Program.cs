using System;

namespace Delegaten
{
    class Program
    {
        //delegate definition
        public delegate int Berechne(int x, int y);
        static void Main(string[] args)
        {
            // create delegate with variable aufrufer
            Berechne aufrufer = new Berechne(Addition); // instanz delegate with method as param 
            int ergebnis = aufrufer(5, 1); // create new var equal aufrufer with param, that calls addtion method
            Console.WriteLine(ergebnis);
            Console.ReadKey();
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }
        static int Subtraktion(int x, int y)
        {
            return x - y;
        }
    }
}
