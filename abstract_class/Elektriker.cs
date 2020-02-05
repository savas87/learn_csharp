using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    class Elektriker : Arbeiter
    {
        public override void Arbeitverrichten()
        {
            Console.WriteLine("Der Elektriker öffnen die Türe");
        }
    }
}
