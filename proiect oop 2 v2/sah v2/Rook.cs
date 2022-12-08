using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sah_v2
{
    class Rook : Piece
    {
        public const string bRook = "C:/Users/uif31464/Desktop/chess/Chess_rdt60.png";
        public const string wRook = "C:/Users/uif31464/Desktop/chess/Chess_rlt60.png";

        public Rook()
        {

        }

        public override void Move(object sender, EventArgs args)
        {
            var button = sender as Piece;
            if (button.Image == Image.FromFile(bRook))
                GetAvailableMovesBlackRook();
            if (button.Image == Image.FromFile(wRook))
                GetAvailableMovesWhiteRook();
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

        public void GetAvailableMovesBlackRook()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == 1)
            {
                while (PieceLocationI < 8)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationI;
                }
                while (PieceLocationI >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationI;
                }
                while (PieceLocationJ >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationJ;
                }
                while (PieceLocationJ < 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] <= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationJ;
                }
            }
        }
        public void GetAvailableMovesWhiteRook()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == -1)
            {
                while (PieceLocationI < 8)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationI;
                }
                while (PieceLocationI >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationI;
                }
                while (PieceLocationJ >= 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    --PieceLocationJ;
                }
                while (PieceLocationJ < 0)
                {
                    if (Positions[PieceLocationI, PieceLocationJ] >= 0)
                        A[PieceLocationI, PieceLocationJ] = 1;

                    ++PieceLocationJ;
                }
            }
        }
    }
}
