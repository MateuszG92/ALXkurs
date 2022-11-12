using alxkurs.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M1.L2
{
    public class L2EnumsSwitch
    {
        public static void Run()
        {
            var whiteQueen = new ChessFigure(ChesFiguresType.QUEEN, ChessColor.WHITE);
            
            var blackQueen = new ChessFigure();
            blackQueen.FigureType = ChesFiguresType.QUEEN;
            blackQueen.FigureColor = ChessColor.BLACK;

            var whiteKing = new ChessFigure 
            { 
                FigureType = ChesFiguresType.KING,
                FigureColor = ChessColor.WHITE,
            };
            var blackBishop = new ChessFigure(ChesFiguresType.BISHOP, ChessColor.BLACK);

            GetFigureType(blackBishop);
            GetFigureType(blackQueen);
            GetFigureType(whiteKing);
            GetFigureType(whiteQueen);
        }

        private static void GetFigureType(ChessFigure chessFigure)
        {
            switch (chessFigure.FigureType)
            {
                case ChesFiguresType.QUEEN:
                    Console.WriteLine("The figur is a queen");
                    break; 
                case ChesFiguresType.KING:
                    Console.WriteLine("The figur is a king");
                    break;
                case ChesFiguresType.ROOK:
                    Console.WriteLine("The figur is a rook");
                    break;
                case ChesFiguresType.BISHOP:
                    Console.WriteLine("The figur is a bishop");
                    break;
                case ChesFiguresType.KNIGHT:
                    Console.WriteLine("The figur is a knight");
                    break;
                case ChesFiguresType.PAWN:
                    Console.WriteLine("The figur is a pawn");
                    break;
                default:
                    Console.WriteLine("The type is undefined");
                    break;
            }
            Console.WriteLine("The figure has been classified");
        }
    }
}
