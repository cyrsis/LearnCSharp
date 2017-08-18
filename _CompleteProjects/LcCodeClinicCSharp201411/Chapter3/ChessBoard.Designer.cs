using System.Windows.Forms;

namespace EightQueensProblem
{
	public partial class ChessBoard : System.Windows.Forms.UserControl
	{
		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DoubleBuffered = true;
			this.Name = "ChessBoard";
			this.Size = new System.Drawing.Size(560, 560);
			this.ResumeLayout(false);

			this.Paint += new PaintEventHandler(ChessBoard_Paint);
			this.Resize += new System.EventHandler(ChessBoard_Resize);
		}

	}

}