using System;

namespace Fortgeschritten
{
    class Program
    {
        static void Main(string[] args)
        {
            ITier[] tierSammlung = new ITier[3];
            tierSammlung[0] = new Löwe(10, "Weibchen");
            tierSammlung[1] = new Haushund(2, "Männchen");
            tierSammlung[2] = new Haushund(5, "Weibchen");

            //ausgabe
            foreach(ITier tier in tierSammlung) //  für jedes tier in tiersammlung
            {
                // typ überprüfen
                if(tier is Löwe)
                {
                    Console.WriteLine("Das Löwe ist {0} und ein {1}", tier.Alter, tier.Geschlecht);
                } else if(tier is Haushund)
                {
                    Console.WriteLine("Das Haushund ist {0} und ein {1}", tier.Alter, tier.Geschlecht);
                }
                Console.ReadKey();
            }
        }
    }

}
