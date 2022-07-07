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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_PowerPoints.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_slides.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_PowerPoints
            // 
            this.comboBox_PowerPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_PowerPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_PowerPoints.FormattingEnabled = true;
            this.comboBox_PowerPoints.Location = new System.Drawing.Point(3, 3);
            this.comboBox_PowerPoints.Name = "comboBox_PowerPoints";
            this.comboBox_PowerPoints.Size = new System.Drawing.Size(353, 295);
            this.comboBox_PowerPoints.TabIndex = 8;
            // 
            // groupBox_PowerPoints
            // 
            this.groupBox_PowerPoints.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_PowerPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PowerPoints.Location = new System.Drawing.Point(3, 3);
            this.groupBox_PowerPoints.Name = "groupBox_PowerPoints";
            this.groupBox_PowerPoints.Size = new System.Drawing.Size(485, 322);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 301);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 295);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // button_PowerPoints_add
            // 
            this.button_PowerPoints_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPoints_add.Location = new System.Drawing.Point(3, 239);
            this.button_PowerPoints_add.Name = "button_PowerPoints_add";
            this.button_PowerPoints_add.Size = new System.Drawing.Size(108, 53);
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
            this.button_PowerPoints_moveUp.Size = new System.Drawing.Size(108, 53);
            this.button_PowerPoints_moveUp.TabIndex = 1;
            this.button_PowerPoints_moveUp.Text = "Move up";
            this.button_PowerPoints_moveUp.UseVisualStyleBackColor = true;
            this.button_PowerPoints_moveUp.Click += new System.EventHandler(this.button_PowerPoints_moveUp_Click);
            // 
            // button_PowerPoints_moveDown
            // 
            this.button_PowerPoints_moveDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPoints_moveDown.Location = new System.Drawing.Point(3, 62);
            this.button_PowerPoints_moveDown.Name = "button_PowerPoints_moveDown";
            this.button_PowerPoints_moveDown.Size = new System.Drawing.Size(108, 53);
            this.button_PowerPoints_moveDown.TabIndex = 2;
            this.button_PowerPoints_moveDown.Text = "Move down";
            this.button_PowerPoints_moveDown.UseVisualStyleBackColor = true;
            this.button_PowerPoints_moveDown.Click += new System.EventHandler(this.button_PowerPoints_moveDown_Click);
            // 
            // button_PowerPoints_delete
            // 
            this.button_PowerPoints_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PowerPoints_delete.Location = new System.Drawing.Point(3, 180);
            this.button_PowerPoints_delete.Name = "button_PowerPoints_delete";
            this.button_PowerPoints_delete.Size = new System.Drawing.Size(108, 53);
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
            this.groupBox_slides.Size = new System.Drawing.Size(486, 322);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(480, 301);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // comboBox_slides
            // 
            this.comboBox_slides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_slides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_slides.FormattingEnabled = true;
            this.comboBox_slides.Location = new System.Drawing.Point(3, 3);
            this.comboBox_slides.Name = "comboBox_slides";
            this.comboBox_slides.Size = new System.Drawing.Size(354, 295);
            this.comboBox_slides.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(363, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(114, 295);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "Go To";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 328);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1034, 328);
            this.tableLayoutPanel6.TabIndex = 12;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

