namespace PROJ_admin_
{
    partial class frmLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.paneMain = new System.Windows.Forms.Panel();
            this.gBSys = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dT = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gVList = new System.Windows.Forms.DataGridView();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.paneMain.SuspendLayout();
            this.gBSys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.gBSys);
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(750, 548);
            this.paneMain.TabIndex = 0;
            // 
            // gBSys
            // 
            this.gBSys.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBSys.Controls.Add(this.btnPrint);
            this.gBSys.Controls.Add(this.label6);
            this.gBSys.Controls.Add(this.dT);
            this.gBSys.Controls.Add(this.btnEdit);
            this.gBSys.Controls.Add(this.gVList);
            this.gBSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSys.ForeColor = System.Drawing.Color.White;
            this.gBSys.Location = new System.Drawing.Point(12, 59);
            this.gBSys.Name = "gBSys";
            this.gBSys.Size = new System.Drawing.Size(726, 477);
            this.gBSys.TabIndex = 7;
            this.gBSys.TabStop = false;
            this.gBSys.Text = "System Logs:";
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::PROJ_admin_.Properties.Resources.print_icon;
            this.btnPrint.Location = new System.Drawing.Point(654, 441);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 30);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sort By:";
            // 
            // dT
            // 
            this.dT.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dT.Location = new System.Drawing.Point(84, 445);
            this.dT.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dT.Name = "dT";
            this.dT.Size = new System.Drawing.Size(149, 22);
            this.dT.TabIndex = 0;
            this.dT.ValueChanged += new System.EventHandler(this.dT_ValueChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::PROJ_admin_.Properties.Resources.trash24;
            this.btnEdit.Location = new System.Drawing.Point(690, 441);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gVList
            // 
            this.gVList.AllowUserToAddRows = false;
            this.gVList.AllowUserToResizeRows = false;
            this.gVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gVList.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVList.Location = new System.Drawing.Point(6, 61);
            this.gVList.Name = "gVList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gVList.RowHeadersVisible = false;
            this.gVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVList.Size = new System.Drawing.Size(714, 374);
            this.gVList.TabIndex = 1;
            // 
            // pBClose
            // 
            this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClose.Image = global::PROJ_admin_.Properties.Resources.x_mark_32;
            this.pBClose.Location = new System.Drawing.Point(12, 12);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(27, 23);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBClose.TabIndex = 6;
            this.pBClose.TabStop = false;
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(750, 548);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.paneMain.ResumeLayout(false);
            this.gBSys.ResumeLayout(false);
            this.gBSys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBSys;
        private System.Windows.Forms.DataGridView gVList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
    }
}