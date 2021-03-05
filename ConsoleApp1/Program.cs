using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Receptie:\n");
            Reception r1 = new Reception();
            r1.ReceptionCall(1,5);
            r1.ClearRoom(1);
            Console.ReadKey();
        }
    }
}
