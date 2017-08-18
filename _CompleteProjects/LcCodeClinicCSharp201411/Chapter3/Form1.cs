using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace EightQueensProblem
{
	public partial class Form1
	{

		internal Form1()
		{
			InitializeComponent();
		}

		private ChessBoard cb = new ChessBoard();
		private int solutionNumber = 0;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.Show();
			cb.Dock = DockStyle.Fill;
			cb.GetSolutions();
			Panel1.Controls.Add(cb);
			Button1.BringToFront();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
            //Display the next solution
            cb.cells = cb.solutions[solutionNumber];
            cb.DrawBoard();
            Label1.Text = "Solution #" + (solutionNumber + 1);

            //Increment to the next solution, or restart at 0;
            solutionNumber++;
            if (solutionNumber == cb.solutions.Count)
			{
				solutionNumber = 0;
            }
		}

		private static Form1 _DefaultInstance;
		public static Form1 DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null)
					_DefaultInstance = new Form1();

				return _DefaultInstance;
			}
		}
	}
}