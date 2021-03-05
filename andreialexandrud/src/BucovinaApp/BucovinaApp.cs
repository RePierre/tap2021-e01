using System;

namespace BucovinaApp
{
    class BucovinaApp
    {

        private static BucovinaApp _instance;
        private Camere camera;
     

        private BucovinaApp()
        {

            System.Console.WriteLine("cerv");
        }

        public BucovinaApp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BucovinaApp();

                }
                return _instance;
            }
        }
        public void GetInfoFromClients(char type, DateTime startTime, DateTime endTime)
        {
            Instance.camera = new Camere(type);

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }


 }

