using System;

namespace solutie
{
    class Program
    {
        static void Main(string[] args)
        {
            var receptie = new Receptie();
            var cam1 = new CameraFamilie();
            var cam2 = new CameraDublaSimpla();
            var cam3 = new CameraDublaVM();
            var cam4 = new CameraDublaVM();
            var cam5 = new CameraMansarda();
            var cam6 = new CameraMansarda();
            try
            {
                receptie.Rezerva(cam6);
                cam6.PretTotal(4);
                Console.WriteLine($"Pretul dvs este: {cam6.pret} RON");

            }catch(InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                receptie.Rezerva(cam2);
                cam2.PretTotal(6);
                Console.WriteLine($"Pretul dvs este: {cam2.pret} RON");
            } catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
