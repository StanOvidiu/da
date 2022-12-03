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
        public const string bBishop = "C:/Users/stano/OneDrive/Desktop/New folder/Chess_bdt60.png";
        public const string wBishop = "C:/Users/stano/OneDrive/Desktop/New folder/Chess_blt60.png";

        public Bishop()
        {

        }

        public override void Move(object sender, EventArgs args)
        {
            var button = sender as Piece;
            if (button.Image == Image.FromFile(bBishop))
                GetAvailableMovesBlackBishop();
            if (button.Image == Image.FromFile(wBishop))
                GetAvailableMovesWhiteBishop();
            if (first_click)
            {
                if (firstB.Image == null)
                    return;
                firstB = button;
                value = Positions[PieceLocationI, PieceLocationJ];
                Positions[PieceLocationI, PieceLocationJ] = 0;
                first_click = false;
            }
            else
            {
                if (A[PieceLocationI, PieceLocationJ] == 1)
                {
                    button.Image = firstB.Image;
                    button.PieceColor = firstB.PieceColor;
                    Positions[PieceLocationI, PieceLocationJ] = value;
                    firstB.Image = null;
                    firstB.PieceColor = 0;
                    value = 0;
                }
                else
                    return;
                first_click = true;
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
