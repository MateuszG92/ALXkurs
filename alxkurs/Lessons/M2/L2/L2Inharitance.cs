using alxkurs.Lessons.M1.L2.Enums;
using alxkurs.Lessons.M2.L2.Classes.Inharitance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2
{
    public class L2Inharitance
    {
        public static void Run()
        {
            var chessPiece = new King();
            chessPiece.XPosition = 1;
            chessPiece.YPosition = 1;
            chessPiece.Color = ChessColor.WHITE;
            chessPiece.Move();
            chessPiece.Present();

            Queen queen = new Queen();
            queen.Move();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Color = ChessColor.WHITE;
            queen.Present();
        }
    }
}
