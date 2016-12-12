﻿namespace SolutionConverter
{
    /// <summary>
    /// Form1 class.
    /// </summary>
    public partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Open dialog control.
        /// </summary>
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        /// <summary>
        /// button1 on form.
        /// </summary>
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkVS2013 = new System.Windows.Forms.CheckBox();
            this.chkVS2012 = new System.Windows.Forms.CheckBox();
            this.chkVS2002 = new System.Windows.Forms.CheckBox();
            this.chkVS2003 = new System.Windows.Forms.CheckBox();
            this.chkVS2005 = new System.Windows.Forms.CheckBox();
            this.chkVS2008 = new System.Windows.Forms.CheckBox();
            this.chkVS2010 = new System.Windows.Forms.CheckBox();
            this.chkVS = new System.Windows.Forms.CheckBox();
            this.chkCsExp = new System.Windows.Forms.CheckBox();
            this.chkVbExp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rdoVS2013 = new System.Windows.Forms.RadioButton();
            this.rdoVS2012 = new System.Windows.Forms.RadioButton();
            this.rdoVS2002 = new System.Windows.Forms.RadioButton();
            this.rdoVS2003 = new System.Windows.Forms.RadioButton();
            this.rdoVS2005 = new System.Windows.Forms.RadioButton();
            this.rdoVS2008 = new System.Windows.Forms.RadioButton();
            this.rdoVS2010 = new System.Windows.Forms.RadioButton();
            this.rdoVS = new System.Windows.Forms.RadioButton();
            this.rdoCsExp = new System.Windows.Forms.RadioButton();
            this.rdoVbExp = new System.Windows.Forms.RadioButton();
            this.CurrentSolutionLbl = new System.Windows.Forms.Label();
            this.SolutionPathLbl = new System.Windows.Forms.Label();
            this.OpenFolderbtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Visual Studio Solution|*.sln";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(18, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开解决方案";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenSolution_Click);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertBtn.Location = new System.Drawing.Point(538, 468);
            this.ConvertBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(156, 35);
            this.ConvertBtn.TabIndex = 2;
            this.ConvertBtn.Text = "转换";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 420);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(330, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前版本";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chkVS2013);
            this.panel1.Controls.Add(this.chkVS2012);
            this.panel1.Controls.Add(this.chkVS2002);
            this.panel1.Controls.Add(this.chkVS2003);
            this.panel1.Controls.Add(this.chkVS2005);
            this.panel1.Controls.Add(this.chkVS2008);
            this.panel1.Controls.Add(this.chkVS2010);
            this.panel1.Controls.Add(this.chkVS);
            this.panel1.Controls.Add(this.chkCsExp);
            this.panel1.Controls.Add(this.chkVbExp);
            this.panel1.Location = new System.Drawing.Point(4, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 382);
            this.panel1.TabIndex = 0;
            // 
            // chkVS2013
            // 
            this.chkVS2013.AutoCheck = false;
            this.chkVS2013.AutoSize = true;
            this.chkVS2013.Location = new System.Drawing.Point(4, 220);
            this.chkVS2013.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS2013.Name = "chkVS2013";
            this.chkVS2013.Size = new System.Drawing.Size(168, 24);
            this.chkVS2013.TabIndex = 33;
            this.chkVS2013.Text = "Visual Studio 2013";
            this.chkVS2013.UseVisualStyleBackColor = true;
            // 
            // chkVS2012
            // 
            this.chkVS2012.AutoCheck = false;
            this.chkVS2012.AutoSize = true;
            this.chkVS2012.Location = new System.Drawing.Point(4, 183);
            this.chkVS2012.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS2012.Name = "chkVS2012";
            this.chkVS2012.Size = new System.Drawing.Size(168, 24);
            this.chkVS2012.TabIndex = 32;
            this.chkVS2012.Text = "Visual Studio 2012";
            this.chkVS2012.UseVisualStyleBackColor = true;
            // 
            // chkVS2002
            // 
            this.chkVS2002.AutoCheck = false;
            this.chkVS2002.AutoSize = true;
            this.chkVS2002.Location = new System.Drawing.Point(4, 5);
            this.chkVS2002.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS2002.Name = "chkVS2002";
            this.chkVS2002.Size = new System.Drawing.Size(168, 24);
            this.chkVS2002.TabIndex = 24;
            this.chkVS2002.Text = "Visual Studio 2002";
            this.chkVS2002.UseVisualStyleBackColor = true;
            // 
            // chkVS2003
            // 
            this.chkVS2003.AutoCheck = false;
            this.chkVS2003.AutoSize = true;
            this.chkVS2003.Location = new System.Drawing.Point(4, 40);
            this.chkVS2003.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS2003.Name = "chkVS2003";
            this.chkVS2003.Size = new System.Drawing.Size(168, 24);
            this.chkVS2003.TabIndex = 25;
            this.chkVS2003.Text = "Visual Studio 2003";
            this.chkVS2003.UseVisualStyleBackColor = true;
            // 
            // chkVS2005
            // 
            this.chkVS2005.AutoCheck = false;
            this.chkVS2005.AutoSize = true;
            this.chkVS2005.Location = new System.Drawing.Point(4, 75);
            this.chkVS2005.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS2005.Name = "chkVS2005";
            this.chkVS2005.Size = new System.Drawing.Size(168, 24);
            this.chkVS2005.TabIndex = 26;
            this.chkVS2005.Text = "Visual Studio 2005";
            this.chkVS2005.UseVisualStyleBackColor = true;
            // 
            // chkVS2008
            // 
            this.chkVS2008.AutoCheck = false;
            this.chkVS2008.AutoSize = true;
            this.chkVS2008.Location = new System.Drawing.Point(4, 110);
            this.chkVS2008.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS2008.Name = "chkVS2008";
            this.chkVS2008.Size = new System.Drawing.Size(168, 24);
            this.chkVS2008.TabIndex = 27;
            this.chkVS2008.Text = "Visual Studio 2008";
            this.chkVS2008.UseVisualStyleBackColor = true;
            // 
            // chkVS2010
            // 
            this.chkVS2010.AutoCheck = false;
            this.chkVS2010.AutoSize = true;
            this.chkVS2010.Location = new System.Drawing.Point(4, 147);
            this.chkVS2010.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS2010.Name = "chkVS2010";
            this.chkVS2010.Size = new System.Drawing.Size(168, 24);
            this.chkVS2010.TabIndex = 28;
            this.chkVS2010.Text = "Visual Studio 2010";
            this.chkVS2010.UseVisualStyleBackColor = true;
            // 
            // chkVS
            // 
            this.chkVS.AutoCheck = false;
            this.chkVS.AutoSize = true;
            this.chkVS.Location = new System.Drawing.Point(4, 272);
            this.chkVS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVS.Name = "chkVS";
            this.chkVS.Size = new System.Drawing.Size(196, 24);
            this.chkVS.TabIndex = 29;
            this.chkVS.Text = "Visual Studio 解决方案";
            this.chkVS.UseVisualStyleBackColor = true;
            // 
            // chkCsExp
            // 
            this.chkCsExp.AutoCheck = false;
            this.chkCsExp.AutoSize = true;
            this.chkCsExp.Location = new System.Drawing.Point(4, 307);
            this.chkCsExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCsExp.Name = "chkCsExp";
            this.chkCsExp.Size = new System.Drawing.Size(170, 24);
            this.chkCsExp.TabIndex = 30;
            this.chkCsExp.Text = "Visual C# 解决方案";
            this.chkCsExp.UseVisualStyleBackColor = true;
            // 
            // chkVbExp
            // 
            this.chkVbExp.AutoCheck = false;
            this.chkVbExp.AutoSize = true;
            this.chkVbExp.Location = new System.Drawing.Point(4, 343);
            this.chkVbExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkVbExp.Name = "chkVbExp";
            this.chkVbExp.Size = new System.Drawing.Size(189, 24);
            this.chkVbExp.TabIndex = 31;
            this.chkVbExp.Text = "Visual Basic 解决方案";
            this.chkVbExp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(342, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(330, 410);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出版本";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2013);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2012);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2002);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2003);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2005);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2008);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2010);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rdoVS);
            this.splitContainer1.Panel2.Controls.Add(this.rdoCsExp);
            this.splitContainer1.Panel2.Controls.Add(this.rdoVbExp);
            this.splitContainer1.Size = new System.Drawing.Size(322, 381);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // rdoVS2013
            // 
            this.rdoVS2013.AutoSize = true;
            this.rdoVS2013.Checked = true;
            this.rdoVS2013.Location = new System.Drawing.Point(4, 220);
            this.rdoVS2013.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS2013.Name = "rdoVS2013";
            this.rdoVS2013.Size = new System.Drawing.Size(167, 24);
            this.rdoVS2013.TabIndex = 10;
            this.rdoVS2013.TabStop = true;
            this.rdoVS2013.Text = "Visual Studio 2013";
            this.rdoVS2013.UseVisualStyleBackColor = true;
            // 
            // rdoVS2012
            // 
            this.rdoVS2012.AutoSize = true;
            this.rdoVS2012.Location = new System.Drawing.Point(4, 183);
            this.rdoVS2012.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS2012.Name = "rdoVS2012";
            this.rdoVS2012.Size = new System.Drawing.Size(167, 24);
            this.rdoVS2012.TabIndex = 9;
            this.rdoVS2012.Text = "Visual Studio 2012";
            this.rdoVS2012.UseVisualStyleBackColor = true;
            // 
            // rdoVS2002
            // 
            this.rdoVS2002.AutoSize = true;
            this.rdoVS2002.Enabled = false;
            this.rdoVS2002.Location = new System.Drawing.Point(4, 5);
            this.rdoVS2002.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS2002.Name = "rdoVS2002";
            this.rdoVS2002.Size = new System.Drawing.Size(167, 24);
            this.rdoVS2002.TabIndex = 6;
            this.rdoVS2002.Text = "Visual Studio 2002";
            this.rdoVS2002.UseVisualStyleBackColor = true;
            // 
            // rdoVS2003
            // 
            this.rdoVS2003.AutoSize = true;
            this.rdoVS2003.Enabled = false;
            this.rdoVS2003.Location = new System.Drawing.Point(4, 40);
            this.rdoVS2003.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS2003.Name = "rdoVS2003";
            this.rdoVS2003.Size = new System.Drawing.Size(167, 24);
            this.rdoVS2003.TabIndex = 5;
            this.rdoVS2003.Text = "Visual Studio 2003";
            this.rdoVS2003.UseVisualStyleBackColor = true;
            // 
            // rdoVS2005
            // 
            this.rdoVS2005.AutoSize = true;
            this.rdoVS2005.Location = new System.Drawing.Point(4, 75);
            this.rdoVS2005.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS2005.Name = "rdoVS2005";
            this.rdoVS2005.Size = new System.Drawing.Size(167, 24);
            this.rdoVS2005.TabIndex = 8;
            this.rdoVS2005.Text = "Visual Studio 2005";
            this.rdoVS2005.UseVisualStyleBackColor = true;
            // 
            // rdoVS2008
            // 
            this.rdoVS2008.AutoSize = true;
            this.rdoVS2008.Location = new System.Drawing.Point(4, 110);
            this.rdoVS2008.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS2008.Name = "rdoVS2008";
            this.rdoVS2008.Size = new System.Drawing.Size(167, 24);
            this.rdoVS2008.TabIndex = 7;
            this.rdoVS2008.Text = "Visual Studio 2008";
            this.rdoVS2008.UseVisualStyleBackColor = true;
            // 
            // rdoVS2010
            // 
            this.rdoVS2010.AutoSize = true;
            this.rdoVS2010.Location = new System.Drawing.Point(4, 147);
            this.rdoVS2010.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS2010.Name = "rdoVS2010";
            this.rdoVS2010.Size = new System.Drawing.Size(167, 24);
            this.rdoVS2010.TabIndex = 2;
            this.rdoVS2010.Text = "Visual Studio 2010";
            this.rdoVS2010.UseVisualStyleBackColor = true;
            // 
            // rdoVS
            // 
            this.rdoVS.AutoSize = true;
            this.rdoVS.Checked = true;
            this.rdoVS.Location = new System.Drawing.Point(4, 10);
            this.rdoVS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVS.Name = "rdoVS";
            this.rdoVS.Size = new System.Drawing.Size(195, 24);
            this.rdoVS.TabIndex = 5;
            this.rdoVS.TabStop = true;
            this.rdoVS.Text = "Visual Studio 解决方案";
            this.rdoVS.UseVisualStyleBackColor = true;
            // 
            // rdoCsExp
            // 
            this.rdoCsExp.AutoSize = true;
            this.rdoCsExp.Location = new System.Drawing.Point(4, 47);
            this.rdoCsExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoCsExp.Name = "rdoCsExp";
            this.rdoCsExp.Size = new System.Drawing.Size(169, 24);
            this.rdoCsExp.TabIndex = 7;
            this.rdoCsExp.Text = "Visual C# 解决方案";
            this.rdoCsExp.UseVisualStyleBackColor = true;
            // 
            // rdoVbExp
            // 
            this.rdoVbExp.AutoSize = true;
            this.rdoVbExp.Location = new System.Drawing.Point(4, 82);
            this.rdoVbExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoVbExp.Name = "rdoVbExp";
            this.rdoVbExp.Size = new System.Drawing.Size(188, 24);
            this.rdoVbExp.TabIndex = 6;
            this.rdoVbExp.Text = "Visual Basic 解决方案";
            this.rdoVbExp.UseVisualStyleBackColor = true;
            // 
            // CurrentSolutionLbl
            // 
            this.CurrentSolutionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentSolutionLbl.AutoSize = true;
            this.CurrentSolutionLbl.Enabled = false;
            this.CurrentSolutionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSolutionLbl.Location = new System.Drawing.Point(22, 10);
            this.CurrentSolutionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentSolutionLbl.Name = "CurrentSolutionLbl";
            this.CurrentSolutionLbl.Size = new System.Drawing.Size(135, 20);
            this.CurrentSolutionLbl.TabIndex = 5;
            this.CurrentSolutionLbl.Text = "当前解决方案：";
            // 
            // SolutionPathLbl
            // 
            this.SolutionPathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SolutionPathLbl.AutoEllipsis = true;
            this.SolutionPathLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SolutionPathLbl.Enabled = false;
            this.SolutionPathLbl.Location = new System.Drawing.Point(182, 10);
            this.SolutionPathLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SolutionPathLbl.Name = "SolutionPathLbl";
            this.SolutionPathLbl.Size = new System.Drawing.Size(504, 23);
            this.SolutionPathLbl.TabIndex = 6;
            this.SolutionPathLbl.Text = "不可用/不适用";
            // 
            // OpenFolderbtn
            // 
            this.OpenFolderbtn.Location = new System.Drawing.Point(187, 471);
            this.OpenFolderbtn.Name = "OpenFolderbtn";
            this.OpenFolderbtn.Size = new System.Drawing.Size(97, 32);
            this.OpenFolderbtn.TabIndex = 7;
            this.OpenFolderbtn.Text = "OpenFolderbtn";
            this.OpenFolderbtn.UseVisualStyleBackColor = true;
            this.OpenFolderbtn.Click += new System.EventHandler(this.OpenFolderbtn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 523);
            this.Controls.Add(this.OpenFolderbtn);
            this.Controls.Add(this.SolutionPathLbl);
            this.Controls.Add(this.CurrentSolutionLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VS版本转换器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rdoVS2002;
        private System.Windows.Forms.RadioButton rdoVS2003;
        private System.Windows.Forms.RadioButton rdoVS2005;
        private System.Windows.Forms.RadioButton rdoVS2008;
        private System.Windows.Forms.RadioButton rdoVS2010;
        private System.Windows.Forms.RadioButton rdoVS;
        private System.Windows.Forms.RadioButton rdoCsExp;
        private System.Windows.Forms.RadioButton rdoVbExp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkVS2002;
        private System.Windows.Forms.CheckBox chkVS2003;
        private System.Windows.Forms.CheckBox chkVS2005;
        private System.Windows.Forms.CheckBox chkVS2008;
        private System.Windows.Forms.CheckBox chkVS2010;
        private System.Windows.Forms.CheckBox chkVS;
        private System.Windows.Forms.CheckBox chkCsExp;
        private System.Windows.Forms.CheckBox chkVbExp;
        private System.Windows.Forms.Label CurrentSolutionLbl;
        private System.Windows.Forms.Label SolutionPathLbl;
        private System.Windows.Forms.CheckBox chkVS2013;
        private System.Windows.Forms.CheckBox chkVS2012;
        private System.Windows.Forms.RadioButton rdoVS2013;
        private System.Windows.Forms.RadioButton rdoVS2012;
        private System.Windows.Forms.Button OpenFolderbtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

