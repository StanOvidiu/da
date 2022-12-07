using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sah_v2
{
    class Knight : Piece
    {
        public const string bKnight = "C:/Users/stano/OneDrive/Desktop/New folder/Chess_ndt60.png";
        public const string wKnight = "C:/Users/stano/OneDrive/Desktop/New folder/Chess_nlt60.png";

        public Knight()
        {

        }

        public override void Move(object sender, EventArgs args)
        {
            var button = sender as Piece;
            if (button.Image == Image.FromFile(bKnight))
                GetAvailableMovesBlackKnight();
            if (button.Image == Image.FromFile(wKnight))
                GetAvailableMovesWhiteKnight();
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
        public void GetAvailableMovesBlackKnight()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == 1)
            {
                if(Positions[PieceLocationI + 2,PieceLocationJ + 1] <= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
                if (Positions[PieceLocationI - 2, PieceLocationJ + 1] <= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
                if (Positions[PieceLocationI + 2, PieceLocationJ - 1] <= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
                if (Positions[PieceLocationI - 2, PieceLocationJ - 1] <= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
            }
        }
        public void GetAvailableMovesWhiteKnight()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == -1)
            {
                if (Positions[PieceLocationI + 2, PieceLocationJ + 1] >= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
                if (Positions[PieceLocationI - 2, PieceLocationJ + 1] >= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
                if (Positions[PieceLocationI + 2, PieceLocationJ - 1] >= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
                if (Positions[PieceLocationI - 2, PieceLocationJ - 1] >= 0)
                {
                    A[PieceLocationI, PieceLocationJ] = 1;
                }
            }
        }
    }
}
