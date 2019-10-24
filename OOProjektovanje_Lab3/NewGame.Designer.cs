namespace OOProjektovanje_Lab3
{
    partial class NewGame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbnDefault = new System.Windows.Forms.RadioButton();
            this.rbnOther = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numMines = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMines)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(224, 195);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(64, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbnDefault
            // 
            this.rbnDefault.AutoSize = true;
            this.rbnDefault.Checked = true;
            this.rbnDefault.Location = new System.Drawing.Point(26, 20);
            this.rbnDefault.Name = "rbnDefault";
            this.rbnDefault.Size = new System.Drawing.Size(74, 21);
            this.rbnDefault.TabIndex = 2;
            this.rbnDefault.TabStop = true;
            this.rbnDefault.Text = "Default";
            this.rbnDefault.UseVisualStyleBackColor = true;
            this.rbnDefault.CheckedChanged += new System.EventHandler(this.rbnDefault_CheckedChanged);
            // 
            // rbnOther
            // 
            this.rbnOther.AutoSize = true;
            this.rbnOther.Location = new System.Drawing.Point(175, 20);
            this.rbnOther.Name = "rbnOther";
            this.rbnOther.Size = new System.Drawing.Size(65, 21);
            this.rbnOther.TabIndex = 3;
            this.rbnOther.Text = "Other";
            this.rbnOther.UseVisualStyleBackColor = true;
            this.rbnOther.CheckedChanged += new System.EventHandler(this.rbnDefault_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mines:";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(264, 88);
            this.numSize.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(63, 22);
            this.numSize.TabIndex = 7;
            this.numSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numMines
            // 
            this.numMines.Location = new System.Drawing.Point(264, 137);
            this.numMines.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMines.Name = "numMines";
            this.numMines.Size = new System.Drawing.Size(64, 22);
            this.numMines.TabIndex = 8;
            this.numMines.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Size: 9 x 9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mines: 10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnOther);
            this.groupBox1.Controls.Add(this.rbnDefault);
            this.groupBox1.Location = new System.Drawing.Point(38, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 257);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMines);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.MaximumSize = new System.Drawing.Size(399, 304);
            this.MinimumSize = new System.Drawing.Size(399, 304);
            this.Name = "NewGame";
            this.Text = "NewGame";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMines)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbnDefault;
        private System.Windows.Forms.RadioButton rbnOther;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numMines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}