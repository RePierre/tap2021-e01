using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare
{   

    public enum TypeOfRoom
    {
        FamillyRoom,
        SingleRoom,
        DoubleRoom,
        SpecialDoubleRoom

    }
    class Room
    {
        TypeOfRoom type;
        
        public Room(){}
        public Room(TypeOfRoom type)
        {
            this.type = type;
        }

        public int CalculatePrice(TypeOfRoom type)
        {
            if (this.type == TypeOfRoom.FamillyRoom ) return 200;
            if (this.type == TypeOfRoom.DoubleRoom) return 120;
            if (this.type == TypeOfRoom.SpecialDoubleRoom) return 150;
            if (this.type == TypeOfRoom.SingleRoom) return 100;
            return -1;
        }

    }
}
