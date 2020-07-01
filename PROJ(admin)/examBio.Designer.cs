namespace PROJ_admin_
{
    partial class examBio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examBio));
            this.paneMain = new System.Windows.Forms.Panel();
            this.gBTest = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStud = new System.Windows.Forms.Button();
            this.gVData = new System.Windows.Forms.DataGridView();
            this.gBDet = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.numLimit = new System.Windows.Forms.NumericUpDown();
            this.tBPer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cBCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBSub = new System.Windows.Forms.TextBox();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.paneMain.SuspendLayout();
            this.gBTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVData)).BeginInit();
            this.gBDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.gBTest);
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(818, 521);
            this.paneMain.TabIndex = 0;
            // 
            // gBTest
            // 
            this.gBTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBTest.Controls.Add(this.label6);
            this.gBTest.Controls.Add(this.lblTime);
            this.gBTest.Controls.Add(this.btnStud);
            this.gBTest.Controls.Add(this.gVData);
            this.gBTest.Controls.Add(this.gBDet);
            this.gBTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBTest.ForeColor = System.Drawing.Color.White;
            this.gBTest.Location = new System.Drawing.Point(12, 57);
            this.gBTest.Name = "gBTest";
            this.gBTest.Size = new System.Drawing.Size(794, 452);
            this.gBTest.TabIndex = 9;
            this.gBTest.TabStop = false;
            this.gBTest.Text = "Test Section:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(664, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 105;
            this.label6.Text = "minutes left";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTime.Location = new System.Drawing.Point(631, 418);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 24);
            this.lblTime.TabIndex = 104;
            this.lblTime.Text = "0";
            // 
            // btnStud
            // 
            this.btnStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStud.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnStud.Location = new System.Drawing.Point(12, 419);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(173, 27);
            this.btnStud.TabIndex = 103;
            this.btnStud.Text = "CHECK STUDENTS";
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // gVData
            // 
            this.gVData.AllowUserToAddRows = false;
            this.gVData.AllowUserToResizeRows = false;
            this.gVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gVData.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVData.Location = new System.Drawing.Point(12, 166);
            this.gVData.Name = "gVData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gVData.RowHeadersVisible = false;
            this.gVData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVData.Size = new System.Drawing.Size(768, 247);
            this.gVData.TabIndex = 46;
            // 
            // gBDet
            // 
            this.gBDet.Controls.Add(this.label3);
            this.gBDet.Controls.Add(this.btnStart);
            this.gBDet.Controls.Add(this.numLimit);
            this.gBDet.Controls.Add(this.tBPer);
            this.gBDet.Controls.Add(this.label16);
            this.gBDet.Controls.Add(this.cBCode);
            this.gBDet.Controls.Add(this.label4);
            this.gBDet.Controls.Add(this.label2);
            this.gBDet.Controls.Add(this.label1);
            this.gBDet.Controls.Add(this.tBSub);
            this.gBDet.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gBDet.Location = new System.Drawing.Point(12, 44);
            this.gBDet.Name = "gBDet";
            this.gBDet.Size = new System.Drawing.Size(768, 96);
            this.gBDet.TabIndex = 0;
            this.gBDet.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(588, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "MINS";
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Location = new System.Drawing.Point(639, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 27);
            this.btnStart.TabIndex = 102;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numLimit
            // 
            this.numLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.numLimit.ForeColor = System.Drawing.Color.Gainsboro;
            this.numLimit.Location = new System.Drawing.Point(518, 51);
            this.numLimit.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numLimit.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(64, 34);
            this.numLimit.TabIndex = 104;
            this.numLimit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numLimit.ValueChanged += new System.EventHandler(this.numLimit_ValueChanged);
            this.numLimit.Enter += new System.EventHandler(this.numLimit_ValueChanged);
            // 
            // tBPer
            // 
            this.tBPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBPer.Enabled = false;
            this.tBPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPer.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBPer.Location = new System.Drawing.Point(352, 52);
            this.tBPer.Multiline = true;
            this.tBPer.Name = "tBPer";
            this.tBPer.Size = new System.Drawing.Size(149, 32);
            this.tBPer.TabIndex = 106;
            this.tBPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label16.Location = new System.Drawing.Point(20, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Code:";
            // 
            // cBCode
            // 
            this.cBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBCode.FormattingEnabled = true;
            this.cBCode.Location = new System.Drawing.Point(24, 52);
            this.cBCode.Name = "cBCode";
            this.cBCode.Size = new System.Drawing.Size(149, 32);
            this.cBCode.TabIndex = 86;
            this.cBCode.SelectedIndexChanged += new System.EventHandler(this.cBCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(348, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 105;
            this.label4.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(514, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(184, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Subject:";
            // 
            // tBSub
            // 
            this.tBSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBSub.Enabled = false;
            this.tBSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSub.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBSub.Location = new System.Drawing.Point(188, 52);
            this.tBSub.Multiline = true;
            this.tBSub.Name = "tBSub";
            this.tBSub.Size = new System.Drawing.Size(149, 32);
            this.tBSub.TabIndex = 88;
            this.tBSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBClose
            // 
            this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClose.Image = global::PROJ_admin_.Properties.Resources.x_mark_32;
            this.pBClose.Location = new System.Drawing.Point(12, 12);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(27, 23);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBClose.TabIndex = 8;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // examBio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(818, 521);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "examBio";
            this.Text = "examBio";
            this.Load += new System.EventHandler(this.examBio_Load);
            this.paneMain.ResumeLayout(false);
            this.gBTest.ResumeLayout(false);
            this.gBTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVData)).EndInit();
            this.gBDet.ResumeLayout(false);
            this.gBDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBTest;
        private System.Windows.Forms.GroupBox gBDet;
        private System.Windows.Forms.DataGridView gVData;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBPer;
        private System.Windows.Forms.TextBox tBSub;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
    }
}