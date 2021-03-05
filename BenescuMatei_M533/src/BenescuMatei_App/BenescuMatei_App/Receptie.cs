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
        public CalculeazaPret(Room camera, int durata, string optiune)
        

            return durata > 3 ? (menu[optiune] - menu[optiune] * 0.1) : menu[optiune];



        }
                

        public int CereMenu(Room camera)
        {
        Console.WriteLine("Alegeti o camera la care doriti sa va cazati:\n");
        Console.WriteLine("1: Camera de familie costă 200 RON/noapte");
        Console.WriteLine("2: O cameră dublă simplă costă 120 RON/noapte");
        Console.WriteLine("3:O cameră dublă cu vedere la munte costă 150 RON/noapte");
        Console.WriteLine("4:O cameră la mansardă costă 100 RON/noapte");
        int optiune= Console.ReadLine();
        
        if()



    }
            
    }
}
