namespace PROJ_admin_
{
    partial class frmRec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRec));
            this.paneMain = new System.Windows.Forms.Panel();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.gBScore = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.gVScore = new System.Windows.Forms.DataGridView();
            this.gBSum = new System.Windows.Forms.GroupBox();
            this.btnStud = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cBCode = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gVData = new System.Windows.Forms.DataGridView();
            this.paneMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.gBScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVScore)).BeginInit();
            this.gBSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVData)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Controls.Add(this.gBSum);
            this.paneMain.Controls.Add(this.gBScore);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(818, 521);
            this.paneMain.TabIndex = 0;
            // 
            // pBClose
            // 
            this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClose.Image = global::PROJ_admin_.Properties.Resources.x_mark_32;
            this.pBClose.Location = new System.Drawing.Point(12, 12);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(27, 23);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBClose.TabIndex = 9;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // gBScore
            // 
            this.gBScore.Controls.Add(this.button1);
            this.gBScore.Controls.Add(this.btnPrint2);
            this.gBScore.Controls.Add(this.gVScore);
            this.gBScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBScore.ForeColor = System.Drawing.Color.White;
            this.gBScore.Location = new System.Drawing.Point(12, 57);
            this.gBScore.Name = "gBScore";
            this.gBScore.Size = new System.Drawing.Size(794, 452);
            this.gBScore.TabIndex = 11;
            this.gBScore.TabStop = false;
            this.gBScore.Text = "Answer Breakdown:";
            this.gBScore.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PROJ_admin_.Properties.Resources.Go_back_icon;
            this.button1.Location = new System.Drawing.Point(6, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint2.FlatAppearance.BorderSize = 0;
            this.btnPrint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint2.Image = global::PROJ_admin_.Properties.Resources.print_icon;
            this.btnPrint2.Location = new System.Drawing.Point(758, 416);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(30, 30);
            this.btnPrint2.TabIndex = 0;
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // gVScore
            // 
            this.gVScore.AllowUserToAddRows = false;
            this.gVScore.AllowUserToResizeRows = false;
            this.gVScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVScore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gVScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVScore.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVScore.DefaultCellStyle = dataGridViewCellStyle5;
            this.gVScore.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVScore.Location = new System.Drawing.Point(6, 66);
            this.gVScore.Name = "gVScore";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gVScore.RowHeadersVisible = false;
            this.gVScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVScore.Size = new System.Drawing.Size(782, 347);
            this.gVScore.TabIndex = 48;
            // 
            // gBSum
            // 
            this.gBSum.Controls.Add(this.btnStud);
            this.gBSum.Controls.Add(this.label16);
            this.gBSum.Controls.Add(this.cBCode);
            this.gBSum.Controls.Add(this.btnPrint);
            this.gBSum.Controls.Add(this.gVData);
            this.gBSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBSum.ForeColor = System.Drawing.Color.White;
            this.gBSum.Location = new System.Drawing.Point(12, 57);
            this.gBSum.Name = "gBSum";
            this.gBSum.Size = new System.Drawing.Size(794, 452);
            this.gBSum.TabIndex = 10;
            this.gBSum.TabStop = false;
            this.gBSum.Text = "Summary:";
            // 
            // btnStud
            // 
            this.btnStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStud.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnStud.Location = new System.Drawing.Point(6, 419);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(199, 27);
            this.btnStud.TabIndex = 1;
            this.btnStud.Text = "ANSWER BREAKDOWN";
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label16.Location = new System.Drawing.Point(567, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 24);
            this.label16.TabIndex = 88;
            this.label16.Text = "Code:";
            // 
            // cBCode
            // 
            this.cBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBCode.FormattingEnabled = true;
            this.cBCode.Location = new System.Drawing.Point(639, 28);
            this.cBCode.Name = "cBCode";
            this.cBCode.Size = new System.Drawing.Size(149, 32);
            this.cBCode.TabIndex = 0;
            this.cBCode.SelectedIndexChanged += new System.EventHandler(this.cBCode_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::PROJ_admin_.Properties.Resources.print_icon;
            this.btnPrint.Location = new System.Drawing.Point(758, 416);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 30);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.gVData.Location = new System.Drawing.Point(6, 66);
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
            this.gVData.Size = new System.Drawing.Size(782, 347);
            this.gVData.TabIndex = 47;
            // 
            // frmRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(818, 521);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRec";
            this.Text = "frmRec";
            this.Load += new System.EventHandler(this.frmRec_Load);
            this.paneMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.gBScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVScore)).EndInit();
            this.gBSum.ResumeLayout(false);
            this.gBSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBSum;
        private System.Windows.Forms.DataGridView gVData;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cBCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.GroupBox gBScore;
        private System.Windows.Forms.DataGridView gVScore;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.Button button1;
    }
}