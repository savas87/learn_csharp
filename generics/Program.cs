using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanziieren
            Wertebehälter<int> behälter = new Wertebehälter<int>(100); //(100) constructor call
            behälter.Ausgabe();
            Console.ReadKey();

        }
    }

    //generic class
    public class Wertebehälter<T>
    {
        // T is like a datatype
        // var
        private T MeinWert;

        // constructor
        public Wertebehälter(T _wert)
        {
            MeinWert = _wert;
        }

        // method
        public void Ausgabe()
        {
            Console.WriteLine(MeinWert.ToString());
        }

    }
}
