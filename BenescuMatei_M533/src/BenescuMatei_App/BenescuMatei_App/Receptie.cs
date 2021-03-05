using System;
using System.Collections.Generic;
using System.Text;

namespace BenescuMatei_App
{
    class Receptie
    {
        public Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
        {
            {"1",200 },
            {"2",120 },
            {"3",150},
            {"4",100 }


        };
        public decimal CalculeazaPret(Room camera, int durata, string optiune)
        {

            decimal pret = menu[optiune];
            return durata > 3 ? (pret - (pret * 0.1)) : pret;



        }


        public string CereMenu(Room camera)
        {

            Console.WriteLine("Alegeti o camera la care doriti sa va cazati:\n");
            Console.WriteLine("1: Camera de familie costă 200 RON/noapte");
            Console.WriteLine("2: O cameră dublă simplă costă 120 RON/noapte");
            Console.WriteLine("3:O cameră dublă cu vedere la munte costă 150 RON/noapte");
            Console.WriteLine("4:O cameră la mansardă costă 100 RON/noapte");
            string optiune = Console.ReadLine();

            return optiune;

        }
    }
}