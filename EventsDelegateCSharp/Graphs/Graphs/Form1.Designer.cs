namespace Graphs
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
            this.sineRadioButton = new System.Windows.Forms.RadioButton();
            this.quadraticRadioButton = new System.Windows.Forms.RadioButton();
            this.cubicRadioButton = new System.Windows.Forms.RadioButton();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.logisticRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sineRadioButton
            // 
            this.sineRadioButton.AutoSize = true;
            this.sineRadioButton.Location = new System.Drawing.Point(15, 15);
            this.sineRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.sineRadioButton.Name = "sineRadioButton";
            this.sineRadioButton.Size = new System.Drawing.Size(74, 30);
            this.sineRadioButton.TabIndex = 0;
            this.sineRadioButton.TabStop = true;
            this.sineRadioButton.Text = "Sine";
            this.sineRadioButton.UseVisualStyleBackColor = true;
            this.sineRadioButton.Click += new System.EventHandler(this.sineRadioButton_Click);
            // 
            // quadraticRadioButton
            // 
            this.quadraticRadioButton.AutoSize = true;
            this.quadraticRadioButton.Location = new System.Drawing.Point(15, 59);
            this.quadraticRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.quadraticRadioButton.Name = "quadraticRadioButton";
            this.quadraticRadioButton.Size = new System.Drawing.Size(124, 30);
            this.quadraticRadioButton.TabIndex = 1;
            this.quadraticRadioButton.TabStop = true;
            this.quadraticRadioButton.Text = "Quadratic";
            this.quadraticRadioButton.UseVisualStyleBackColor = true;
            this.quadraticRadioButton.Click += new System.EventHandler(this.quadraticRadioButton_Click);
            // 
            // cubicRadioButton
            // 
            this.cubicRadioButton.AutoSize = true;
            this.cubicRadioButton.Location = new System.Drawing.Point(15, 104);
            this.cubicRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.cubicRadioButton.Name = "cubicRadioButton";
            this.cubicRadioButton.Size = new System.Drawing.Size(86, 30);
            this.cubicRadioButton.TabIndex = 2;
            this.cubicRadioButton.TabStop = true;
            this.cubicRadioButton.Text = "Cubic";
            this.cubicRadioButton.UseVisualStyleBackColor = true;
            this.cubicRadioButton.Click += new System.EventHandler(this.cubicRadioButton_Click);
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BackColor = System.Drawing.Color.White;
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphPictureBox.Location = new System.Drawing.Point(151, 15);
            this.graphPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(256, 256);
            this.graphPictureBox.TabIndex = 3;
            this.graphPictureBox.TabStop = false;
            // 
            // logisticRadioButton
            // 
            this.logisticRadioButton.AutoSize = true;
            this.logisticRadioButton.Location = new System.Drawing.Point(15, 148);
            this.logisticRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.logisticRadioButton.Name = "logisticRadioButton";
            this.logisticRadioButton.Size = new System.Drawing.Size(104, 30);
            this.logisticRadioButton.TabIndex = 4;
            this.logisticRadioButton.TabStop = true;
            this.logisticRadioButton.Text = "Logistic";
            this.logisticRadioButton.UseVisualStyleBackColor = true;
            this.logisticRadioButton.Click += new System.EventHandler(this.logisticRadioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 283);
            this.Controls.Add(this.logisticRadioButton);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.cubicRadioButton);
            this.Controls.Add(this.quadraticRadioButton);
            this.Controls.Add(this.sineRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sineRadioButton;
        private System.Windows.Forms.RadioButton quadraticRadioButton;
        private System.Windows.Forms.RadioButton cubicRadioButton;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.RadioButton logisticRadioButton;
    }
}

