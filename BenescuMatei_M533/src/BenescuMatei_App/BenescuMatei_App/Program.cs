using System;

namespace BenescuMatei_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Room cam1 = new Room(200, 1, "parter", false);
            Receptie receptie = new Receptie();
            receptie.CereMenu();
        }
    }
}
