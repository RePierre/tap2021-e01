using System;

namespace Solutie
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var rezerva1 = new CameraMansarda();
            rezerva1.Rezerva(6);
            Console.WriteLine($"Pretul pentru a sta la mansarda (1 persoana) este: {rezerva1.pret} RON");

            var rezerva2 = new CameraFamilie();
            rezerva2.Rezerva(4);
            Console.WriteLine($"Pretul pentru a sta la parter este: {rezerva2.pret} RON");

        


        }
    }
}

