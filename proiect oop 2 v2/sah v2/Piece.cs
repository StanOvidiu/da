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
        public int PieceColor; //Tag
        public int PieceLocationI;
        public int PieceLocationJ;
        public int ye;
        public int type;

        //values: 1=pawn,2=knight,3=bishop,4=rook,5=queen,6=king
        //colors: 1=black,0=empty,-1=white
        protected static int[,] A = new int[8, 8];
        public static int[,] Positions = { { 4, 1, 0, 0, 0, 0, -1, -4 }, { 2, 1, 0, 0, 0, 0, -1, -2 }, { 3, 1, 0, 0, 0, 0, -1, -3 }, { 5, 1, 0, 0, 0, 0, -1, -5 }, { 6, 1, 0, 0, 0, 0, -1, -6 }, { 3, 1, 0, 0, 0, 0, -1, -3 }, { 2, 1, 0, 0, 0, 0, -1, -2 }, { 4, 1, 0, 0, 0, 0, -1, -4 } };
        
        protected static bool first_click = true;
        protected static Piece firstB = null;
        protected static int value;

        public Piece()
        {

        }
        public Piece(int i,int j,int color)
        {
            this.PieceLocationI = i;
            this.PieceLocationJ = j;
            this.PieceColor = color;
            this.type = Positions[PieceLocationI, PieceLocationJ];
        }

        public virtual void Move(object sender, EventArgs args)
        {
            
        }
    }
}
