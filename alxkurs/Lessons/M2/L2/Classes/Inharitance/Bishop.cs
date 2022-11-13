using alxkurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2.Classes.Inharitance
{
    public class Bishop:ChessPiece
    {
        public Bishop() : base()
        {
            Type = ChesFiguresType.BISHOP;
        }

        public void Move()
        {
            Console.WriteLine("Bishop is moving");
        }
    }
}
