using alxkurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M1.L2
{
    public class ChessFigure
    {
        public ChesFiguresType FigureType;
        public ChessColor FigureColor;
        public ChessFigure() {}
        public ChessFigure(ChesFiguresType chessFigureType, ChessColor chessColor)
        {
            FigureType = chessFigureType;
            FigureColor = chessColor;
        }
    }
    
}
