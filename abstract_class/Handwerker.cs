using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    class Handwerker : Arbeiter
    {
        public override void Arbeitverrichten()
        {
            Console.WriteLine("Der Handwerker repariert das Auto und hat das Gehalt {0}", Gehalt);

        }
    }
}
