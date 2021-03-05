using System;

namespace src
{
    public class Reception
    {
        public readonly Reception _instance = new Reception();

        public Reception Instance => _instance;

        private Reception()
        {
        }
    }
}
