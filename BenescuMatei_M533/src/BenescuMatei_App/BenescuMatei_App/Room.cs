using System;
using System.Collections.Generic;
using System.Text;

namespace BenescuMatei_App
{
    class Room
    {



        public Decimal pret { get; set; };
        public int NumarulCamerei { get; set; };
        public bool EsteLuata { get; set; };
        public String pozitionarea { get; set; };

        public Room(Decimal pret, int NumarulCamerei, string pozitionare, bool rezervat)
        {
            this.pret = pret;
            this.NumarulCamerei = NumarulCamerei;
            this.pozitionarea = pozitionare;
            this.EsteLuata = rezervat;


        }
    }
}
