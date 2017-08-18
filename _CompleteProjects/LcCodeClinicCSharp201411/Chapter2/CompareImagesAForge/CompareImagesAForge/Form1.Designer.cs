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
            this.largeLink = new System.Windows.Forms.LinkLabel();
            this.smallLink = new System.Windows.Forms.LinkLabel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.largePicBox = new System.Windows.Forms.PictureBox();
            this.outputMessage = new System.Windows.Forms.Label();
            this.smallPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.largeLink.AutoSize = true;
            this.largeLink.Location = new System.Drawing.Point(12, 13);
            this.largeLink.Name = "linkLabel1";
            this.largeLink.Size = new System.Drawing.Size(94, 13);
            this.largeLink.TabIndex = 0;
            this.largeLink.TabStop = true;
            this.largeLink.Text = "Select large image";
            this.largeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLarge_Clicked);
            // 
            // linkLabel2
            // 
            this.smallLink.AutoSize = true;
            this.smallLink.Location = new System.Drawing.Point(12, 35);
            this.smallLink.Name = "linkLabel2";
            this.smallLink.Size = new System.Drawing.Size(94, 13);
            this.smallLink.TabIndex = 1;
            this.smallLink.TabStop = true;
            this.smallLink.Text = "Select small image";
            this.smallLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSmall_Clicked);
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
            this.outputMessage.Location = new System.Drawing.Point(12, 288);
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
            this.ClientSize = new System.Drawing.Size(442, 325);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.smallPicBox);
            this.Controls.Add(this.largePicBox);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.smallLink);
            this.Controls.Add(this.largeLink);
            this.Name = "Form1";
            this.Text = "Compare Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel largeLink;
        private System.Windows.Forms.LinkLabel smallLink;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.PictureBox largePicBox;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.PictureBox smallPicBox;
    }
}

