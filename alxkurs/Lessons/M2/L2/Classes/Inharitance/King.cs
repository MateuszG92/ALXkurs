using alxkurs.Lessons.M1.L2;
using alxkurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2.Classes.Inharitance
{
    public class King : ChessPiece
    {
        public bool Checked { get; set; }

        public King() : base()
        {
            Checked = false;
            Type = ChesFiguresType.KING;
        }

        public void Move()
        {
            Console.WriteLine("King is moving");
        }
    }
}
