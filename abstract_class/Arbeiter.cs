using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    abstract class Arbeiter
    {
        // aus Abstrakte Klasse kann man kein Objekt instanziieren
        // properties
        public string Name { get; set; }
        public double Gehalt { get; set; }
        // methods
        // abstrakte methoden müssen in der erbenden Klasse überschrieben werden
        public virtual void Arbeitverrichten()
        {
            Console.WriteLine("Arbeiter macht seine Arbeit");
        }
    }
}
