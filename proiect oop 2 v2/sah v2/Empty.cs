using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sah_v2
{
    class Empty:Piece
    {
        public Empty(int i, int j)
        {
            this.PieceLocationI = i;
            this.PieceLocationJ = j;
            this.PieceColor = 0;
            this.type = 0;
        }

        public override void Move(object sender, EventArgs args)
        {
            var button = sender as Piece;
            if (first_click)
            {
                return;
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
    }
}
