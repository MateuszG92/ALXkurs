using alxkurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2.Classes.Inharitance
{
    public class Knight:ChessPiece
    {
        public Knight() : base()
        {
            Type = ChesFiguresType.KNIGHT;
        }

        public void Move()
        {
            Console.WriteLine("Knight is moving");
        }
    }
}
