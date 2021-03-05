using System;
using System.Collections.Generic;
using System.Text;

namespace solutie
{
    public class Receptie
    {
        public int nr_camere_ocupate=0;

        public void Rezerva(Camera camera)
        {
            if (nr_camere_ocupate == 6)
            {
                throw new InvalidOperationException("Toate camerele sunt ocupate!");
            }else if (camera.ocupat == true)
            {
                throw new InvalidOperationException("Camera este ocupata");
            }
            else
            {
                Console.WriteLine("Camera rezervata cu succes!");
                nr_camere_ocupate++;
            }
        }
    }
}
