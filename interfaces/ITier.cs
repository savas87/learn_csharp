using System;
using System.Collections.Generic;
using System.Text;

namespace Fortgeschritten
{
    interface ITier
    {
        // Eigenschaften
        int Alter { get; set; }
        string Geschlecht { get; set; }
        // Methoden
        void Essen();
        void Trinken();
    }
}
