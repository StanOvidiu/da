using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace sah_v2
{
    class Knight : Piece
    {
        public const string bKnight = "C:/Users/uif31464/Desktop/chess/Chess_ndt60.png";
        public const string wKnight = "C:/Users/uif31464/Desktop/chess/Chess_nlt60.png";

        //public bool first_click = true;
        //public Piece firstB = null;

        public Knight()
        {

        }
        public Knight(int i, int j, int color)
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
                    GetAvailableMovesBlackKnight(button);
                if (button.PieceColor == -1)
                    GetAvailableMovesWhiteKnight(button);
                if (button.Image == null)
                    return;
                firstB = button;
                firstB.PieceColor = button.PieceColor;
                firstB.type = button.type;
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
        public void GetAvailableMovesBlackKnight(Piece x)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (x.PieceColor == 1)
            {
                if(PieceLocationI + 2 < 8 && PieceLocationI + 2 >= 0 && PieceLocationJ + 1 < 8 && PieceLocationJ + 1 >= 0)
                    if(Positions[PieceLocationI + 2,PieceLocationJ + 1] <= 0)
                    {
                        A[PieceLocationI + 2, PieceLocationJ + 1] = 1;
                    }
                if(PieceLocationI - 2 < 8 && PieceLocationI - 2 >= 0 && PieceLocationJ + 1 < 8 && PieceLocationJ + 1 >= 0)
                    if (Positions[PieceLocationI - 2, PieceLocationJ + 1] <= 0)
                    {
                        A[PieceLocationI - 2, PieceLocationJ + 1] = 1;
                    }
                if(PieceLocationI + 2 < 8 && PieceLocationI + 2 >= 0 && PieceLocationJ - 1 < 8 && PieceLocationJ - 1 >= 0)
                    if (Positions[PieceLocationI + 2, PieceLocationJ - 1] <= 0)
                    {
                        A[PieceLocationI + 2, PieceLocationJ - 1] = 1;
                    }
                if(PieceLocationI - 2 < 8 && PieceLocationI - 2 >= 0 && PieceLocationJ - 1 < 8 && PieceLocationJ - 1 >= 0)
                    if (Positions[PieceLocationI - 2, PieceLocationJ - 1] <= 0)
                    {
                        A[PieceLocationI - 2, PieceLocationJ - 1] = 1;
                    }
                if (PieceLocationI - 1 < 8 && PieceLocationI - 1 >= 0 && PieceLocationJ + 2 < 8 && PieceLocationJ + 2 >= 0)
                    if (Positions[PieceLocationI - 1, PieceLocationJ + 2] <= 0)
                    {
                        A[PieceLocationI - 1, PieceLocationJ + 2] = 1;
                    }
                if (PieceLocationI + 1 < 8 && PieceLocationI + 1 >= 0 && PieceLocationJ + 2 < 8 && PieceLocationJ + 2 >= 0)
                    if (Positions[PieceLocationI + 1, PieceLocationJ + 2] <= 0)
                    {
                        A[PieceLocationI + 1, PieceLocationJ + 2] = 1;
                    }
                if (PieceLocationI - 1 < 8 && PieceLocationI - 1 >= 0 && PieceLocationJ - 2 < 8 && PieceLocationJ - 2 >= 0)
                    if (Positions[PieceLocationI - 1, PieceLocationJ - 2] <= 0)
                    {
                        A[PieceLocationI - 1, PieceLocationJ - 2] = 1;
                    }
                if (PieceLocationI + 1 < 8 && PieceLocationI + 1 >= 0 && PieceLocationJ - 2 < 8 && PieceLocationJ - 2 >= 0)
                    if (Positions[PieceLocationI + 1, PieceLocationJ - 2] <= 0)
                    {
                        A[PieceLocationI + 1, PieceLocationJ - 2] = 1;
                    }
            }
        }
        public void GetAvailableMovesWhiteKnight(Piece x)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (x.PieceColor == -1)
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
