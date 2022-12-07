using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sah_v2
{
    public partial class Form1 : Form
    {
        Piece[,] pieces = new Piece[8, 8];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            var clr1 = Color.AntiqueWhite;
            var clr2 = Color.Peru;
            const int buttonSize = 80;

            this.Width = 657;
            this.Height = 680;
            this.Text = "chess";

            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    pieces[i, j] = new Piece(i, j, 2)
                    {
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(buttonSize * i, buttonSize * j),
                        FlatStyle = FlatStyle.Flat
                    };
                    this.Controls.Add(pieces[i, j]);
                    if (j == 0 || j == 1)
                    {
                        pieces[i, j].PieceColor = 1;
                    }
                    else if (j == 6 || j == 7)
                    {
                        pieces[i, j].PieceColor = -1;
                    }
                    else
                        pieces[i, j].PieceColor = 0;
                    if ((i + j) % 2 == 0)
                    {
                        pieces[i,j].BackColor = clr1;
                    }
                    else
                    {
                        pieces[i,j].BackColor = clr2;
                    }


                    pieces[i, j].Click += new EventHandler(pieces[i, j].GetPiece);
                    if (pieces[i, j].ye == 1 || pieces[i, j].ye == -1)
                    {
                        var x = new Pawn(pieces[i, j].PieceLocationI, pieces[i, j].PieceLocationJ, pieces[i, j].PieceColor);
                        pieces[i, j].Click += new EventHandler(x.Move);
                    }
                    else if (pieces[i, j].ye == 2 || pieces[i, j].ye == -2)
                    {
                        var x = new Knight();
                        pieces[i, j].Click += new EventHandler(x.Move);
                    }
                    else if (pieces[i, j].ye == 3 || pieces[i, j].ye == -3)
                    {
                        var x = new Bishop();
                        pieces[i, j].Click += new EventHandler(x.Move);
                    }
                    else if (pieces[i, j].ye == 4 || pieces[i, j].ye == -4)
                    {
                        var x = new Rook();
                        pieces[i, j].Click += new EventHandler(x.Move);
                    }
                    else if (pieces[i, j].ye == 5 || pieces[i, j].ye == -5)
                    {
                        var x = new Queen();
                        pieces[i, j].Click += new EventHandler(x.Move);
                    }
                    else if (pieces[i, j].ye == 6 || pieces[i, j].ye == -6)
                    {
                        var x = new King();
                        pieces[i, j].Click += new EventHandler(x.Move);
                    }
                    //pieces[i, j].Click += new EventHandler(pieces[i,j].Move);
                    //values: 1=pawn,2=knight,3=bishop,4=rook,5=queen,6=king
                }
            }
            SetImage(pieces);
        }
        public void SetImage(Button[,] A)
        {
            A[0, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_rdt60.png");
            A[1, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_ndt60.png");
            A[2, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_bdt60.png");
            A[3, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_qdt60.png");
            A[4, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_kdt60.png");
            A[5, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_bdt60.png");
            A[6, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_ndt60.png");
            A[7, 0].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_rdt60.png");
            A[0, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[1, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[2, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[3, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[4, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[5, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[6, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[7, 1].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_pdt60.png");
            A[0, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_rlt60.png");
            A[1, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_nlt60.png");
            A[2, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_blt60.png");
            A[3, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_qlt60.png");
            A[4, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_klt60.png");
            A[5, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_blt60.png");
            A[6, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_nlt60.png");
            A[7, 7].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_rlt60.png");
            A[0, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
            A[1, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
            A[2, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
            A[3, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
            A[4, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
            A[5, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
            A[6, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
            A[7, 6].Image = Image.FromFile("C:/Users/stano/OneDrive/Desktop/New folder/Chess_plt60.png");
        } 
    }
}
