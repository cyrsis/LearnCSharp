using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using EightQueensProblem.Properties;

namespace EightQueensProblem
{
	public partial class ChessBoard
	{
		private Graphics graphics;
		private Bitmap backgroundBmp;
		private bool[,] mCells = new bool[8, 8];
		private List<Queen> Queens = new List<Queen>();
		private List<bool[,]> mSolutions = new List<bool[,]>();

		public bool[,] cells
		{
			get
			{
				return mCells;
			}
			set
			{
				mCells = value;
			}
		}

		public List<bool[,]> solutions
		{
			get
			{
				return mSolutions;
			}
			set
			{
				mSolutions = value;
			}
		}

		public ChessBoard()
		{
			InitializeComponent();
			DrawBoard();
		}

		private void ChessBoard_Paint(object sender, PaintEventArgs e)
		{
			if (backgroundBmp != null)
			{
				this.BackgroundImage = backgroundBmp;
			}
		}

		private void ChessBoard_Resize(object sender, System.EventArgs e)
		{
			if (backgroundBmp != null)
			{
				DrawBoard();
			}
		}

		public void DrawBoard()
		{
			if (this.Width > 0 && this.Height > 0)
			{
				backgroundBmp = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppPArgb);
				graphics = Graphics.FromImage(backgroundBmp);

                Bitmap board = new Bitmap(Resources.ChessBoard);
                graphics.DrawImage(board, new Rectangle(0, 0, this.Width, this.Height));

				RectangleF rect = new RectangleF();
				bool flip = true;
				for (float i = 0F; i <= 7F; i++)
				{
					for (float j = 0F; j <= 7F; j++)
					{
                        if (mCells[Convert.ToInt32(i), Convert.ToInt32(j)])
						{
                            rect = new RectangleF(
                                j * Convert.ToSingle(backgroundBmp.Width / 8.0),
                                i * Convert.ToSingle(backgroundBmp.Height / 8.0),
                                Convert.ToSingle(backgroundBmp.Width / 8.0),
                                Convert.ToSingle(backgroundBmp.Height / 8.0));
                            Bitmap bitmap = new Bitmap(EightQueensProblem.Properties.Resources.QueenImage);
                            graphics.DrawImage(bitmap, rect);
						}
					}
				}
				this.Invalidate();
			}
		}

		public void ResetCells()
		{
			for (byte i = 0; i <= 7; i++)
			{
				for (byte j = 0; j <= 7; j++)
				{
					mCells[i, j] = false;
				}
			}
		}

        //Called when trying to place a queen
        //Boolean return value indicates whether it's a valid placement
		private bool CheckAll(int Level)
		{
			for (int i = Level; i >= 0; i--)
			{
				for (int j = i - 1; j >= 0; j--)
				{
					if (Queens[i].Row    == Queens[j].Row    ||     //on same row
                        Queens[i].Column == Queens[j].Column ||     //in same column
                        Queens[i].Row + Queens[i].Column ==         //on diagonal
                          Queens[j].Row + Queens[j].Column |
                        Queens[i].Row - Queens[j].Row == 
                          Queens[i].Column - Queens[j].Column)
					{
						return false;
					}
				}
			}
			return true;
		}

		private void PlaceQueen(int Level)
		{
            //Only called on 8th iteration
			if (Level > 7)
			{
				for (int j = 0; j <= 7; j++)
				{
					for (int i = 0; i <= 7; i++)
					{
						if ((Queens[j].Row == j) && (Queens[j].Column == i))
						{
							mCells[i, j] = true;
						}
						else
						{
							mCells[i, j] = false;
						}
					}
				}
                bool[,] clonedCells = (bool[,])mCells.Clone();
				solutions.Add(clonedCells);
				return;
			}

            //Called from beginning
            //Loop through the rows, placing the first queen in the first column of each row
			for (int j = 0; j <= 7; j++)
			{
				if (Level < 8)
				{
					Queens[Level].Row = Level;
					Queens[Level].Column = j;
					if (CheckAll(Level))
					{
                        //Recursive call to place the next queen
						PlaceQueen(Level + 1);
					}
				}
			}
		}

        //Called upon application startup
		public void GetSolutions()
		{
			Queens.Clear();
			ResetCells();
			DrawBoard();
			for (int j = 0; j <= 7; j++)
			{
				Queens.Add(new Queen());
			}
			for (int i = 0; i <= 7; i++)
			{
				Queens[0].Row = 0;
				Queens[0].Column = i;
				PlaceQueen(1);
			}
		}
	}
}