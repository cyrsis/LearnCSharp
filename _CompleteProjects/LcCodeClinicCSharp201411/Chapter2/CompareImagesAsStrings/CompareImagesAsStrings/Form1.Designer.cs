namespace FileComparerWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.largeLabel = new System.Windows.Forms.LinkLabel();
            this.smallLabel = new System.Windows.Forms.LinkLabel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.largePicBox = new System.Windows.Forms.PictureBox();
            this.outputMessage = new System.Windows.Forms.Label();
            this.smallPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.largeLabel.AutoSize = true;
            this.largeLabel.Location = new System.Drawing.Point(12, 13);
            this.largeLabel.Name = "linkLabel1";
            this.largeLabel.Size = new System.Drawing.Size(94, 13);
            this.largeLabel.TabIndex = 0;
            this.largeLabel.TabStop = true;
            this.largeLabel.Text = "Select large image";
            this.largeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLarge_Clicked);
            // 
            // linkLabel2
            // 
            this.smallLabel.AutoSize = true;
            this.smallLabel.Location = new System.Drawing.Point(12, 35);
            this.smallLabel.Name = "linkLabel2";
            this.smallLabel.Size = new System.Drawing.Size(94, 13);
            this.smallLabel.TabIndex = 1;
            this.smallLabel.TabStop = true;
            this.smallLabel.Text = "Select small image";
            this.smallLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSmall_Clicked);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 63);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(115, 23);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare images";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 347);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(405, 23);
            this.progressBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.largePicBox.Location = new System.Drawing.Point(12, 94);
            this.largePicBox.Name = "pictureBox1";
            this.largePicBox.Size = new System.Drawing.Size(186, 191);
            this.largePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePicBox.TabIndex = 4;
            this.largePicBox.TabStop = false;
            // 
            // outputMessage
            // 
            this.outputMessage.AutoSize = true;
            this.outputMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessage.Location = new System.Drawing.Point(11, 290);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(263, 24);
            this.outputMessage.TabIndex = 5;
            this.outputMessage.Text = "Your result will be shown here";
            // 
            // pictureBox2
            // 
            this.smallPicBox.Location = new System.Drawing.Point(231, 94);
            this.smallPicBox.Name = "pictureBox2";
            this.smallPicBox.Size = new System.Drawing.Size(186, 191);
            this.smallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smallPicBox.TabIndex = 4;
            this.smallPicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 382);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.smallPicBox);
            this.Controls.Add(this.largePicBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.smallLabel);
            this.Controls.Add(this.largeLabel);
            this.Name = "Form1";
            this.Text = "Compare Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel largeLabel;
        private System.Windows.Forms.LinkLabel smallLabel;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox largePicBox;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.PictureBox smallPicBox;
    }
}

