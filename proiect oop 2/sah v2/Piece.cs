using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sah_v2
{
    class Piece : Button
    {
        //values: 1=pawn,2=knight,3=bishop,4=rook,5=queen,6=king
        //colors: 1=black,0=empty,-1=white
        protected int[,] A = new int[8, 8];
        protected int[,] Positions = { { 4, 2, 3, 5, 6, 3, 2, 4 },{ 1, 1, 1, 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -4, -2, -3, -5, -6, -3, -2, -4 } };

        public int PieceColor; //Tag
        public int PieceLocationI;
        public int PieceLocationJ;

        public bool first_click = true;
        public Piece firstB = null;
        public int value;

        public int ye;

        public Piece()
        {

        }
        public Piece(int i,int j,int color)
        {
            this.PieceLocationI = i;
            this.PieceLocationJ = j;
            this.PieceColor = color;
        }

        public virtual void Move(object sender, EventArgs args)
        {

        }
        public void GetPiece(object sender, EventArgs args)
        {
            var button = sender as Piece;
            if(first_click)
                ye = button.Positions[PieceLocationI, PieceLocationJ];
        }
    }
}
