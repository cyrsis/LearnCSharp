namespace Event_Accessors
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
            this.raiseEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raiseEventButton
            // 
            this.raiseEventButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raiseEventButton.Location = new System.Drawing.Point(124, 59);
            this.raiseEventButton.Name = "raiseEventButton";
            this.raiseEventButton.Size = new System.Drawing.Size(136, 43);
            this.raiseEventButton.TabIndex = 1;
            this.raiseEventButton.Text = "Raise Event";
            this.raiseEventButton.UseVisualStyleBackColor = true;
            this.raiseEventButton.Click += new System.EventHandler(this.raiseEventButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.raiseEventButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Event Accessors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button raiseEventButton;
    }
}

