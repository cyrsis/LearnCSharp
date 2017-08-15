namespace Delegate_Arithmetic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.del1Button = new System.Windows.Forms.Button();
            this.del2Button = new System.Windows.Forms.Button();
            this.del1MinusBButton = new System.Windows.Forms.Button();
            this.del1PlusDel2Button = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.del1MinusDel3Button = new System.Windows.Forms.Button();
            this.del1MinusDel2Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Del1: A B A B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Del2: A B C";
            // 
            // del1Button
            // 
            this.del1Button.Location = new System.Drawing.Point(19, 39);
            this.del1Button.Margin = new System.Windows.Forms.Padding(6);
            this.del1Button.Name = "del1Button";
            this.del1Button.Size = new System.Drawing.Size(138, 42);
            this.del1Button.TabIndex = 0;
            this.del1Button.Text = "Del1";
            this.del1Button.UseVisualStyleBackColor = true;
            this.del1Button.Click += new System.EventHandler(this.del1Button_Click);
            // 
            // del2Button
            // 
            this.del2Button.Location = new System.Drawing.Point(19, 93);
            this.del2Button.Margin = new System.Windows.Forms.Padding(6);
            this.del2Button.Name = "del2Button";
            this.del2Button.Size = new System.Drawing.Size(138, 42);
            this.del2Button.TabIndex = 1;
            this.del2Button.Text = "Del2";
            this.del2Button.UseVisualStyleBackColor = true;
            this.del2Button.Click += new System.EventHandler(this.del2Button_Click);
            // 
            // del1MinusBButton
            // 
            this.del1MinusBButton.Location = new System.Drawing.Point(19, 255);
            this.del1MinusBButton.Margin = new System.Windows.Forms.Padding(6);
            this.del1MinusBButton.Name = "del1MinusBButton";
            this.del1MinusBButton.Size = new System.Drawing.Size(138, 42);
            this.del1MinusBButton.TabIndex = 4;
            this.del1MinusBButton.Text = "Del1 - B";
            this.del1MinusBButton.UseVisualStyleBackColor = true;
            this.del1MinusBButton.Click += new System.EventHandler(this.del1MinusBButton_Click);
            // 
            // del1PlusDel2Button
            // 
            this.del1PlusDel2Button.Location = new System.Drawing.Point(19, 201);
            this.del1PlusDel2Button.Margin = new System.Windows.Forms.Padding(6);
            this.del1PlusDel2Button.Name = "del1PlusDel2Button";
            this.del1PlusDel2Button.Size = new System.Drawing.Size(138, 42);
            this.del1PlusDel2Button.TabIndex = 3;
            this.del1PlusDel2Button.Text = "Del1 + Del2";
            this.del1PlusDel2Button.UseVisualStyleBackColor = true;
            this.del1PlusDel2Button.Click += new System.EventHandler(this.del1PlusDel2Button_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.IntegralHeight = false;
            this.resultsListBox.ItemHeight = 24;
            this.resultsListBox.Location = new System.Drawing.Point(167, 39);
            this.resultsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(343, 366);
            this.resultsListBox.TabIndex = 7;
            // 
            // del1MinusDel3Button
            // 
            this.del1MinusDel3Button.Location = new System.Drawing.Point(19, 363);
            this.del1MinusDel3Button.Margin = new System.Windows.Forms.Padding(6);
            this.del1MinusDel3Button.Name = "del1MinusDel3Button";
            this.del1MinusDel3Button.Size = new System.Drawing.Size(138, 42);
            this.del1MinusDel3Button.TabIndex = 6;
            this.del1MinusDel3Button.Text = "Del1 - Del3";
            this.del1MinusDel3Button.UseVisualStyleBackColor = true;
            this.del1MinusDel3Button.Click += new System.EventHandler(this.del1MinusDel3Button_Click);
            // 
            // del1MinusDel2Button
            // 
            this.del1MinusDel2Button.Location = new System.Drawing.Point(19, 309);
            this.del1MinusDel2Button.Margin = new System.Windows.Forms.Padding(6);
            this.del1MinusDel2Button.Name = "del1MinusDel2Button";
            this.del1MinusDel2Button.Size = new System.Drawing.Size(138, 42);
            this.del1MinusDel2Button.TabIndex = 5;
            this.del1MinusDel2Button.Text = "Del1 - Del2";
            this.del1MinusDel2Button.UseVisualStyleBackColor = true;
            this.del1MinusDel2Button.Click += new System.EventHandler(this.del1MinusDel2Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Del3: A B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Del3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.del3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.del1MinusDel3Button);
            this.Controls.Add(this.del1MinusDel2Button);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.del1MinusBButton);
            this.Controls.Add(this.del1PlusDel2Button);
            this.Controls.Add(this.del2Button);
            this.Controls.Add(this.del1Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Delegate Arithmetic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del1Button;
        private System.Windows.Forms.Button del2Button;
        private System.Windows.Forms.Button del1MinusBButton;
        private System.Windows.Forms.Button del1PlusDel2Button;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button del1MinusDel3Button;
        private System.Windows.Forms.Button del1MinusDel2Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

