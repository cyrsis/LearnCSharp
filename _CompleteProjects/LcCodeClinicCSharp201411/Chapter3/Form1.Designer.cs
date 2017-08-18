
namespace EightQueensProblem
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form1 : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Button1.Location = new System.Drawing.Point(12, 578);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(105, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Next Solution";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(560, 560);
            this.Panel1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Maroon;
            this.Label1.Location = new System.Drawing.Point(150, 583);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(175, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Click to show 1 of 92 solutions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 606);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8 Queens Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;

	}

}