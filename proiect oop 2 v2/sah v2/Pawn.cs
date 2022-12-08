using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace sah_v2
{
    class Pawn : Piece
    {
        public const string bPawn = "C:/Users/uif31464/Desktop/chess/Chess_pdt60.png";
        public const string wPawn = "C:/Users/uif31464/Desktop/chess/Chess_plt60.png";

        public Pawn(int i, int j, int color)
        {
            this.PieceLocationI = i;
            this.PieceLocationJ = j;
            this.PieceColor = color;
        }

        public override void Move(object sender, EventArgs args)         
        {
            var button = sender as Piece;
            if (button.PieceColor == 1)
                GetAvailableMovesBlackPawn();
            if (button.PieceColor == -1)
                GetAvailableMovesWhitePawn();
            if (first_click)
            {
                if (button.Image == null)
                    return;
                firstB = button;
                //value = Positions[PieceLocationI, PieceLocationJ];
                //Positions[PieceLocationI, PieceLocationJ] = 0;
                first_click = false;
            }
            else
            {
                if (A[PieceLocationI, PieceLocationJ] == 1)
                {
                    button.Image = firstB.Image;
                    button.PieceColor = firstB.PieceColor;
                    button.type = firstB.type;
                    //Positions[PieceLocationI, PieceLocationJ] = value;
                    firstB.Image = null;
                    firstB.PieceColor = 0;
                    firstB.type=0;
                    //value = 0;
                }
                else
                    return;
                first_click = true;
            }
        }
        public void GetAvailableMovesBlackPawn()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == 1)
            {
                if (PieceLocationJ == 1 && Positions[PieceLocationI, PieceLocationJ + 2] == 0 && Positions[PieceLocationI, PieceLocationJ + 1] == 0)
                    A[PieceLocationI, PieceLocationJ + 2] = 1;

                if (Positions[PieceLocationI, PieceLocationJ + 1] == 0)
                    A[PieceLocationI, PieceLocationJ + 1] = 1;

                if (Positions[PieceLocationI - 1, PieceLocationJ +1] < 0)
                    A[PieceLocationI - 1, PieceLocationJ +1] = 1;

                if (Positions[PieceLocationI + 1, PieceLocationJ +1] < 0)
                    A[PieceLocationI + 1, PieceLocationJ +1] = 1;
            }
        }
        public void GetAvailableMovesWhitePawn()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    A[i, j] = 0;
            if (PieceColor == 0)
            {
                if (PieceLocationJ == 6 && Positions[PieceLocationI, PieceLocationJ - 2] == 0 && Positions[PieceLocationI, PieceLocationJ - 1] == 0)
                    A[PieceLocationI, PieceLocationJ - 2] = 1;

                if (Positions[PieceLocationI, PieceLocationJ - 1] == 0)
                    A[PieceLocationI, PieceLocationJ - 1] = 1;

                if (Positions[PieceLocationI - 1, PieceLocationJ - 1] > 0)
                    A[PieceLocationI - 1, PieceLocationJ - 1] = 1;

                if (Positions[PieceLocationI + 1, PieceLocationJ - 1] > 0)
                    A[PieceLocationI + 1, PieceLocationJ - 1] = 1;
            }
        }
    }
}
