namespace Non_Default_Event_Handlers
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
            this.clickMeButton = new System.Windows.Forms.Button();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.circlePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clickMeButton
            // 
            this.clickMeButton.Location = new System.Drawing.Point(12, 12);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(120, 50);
            this.clickMeButton.TabIndex = 0;
            this.clickMeButton.Text = "Click Me";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.MouseEnter += new System.EventHandler(this.clickMeButton_MouseEnter);
            this.clickMeButton.MouseLeave += new System.EventHandler(this.clickMeButton_MouseLeave);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(12, 126);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(70, 30);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            this.redRadioButton.Click += new System.EventHandler(this.redRadioButton_Click);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(12, 162);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(90, 30);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.Click += new System.EventHandler(this.redRadioButton_Click);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(12, 198);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(74, 30);
            this.blueRadioButton.TabIndex = 3;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.Click += new System.EventHandler(this.redRadioButton_Click);
            // 
            // circlePictureBox
            // 
            this.circlePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circlePictureBox.BackColor = System.Drawing.Color.White;
            this.circlePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.circlePictureBox.Location = new System.Drawing.Point(108, 126);
            this.circlePictureBox.Name = "circlePictureBox";
            this.circlePictureBox.Size = new System.Drawing.Size(242, 145);
            this.circlePictureBox.TabIndex = 4;
            this.circlePictureBox.TabStop = false;
            this.circlePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.circlePictureBox_Paint);
            this.circlePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circlePictureBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 283);
            this.Controls.Add(this.circlePictureBox);
            this.Controls.Add(this.blueRadioButton);
            this.Controls.Add(this.greenRadioButton);
            this.Controls.Add(this.redRadioButton);
            this.Controls.Add(this.clickMeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Non Default Event Handlers";
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.PictureBox circlePictureBox;
    }
}

