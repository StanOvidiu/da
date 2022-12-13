using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sah_v2
{
    class King : Piece
    {
        public const string bKing = "C:/Users/uif31464/Desktop/chess/Chess_kdt60.png";
        public const string wKing = "C:/Users/uif31464/Desktop/chess/Chess_klt60.png";

        
        public King()
        {

        }
        public King(int i, int j, int color)
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
                if (button.PieceColor == 1)
                    GetAvailableMovesBlackKing();
                if (button.PieceColor == -1)
                    GetAvailableMovesWhiteKing();
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

        public void GetAvailableMovesBlackKing()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == 1)
            {
                if (Positions[PieceLocationI, PieceLocationJ + 1] <= 0)
                    A[PieceLocationI, PieceLocationJ + 1] = 1;
                if (Positions[PieceLocationI, PieceLocationJ - 1] <= 0)
                    A[PieceLocationI, PieceLocationJ - 1] = 1;
                if (Positions[PieceLocationI + 1, PieceLocationJ] <= 0)
                    A[PieceLocationI + 1, PieceLocationJ + 1] = 1;
                if (Positions[PieceLocationI - 1, PieceLocationJ] <= 0)
                    A[PieceLocationI - 1, PieceLocationJ] = 1;
                if (Positions[PieceLocationI + 1, PieceLocationJ + 1] <= 0)
                    A[PieceLocationI + 1, PieceLocationJ + 1] = 1;
                if (Positions[PieceLocationI - 1, PieceLocationJ - 1] <= 0)
                    A[PieceLocationI - 1, PieceLocationJ - 1] = 1;
                if (Positions[PieceLocationI + 1, PieceLocationJ - 1] <= 0)
                    A[PieceLocationI + 1, PieceLocationJ - 1] = 1;
                if (Positions[PieceLocationI - 1, PieceLocationJ + 1] <= 0)
                    A[PieceLocationI - 1, PieceLocationJ + 1] = 1;
            }
        }
        public void GetAvailableMovesWhiteKing()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == -1)
            {
                if (Positions[PieceLocationI, PieceLocationJ + 1] >= 0)
                    A[PieceLocationI, PieceLocationJ + 1] = 1;
                if (Positions[PieceLocationI, PieceLocationJ - 1] >= 0)
                    A[PieceLocationI, PieceLocationJ - 1] = 1;
                if (Positions[PieceLocationI + 1, PieceLocationJ] >= 0)
                    A[PieceLocationI + 1, PieceLocationJ + 1] = 1;
                if (Positions[PieceLocationI - 1, PieceLocationJ] >= 0)
                    A[PieceLocationI - 1, PieceLocationJ] = 1;
                if (Positions[PieceLocationI + 1, PieceLocationJ + 1] >= 0)
                    A[PieceLocationI + 1, PieceLocationJ + 1] = 1;
                if (Positions[PieceLocationI - 1, PieceLocationJ - 1] >= 0)
                    A[PieceLocationI - 1, PieceLocationJ - 1] = 1;
                if (Positions[PieceLocationI + 1, PieceLocationJ - 1] >= 0)
                    A[PieceLocationI + 1, PieceLocationJ - 1] = 1;
                if (Positions[PieceLocationI - 1, PieceLocationJ + 1] >= 0)
                    A[PieceLocationI - 1, PieceLocationJ + 1] = 1;
            }
        }
    }
}
