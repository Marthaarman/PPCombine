namespace PPCombine
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
            this.comboBox_PowerPoints = new System.Windows.Forms.ComboBox();
            this.groupBox_PowerPoints = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_PowerPoints_add = new System.Windows.Forms.Button();
            this.button_PowerPoints_moveUp = new System.Windows.Forms.Button();
            this.button_PowerPoints_moveDown = new System.Windows.Forms.Button();
            this.button_PowerPoints_delete = new System.Windows.Forms.Button();
            this.groupBox_slides = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_slides = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_slideGoTo = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label_version = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button_PowerPointStart = new System.Windows.Forms.Button();
            this.button_prevSlide = new System.Windows.Forms.Button();
            this.button_nextSlide = new System.Windows.Forms.Button();
            this.button_PowerPointStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label_currentPowerPoint = new System.Windows.Forms.Label();
            this.label_nextPowerPoint = new System.Windows.Forms.Label();
            this.label_currentSlide = new System.Windows.Forms.Label();
            this.label_nextSlide = new System.Windows.Forms.Label();
            this.label_currentPowerPointValue = new System.Windows.Forms.Label();
            this.label_currentSlideValue = new System.Windows.Forms.Label();
            this.label_nextSlideValue = new System.Windows.Forms.Label();
            this.label_nextPowerPointValue = new System.Windows.Forms.Label();
            this.groupBox_PowerPoints.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_slides.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_PowerPoints
            // 
            this.comboBox_PowerPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_PowerPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_PowerPoints.FormattingEnabled = true;
            this.comboBox_PowerPoints.Location = new System.Drawing.Point(3, 3);
            this.comboBox_PowerPoints.Name = "comboBox_PowerPoints";
            this.comboBox_PowerPoints.Size = new System.Drawing.Size(353, 261);
            this.comboBox_PowerPoints.TabIndex = 8;
            // 
            // groupBox_PowerPoints
            // 
            this.groupBox_PowerPoints.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_PowerPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PowerPoints.Location = new System.Drawing.Point(3, 3);
            this.groupBox_PowerPoints.Name = "groupBox_PowerPoints";
            this.groupBox_PowerPoints.Size = new System.Drawing.Size(485, 288);
            this.groupBox_PowerPoints.TabIndex = 9;
            this.groupBox_PowerPoints.TabStop = false;
            this.groupBox_PowerPoints.Text = "PowerPoints";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_PowerPoints, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button_PowerPoints_add, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_PowerPoints_moveUp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_PowerPoints_moveDown, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_PowerPoints_delete, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(362, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 261);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // button_PowerPoints_add
            // 
            this.button_PowerPoints_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPoints_add.Location = new System.Drawing.Point(3, 211);
            this.button_PowerPoints_add.Name = "button_PowerPoints_add";
            this.button_PowerPoints_add.Size = new System.Drawing.Size(108, 47);
            this.button_PowerPoints_add.TabIndex = 0;
            this.button_PowerPoints_add.Text = "Add PPTX";
            this.button_PowerPoints_add.UseVisualStyleBackColor = true;
            this.button_PowerPoints_add.Click += new System.EventHandler(this.button_PowerPoints_add_Click);
            // 
            // button_PowerPoints_moveUp
            // 
            this.button_PowerPoints_moveUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPoints_moveUp.Location = new System.Drawing.Point(3, 3);
            this.button_PowerPoints_moveUp.Name = "button_PowerPoints_moveUp";
            this.button_PowerPoints_moveUp.Size = new System.Drawing.Size(108, 46);
            this.button_PowerPoints_moveUp.TabIndex = 1;
            this.button_PowerPoints_moveUp.Text = "Move up";
            this.button_PowerPoints_moveUp.UseVisualStyleBackColor = true;
            this.button_PowerPoints_moveUp.Click += new System.EventHandler(this.button_PowerPoints_moveUp_Click);
            // 
            // button_PowerPoints_moveDown
            // 
            this.button_PowerPoints_moveDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPoints_moveDown.Location = new System.Drawing.Point(3, 55);
            this.button_PowerPoints_moveDown.Name = "button_PowerPoints_moveDown";
            this.button_PowerPoints_moveDown.Size = new System.Drawing.Size(108, 46);
            this.button_PowerPoints_moveDown.TabIndex = 2;
            this.button_PowerPoints_moveDown.Text = "Move down";
            this.button_PowerPoints_moveDown.UseVisualStyleBackColor = true;
            this.button_PowerPoints_moveDown.Click += new System.EventHandler(this.button_PowerPoints_moveDown_Click);
            // 
            // button_PowerPoints_delete
            // 
            this.button_PowerPoints_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPoints_delete.Location = new System.Drawing.Point(3, 159);
            this.button_PowerPoints_delete.Name = "button_PowerPoints_delete";
            this.button_PowerPoints_delete.Size = new System.Drawing.Size(108, 46);
            this.button_PowerPoints_delete.TabIndex = 3;
            this.button_PowerPoints_delete.Text = "Del. PPTX";
            this.button_PowerPoints_delete.UseVisualStyleBackColor = true;
            this.button_PowerPoints_delete.Click += new System.EventHandler(this.button_PowerPoints_delete_Click);
            // 
            // groupBox_slides
            // 
            this.groupBox_slides.Controls.Add(this.tableLayoutPanel3);
            this.groupBox_slides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_slides.Location = new System.Drawing.Point(545, 3);
            this.groupBox_slides.Name = "groupBox_slides";
            this.groupBox_slides.Size = new System.Drawing.Size(486, 288);
            this.groupBox_slides.TabIndex = 10;
            this.groupBox_slides.TabStop = false;
            this.groupBox_slides.Text = "Slides";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.comboBox_slides, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(480, 267);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // comboBox_slides
            // 
            this.comboBox_slides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_slides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_slides.FormattingEnabled = true;
            this.comboBox_slides.Location = new System.Drawing.Point(3, 3);
            this.comboBox_slides.Name = "comboBox_slides";
            this.comboBox_slides.Size = new System.Drawing.Size(354, 261);
            this.comboBox_slides.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button_slideGoTo, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(363, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(114, 261);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // button_slideGoTo
            // 
            this.button_slideGoTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_slideGoTo.Location = new System.Drawing.Point(3, 55);
            this.button_slideGoTo.Name = "button_slideGoTo";
            this.button_slideGoTo.Size = new System.Drawing.Size(108, 46);
            this.button_slideGoTo.TabIndex = 0;
            this.button_slideGoTo.Text = "Go To";
            this.button_slideGoTo.UseVisualStyleBackColor = true;
            this.button_slideGoTo.Click += new System.EventHandler(this.button_slideGoTo_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1040, 668);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox_slides, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox_PowerPoints, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1034, 294);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel9.Controls.Add(this.label_version, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label_author, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 603);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1034, 62);
            this.tableLayoutPanel9.TabIndex = 13;
            // 
            // label_version
            // 
            this.label_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(893, 11);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(86, 16);
            this.label_version.TabIndex = 0;
            this.label_version.Text = "Version: 1.0.0";
            // 
            // label_author
            // 
            this.label_author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(709, 38);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(270, 16);
            this.label_author.TabIndex = 1;
            this.label_author.Text = "https://github.com/Marthaarman/PPCombine";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1028, 273);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.button_PowerPointStop, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.button_nextSlide, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.button_prevSlide, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.button_PowerPointStart, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(517, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(508, 267);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // button_PowerPointStart
            // 
            this.button_PowerPointStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPointStart.Location = new System.Drawing.Point(3, 3);
            this.button_PowerPointStart.Name = "button_PowerPointStart";
            this.button_PowerPointStart.Size = new System.Drawing.Size(248, 127);
            this.button_PowerPointStart.TabIndex = 2;
            this.button_PowerPointStart.Text = "Start";
            this.button_PowerPointStart.UseVisualStyleBackColor = true;
            this.button_PowerPointStart.Click += new System.EventHandler(this.button_PowerPointStart_Click);
            // 
            // button_prevSlide
            // 
            this.button_prevSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_prevSlide.Location = new System.Drawing.Point(3, 136);
            this.button_prevSlide.Name = "button_prevSlide";
            this.button_prevSlide.Size = new System.Drawing.Size(248, 128);
            this.button_prevSlide.TabIndex = 1;
            this.button_prevSlide.Text = "Previous Slide";
            this.button_prevSlide.UseVisualStyleBackColor = true;
            this.button_prevSlide.Click += new System.EventHandler(this.button_prevSlide_Click);
            // 
            // button_nextSlide
            // 
            this.button_nextSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_nextSlide.Location = new System.Drawing.Point(257, 136);
            this.button_nextSlide.Name = "button_nextSlide";
            this.button_nextSlide.Size = new System.Drawing.Size(248, 128);
            this.button_nextSlide.TabIndex = 0;
            this.button_nextSlide.Text = "Next Slide";
            this.button_nextSlide.UseVisualStyleBackColor = true;
            this.button_nextSlide.Click += new System.EventHandler(this.button_nextSlide_Click);
            // 
            // button_PowerPointStop
            // 
            this.button_PowerPointStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPointStop.Location = new System.Drawing.Point(257, 3);
            this.button_PowerPointStop.Name = "button_PowerPointStop";
            this.button_PowerPointStop.Size = new System.Drawing.Size(248, 127);
            this.button_PowerPointStop.TabIndex = 3;
            this.button_PowerPointStop.Text = "Stop";
            this.button_PowerPointStop.UseVisualStyleBackColor = true;
            this.button_PowerPointStop.Click += new System.EventHandler(this.button_PowerPointStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 294);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.Controls.Add(this.label_currentPowerPoint, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label_nextPowerPoint, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label_currentSlide, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label_nextSlide, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.label_currentPowerPointValue, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label_currentSlideValue, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.label_nextSlideValue, 3, 1);
            this.tableLayoutPanel10.Controls.Add(this.label_nextPowerPointValue, 3, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(508, 267);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // label_currentPowerPoint
            // 
            this.label_currentPowerPoint.AutoSize = true;
            this.label_currentPowerPoint.Location = new System.Drawing.Point(3, 0);
            this.label_currentPowerPoint.Name = "label_currentPowerPoint";
            this.label_currentPowerPoint.Size = new System.Drawing.Size(120, 16);
            this.label_currentPowerPoint.TabIndex = 0;
            this.label_currentPowerPoint.Text = "Current PowerPoint";
            // 
            // label_nextPowerPoint
            // 
            this.label_nextPowerPoint.AutoSize = true;
            this.label_nextPowerPoint.Location = new System.Drawing.Point(257, 0);
            this.label_nextPowerPoint.Name = "label_nextPowerPoint";
            this.label_nextPowerPoint.Size = new System.Drawing.Size(105, 16);
            this.label_nextPowerPoint.TabIndex = 1;
            this.label_nextPowerPoint.Text = "Next PowerPoint";
            // 
            // label_currentSlide
            // 
            this.label_currentSlide.AutoSize = true;
            this.label_currentSlide.Location = new System.Drawing.Point(3, 133);
            this.label_currentSlide.Name = "label_currentSlide";
            this.label_currentSlide.Size = new System.Drawing.Size(83, 16);
            this.label_currentSlide.TabIndex = 2;
            this.label_currentSlide.Text = "Current Slide";
            // 
            // label_nextSlide
            // 
            this.label_nextSlide.AutoSize = true;
            this.label_nextSlide.Location = new System.Drawing.Point(257, 133);
            this.label_nextSlide.Name = "label_nextSlide";
            this.label_nextSlide.Size = new System.Drawing.Size(68, 16);
            this.label_nextSlide.TabIndex = 3;
            this.label_nextSlide.Text = "Next Slide";
            // 
            // label_currentPowerPointValue
            // 
            this.label_currentPowerPointValue.AutoSize = true;
            this.label_currentPowerPointValue.Location = new System.Drawing.Point(130, 0);
            this.label_currentPowerPointValue.Name = "label_currentPowerPointValue";
            this.label_currentPowerPointValue.Size = new System.Drawing.Size(11, 16);
            this.label_currentPowerPointValue.TabIndex = 4;
            this.label_currentPowerPointValue.Text = "-";
            // 
            // label_currentSlideValue
            // 
            this.label_currentSlideValue.AutoSize = true;
            this.label_currentSlideValue.Location = new System.Drawing.Point(130, 133);
            this.label_currentSlideValue.Name = "label_currentSlideValue";
            this.label_currentSlideValue.Size = new System.Drawing.Size(11, 16);
            this.label_currentSlideValue.TabIndex = 5;
            this.label_currentSlideValue.Text = "-";
            // 
            // label_nextSlideValue
            // 
            this.label_nextSlideValue.AutoSize = true;
            this.label_nextSlideValue.Location = new System.Drawing.Point(384, 133);
            this.label_nextSlideValue.Name = "label_nextSlideValue";
            this.label_nextSlideValue.Size = new System.Drawing.Size(11, 16);
            this.label_nextSlideValue.TabIndex = 6;
            this.label_nextSlideValue.Text = "-";
            // 
            // label_nextPowerPointValue
            // 
            this.label_nextPowerPointValue.AutoSize = true;
            this.label_nextPowerPointValue.Location = new System.Drawing.Point(384, 0);
            this.label_nextPowerPointValue.Name = "label_nextPowerPointValue";
            this.label_nextPowerPointValue.Size = new System.Drawing.Size(11, 16);
            this.label_nextPowerPointValue.TabIndex = 7;
            this.label_nextPowerPointValue.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 668);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "Form1";
            this.Text = "PPCombine";
            this.groupBox_PowerPoints.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox_slides.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_PowerPoints;
        private System.Windows.Forms.GroupBox groupBox_PowerPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_PowerPoints_add;
        private System.Windows.Forms.Button button_PowerPoints_moveUp;
        private System.Windows.Forms.Button button_PowerPoints_moveDown;
        private System.Windows.Forms.Button button_PowerPoints_delete;
        private System.Windows.Forms.GroupBox groupBox_slides;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBox_slides;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_slideGoTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label_currentPowerPoint;
        private System.Windows.Forms.Label label_nextPowerPoint;
        private System.Windows.Forms.Label label_currentSlide;
        private System.Windows.Forms.Label label_nextSlide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button_PowerPointStop;
        private System.Windows.Forms.Button button_nextSlide;
        private System.Windows.Forms.Button button_prevSlide;
        private System.Windows.Forms.Button button_PowerPointStart;
        private System.Windows.Forms.Label label_currentPowerPointValue;
        private System.Windows.Forms.Label label_currentSlideValue;
        private System.Windows.Forms.Label label_nextPowerPointValue;
        private System.Windows.Forms.Label label_nextSlideValue;
    }
}

