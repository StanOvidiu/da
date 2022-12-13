using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sah_v2
{
    class Bishop : Piece
    {
        public const string bBishop = "C:/Users/uif31464/Desktop/chess/Chess_bdt60.png";
        public const string wBishop = "C:/Users/uif31464/Desktop/chess/Chess_blt60.png";

        
        public Bishop()
        {

        }
        public Bishop(int i, int j, int color)
        {
            this.PieceLocationI = i;
            this.PieceLocationJ = j;
            this.PieceColor = color;
        }

        public override void Move(object sender, EventArgs args)
        {
            var button = sender as Piece;
            if (first_click)
            {
                if(button.PieceColor == 1)
                    GetAvailableMovesBlackBishop();
                if (button.PieceColor == -1)
                    GetAvailableMovesWhiteBishop();
                if (button.Image == null)
                    return;
                firstB = button;
                value = Positions[PieceLocationI, PieceLocationJ];
                Positions[PieceLocationI, PieceLocationJ] = 0;
                first_click = false;
            }
            else
            {
                first_click = true;
                if (A[button.PieceLocationI, button.PieceLocationJ] == 1)
                {
                    button.Image = firstB.Image;
                    button.PieceColor = firstB.PieceColor;
                    button.type = firstB.type;
                    Positions[button.PieceLocationI, button.PieceLocationJ] = value;
                    firstB.Image = null;
                    firstB.PieceColor = 0;
                    firstB.type = 0;
                    value = 0;
                }
                else
                    return;
            }
        }

        public void GetAvailableMovesBlackBishop()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == 1)
            {
                while (PieceLocationI < 8 && PieceLocationJ < 8)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationI;
                    ++PieceLocationJ;
                }
                while (PieceLocationI >= 0 && PieceLocationJ >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationI;
                    --PieceLocationJ;
                }
                while (PieceLocationI < 8 && PieceLocationJ >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationI;
                    --PieceLocationJ;
                }
                while (PieceLocationI >= 0 && PieceLocationJ < 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationI;
                    ++PieceLocationJ;
                }
            }
        }
        public void GetAvailableMovesWhiteBishop()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == -1)
            {
                while (PieceLocationI < 8 && PieceLocationJ < 8)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationI;
                    ++PieceLocationJ;
                }
                while (PieceLocationI >= 0 && PieceLocationJ >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationI;
                    --PieceLocationJ;
                }
                while (PieceLocationI < 8 && PieceLocationJ >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationI;
                    --PieceLocationJ;
                }
                while (PieceLocationI >= 0 && PieceLocationJ < 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationI;
                    ++PieceLocationJ;
                }
            }
        }
    }
}
