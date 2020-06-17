namespace PROJ_admin_
{
    partial class acdmBio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acdmBio));
            this.paneMain = new System.Windows.Forms.Panel();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gVSub = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.paneSubDet = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.tBTot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBPre = new System.Windows.Forms.ComboBox();
            this.cBCoReq = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBIns = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBTimeTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBTimeFrm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paneMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVSub)).BeginInit();
            this.paneSubDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.groupBox1);
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(750, 548);
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
            this.pBClose.TabIndex = 5;
            this.pBClose.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.paneSubDet);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.gVSub);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 479);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Details:";
            // 
            // gVSub
            // 
            this.gVSub.AllowUserToAddRows = false;
            this.gVSub.AllowUserToResizeRows = false;
            this.gVSub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVSub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gVSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVSub.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVSub.DefaultCellStyle = dataGridViewCellStyle2;
            this.gVSub.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVSub.Location = new System.Drawing.Point(16, 262);
            this.gVSub.Name = "gVSub";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVSub.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gVSub.RowHeadersVisible = false;
            this.gVSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVSub.Size = new System.Drawing.Size(704, 175);
            this.gVSub.TabIndex = 61;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::PROJ_admin_.Properties.Resources.trash24;
            this.btnPrint.Location = new System.Drawing.Point(690, 443);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 30);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // paneSubDet
            // 
            this.paneSubDet.Controls.Add(this.btnReg);
            this.paneSubDet.Controls.Add(this.tBTot);
            this.paneSubDet.Controls.Add(this.label9);
            this.paneSubDet.Controls.Add(this.cBPre);
            this.paneSubDet.Controls.Add(this.cBCoReq);
            this.paneSubDet.Controls.Add(this.label8);
            this.paneSubDet.Controls.Add(this.label7);
            this.paneSubDet.Controls.Add(this.cBIns);
            this.paneSubDet.Controls.Add(this.label6);
            this.paneSubDet.Controls.Add(this.tBRoom);
            this.paneSubDet.Controls.Add(this.label5);
            this.paneSubDet.Controls.Add(this.cBTimeTo);
            this.paneSubDet.Controls.Add(this.label4);
            this.paneSubDet.Controls.Add(this.cBTimeFrm);
            this.paneSubDet.Controls.Add(this.label1);
            this.paneSubDet.Controls.Add(this.tBDay);
            this.paneSubDet.Controls.Add(this.label2);
            this.paneSubDet.Controls.Add(this.tBName);
            this.paneSubDet.Controls.Add(this.label17);
            this.paneSubDet.Controls.Add(this.tBCode);
            this.paneSubDet.Controls.Add(this.label16);
            this.paneSubDet.Location = new System.Drawing.Point(16, 28);
            this.paneSubDet.Name = "paneSubDet";
            this.paneSubDet.Size = new System.Drawing.Size(704, 228);
            this.paneSubDet.TabIndex = 63;
            // 
            // btnReg
            // 
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReg.Location = new System.Drawing.Point(453, 185);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(230, 27);
            this.btnReg.TabIndex = 81;
            this.btnReg.Text = "REGISTER";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // tBTot
            // 
            this.tBTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBTot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTot.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBTot.Location = new System.Drawing.Point(145, 172);
            this.tBTot.Name = "tBTot";
            this.tBTot.Size = new System.Drawing.Size(121, 26);
            this.tBTot.TabIndex = 80;
            this.tBTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 79;
            this.label9.Text = "Total Units:";
            // 
            // cBPre
            // 
            this.cBPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPre.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBPre.FormattingEnabled = true;
            this.cBPre.Location = new System.Drawing.Point(145, 140);
            this.cBPre.Name = "cBPre";
            this.cBPre.Size = new System.Drawing.Size(121, 26);
            this.cBPre.TabIndex = 78;
            // 
            // cBCoReq
            // 
            this.cBCoReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBCoReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCoReq.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBCoReq.FormattingEnabled = true;
            this.cBCoReq.Location = new System.Drawing.Point(145, 108);
            this.cBCoReq.Name = "cBCoReq";
            this.cBCoReq.Size = new System.Drawing.Size(121, 26);
            this.cBCoReq.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Pre_Req:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Co_Req:";
            // 
            // cBIns
            // 
            this.cBIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBIns.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBIns.FormattingEnabled = true;
            this.cBIns.Location = new System.Drawing.Point(556, 144);
            this.cBIns.Name = "cBIns";
            this.cBIns.Size = new System.Drawing.Size(127, 26);
            this.cBIns.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Instructor:";
            // 
            // tBRoom
            // 
            this.tBRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBRoom.Location = new System.Drawing.Point(556, 112);
            this.tBRoom.Name = "tBRoom";
            this.tBRoom.Size = new System.Drawing.Size(127, 26);
            this.tBRoom.TabIndex = 72;
            this.tBRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Room:";
            // 
            // cBTimeTo
            // 
            this.cBTimeTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTimeTo.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBTimeTo.FormattingEnabled = true;
            this.cBTimeTo.Location = new System.Drawing.Point(556, 80);
            this.cBTimeTo.Name = "cBTimeTo";
            this.cBTimeTo.Size = new System.Drawing.Size(127, 26);
            this.cBTimeTo.TabIndex = 70;
            this.cBTimeTo.Text = "12:00 P.M.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "To:";
            // 
            // cBTimeFrm
            // 
            this.cBTimeFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBTimeFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTimeFrm.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBTimeFrm.FormattingEnabled = true;
            this.cBTimeFrm.Location = new System.Drawing.Point(556, 48);
            this.cBTimeFrm.Name = "cBTimeFrm";
            this.cBTimeFrm.Size = new System.Drawing.Size(127, 26);
            this.cBTimeFrm.TabIndex = 68;
            this.cBTimeFrm.Text = "12:00 P.M.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "From:";
            // 
            // tBDay
            // 
            this.tBDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDay.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBDay.Location = new System.Drawing.Point(556, 16);
            this.tBDay.Name = "tBDay";
            this.tBDay.Size = new System.Drawing.Size(127, 26);
            this.tBDay.TabIndex = 66;
            this.tBDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Day Sched:";
            // 
            // tBName
            // 
            this.tBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBName.Location = new System.Drawing.Point(145, 48);
            this.tBName.Multiline = true;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(262, 54);
            this.tBName.TabIndex = 64;
            this.tBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 20);
            this.label17.TabIndex = 63;
            this.label17.Text = "Description:";
            // 
            // tBCode
            // 
            this.tBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBCode.Location = new System.Drawing.Point(145, 16);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(127, 26);
            this.tBCode.TabIndex = 62;
            this.tBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 61;
            this.label16.Text = "Subject Code:";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(92, 443);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(175, 26);
            this.tbSearch.TabIndex = 65;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Search:";
            // 
            // frmAcd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(750, 548);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAcd";
            this.Text = "frmAcd";
            this.paneMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVSub)).EndInit();
            this.paneSubDet.ResumeLayout(false);
            this.paneSubDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gVSub;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel paneSubDet;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tBTot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBPre;
        private System.Windows.Forms.ComboBox cBCoReq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBIns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBTimeTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBTimeFrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
    }
}