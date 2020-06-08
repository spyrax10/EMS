namespace PROJ_admin_
{
    partial class empBio
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
            this.paneMain = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.gBDet = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gVList = new System.Windows.Forms.DataGridView();
            this.gBInfo = new System.Windows.Forms.GroupBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.paneInfo = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.cBBar = new System.Windows.Forms.ComboBox();
            this.tBDept = new System.Windows.Forms.TextBox();
            this.tBPur = new System.Windows.Forms.TextBox();
            this.cBMun = new System.Windows.Forms.ComboBox();
            this.cBPro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cBCount = new System.Windows.Forms.ComboBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBMob = new System.Windows.Forms.TextBox();
            this.tBLast = new System.Windows.Forms.TextBox();
            this.tBMid = new System.Windows.Forms.TextBox();
            this.tBFirst = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrow = new System.Windows.Forms.Button();
            this.tBID = new System.Windows.Forms.TextBox();
            this.pBImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paneMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.gBDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVList)).BeginInit();
            this.gBInfo.SuspendLayout();
            this.paneInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.paneMain.Controls.Add(this.btnAdd);
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Controls.Add(this.gBInfo);
            this.paneMain.Controls.Add(this.gBDet);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(750, 548);
            this.paneMain.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::PROJ_admin_.Properties.Resources.List;
            this.btnAdd.Location = new System.Drawing.Point(12, 503);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pBClose
            // 
            this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClose.Image = global::PROJ_admin_.Properties.Resources.x_mark_32;
            this.pBClose.Location = new System.Drawing.Point(12, 12);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(27, 23);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBClose.TabIndex = 4;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // gBDet
            // 
            this.gBDet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBDet.Controls.Add(this.btnEdit);
            this.gBDet.Controls.Add(this.tbSearch);
            this.gBDet.Controls.Add(this.label6);
            this.gBDet.Controls.Add(this.gVList);
            this.gBDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDet.ForeColor = System.Drawing.Color.White;
            this.gBDet.Location = new System.Drawing.Point(12, 57);
            this.gBDet.Name = "gBDet";
            this.gBDet.Size = new System.Drawing.Size(726, 440);
            this.gBDet.TabIndex = 35;
            this.gBDet.TabStop = false;
            this.gBDet.Text = "Employee List:";
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::PROJ_admin_.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(690, 404);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(545, 38);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(175, 26);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search:";
            // 
            // gVList
            // 
            this.gVList.AllowUserToAddRows = false;
            this.gVList.AllowUserToResizeRows = false;
            this.gVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVList.DefaultCellStyle = dataGridViewCellStyle5;
            this.gVList.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVList.Location = new System.Drawing.Point(6, 78);
            this.gVList.Name = "gVList";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gVList.RowHeadersVisible = false;
            this.gVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVList.Size = new System.Drawing.Size(714, 320);
            this.gVList.TabIndex = 0;
            // 
            // gBInfo
            // 
            this.gBInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBInfo.Controls.Add(this.btnRef);
            this.gBInfo.Controls.Add(this.paneInfo);
            this.gBInfo.Controls.Add(this.btnBrow);
            this.gBInfo.Controls.Add(this.tBID);
            this.gBInfo.Controls.Add(this.pBImg);
            this.gBInfo.Controls.Add(this.label1);
            this.gBInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInfo.ForeColor = System.Drawing.Color.White;
            this.gBInfo.Location = new System.Drawing.Point(12, 57);
            this.gBInfo.Name = "gBInfo";
            this.gBInfo.Size = new System.Drawing.Size(726, 440);
            this.gBInfo.TabIndex = 6;
            this.gBInfo.TabStop = false;
            this.gBInfo.Text = "Information Details:";
            this.gBInfo.Visible = false;
            // 
            // btnRef
            // 
            this.btnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Image = global::PROJ_admin_.Properties.Resources.Button_Refresh_icon24;
            this.btnRef.Location = new System.Drawing.Point(586, 89);
            this.btnRef.Name = "btnRef";
            this.btnRef.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnRef.Size = new System.Drawing.Size(30, 29);
            this.btnRef.TabIndex = 34;
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // paneInfo
            // 
            this.paneInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneInfo.Controls.Add(this.lblEmail);
            this.paneInfo.Controls.Add(this.btnReg);
            this.paneInfo.Controls.Add(this.cBBar);
            this.paneInfo.Controls.Add(this.tBDept);
            this.paneInfo.Controls.Add(this.tBPur);
            this.paneInfo.Controls.Add(this.cBMun);
            this.paneInfo.Controls.Add(this.cBPro);
            this.paneInfo.Controls.Add(this.label5);
            this.paneInfo.Controls.Add(this.label13);
            this.paneInfo.Controls.Add(this.label12);
            this.paneInfo.Controls.Add(this.label11);
            this.paneInfo.Controls.Add(this.label10);
            this.paneInfo.Controls.Add(this.cBCount);
            this.paneInfo.Controls.Add(this.tBEmail);
            this.paneInfo.Controls.Add(this.tBMob);
            this.paneInfo.Controls.Add(this.tBLast);
            this.paneInfo.Controls.Add(this.tBMid);
            this.paneInfo.Controls.Add(this.tBFirst);
            this.paneInfo.Controls.Add(this.label9);
            this.paneInfo.Controls.Add(this.label8);
            this.paneInfo.Controls.Add(this.label7);
            this.paneInfo.Controls.Add(this.label4);
            this.paneInfo.Controls.Add(this.label3);
            this.paneInfo.Controls.Add(this.label2);
            this.paneInfo.Enabled = false;
            this.paneInfo.Location = new System.Drawing.Point(6, 182);
            this.paneInfo.Name = "paneInfo";
            this.paneInfo.Size = new System.Drawing.Size(714, 252);
            this.paneInfo.TabIndex = 33;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(116, 231);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 15);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email Not Valid!";
            this.lblEmail.Visible = false;
            // 
            // btnReg
            // 
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReg.Location = new System.Drawing.Point(481, 198);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(215, 27);
            this.btnReg.TabIndex = 50;
            this.btnReg.Text = "REGISTER";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // cBBar
            // 
            this.cBBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBBar.FormattingEnabled = true;
            this.cBBar.Location = new System.Drawing.Point(481, 115);
            this.cBBar.Name = "cBBar";
            this.cBBar.Size = new System.Drawing.Size(215, 26);
            this.cBBar.TabIndex = 49;
            this.cBBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            // 
            // tBDept
            // 
            this.tBDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDept.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBDept.Location = new System.Drawing.Point(125, 18);
            this.tBDept.Name = "tBDept";
            this.tBDept.Size = new System.Drawing.Size(204, 26);
            this.tBDept.TabIndex = 15;
            this.tBDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBDept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            this.tBDept.Leave += new System.EventHandler(this.tBDept_Leave);
            // 
            // tBPur
            // 
            this.tBPur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBPur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPur.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBPur.Location = new System.Drawing.Point(552, 153);
            this.tBPur.Name = "tBPur";
            this.tBPur.Size = new System.Drawing.Size(144, 26);
            this.tBPur.TabIndex = 48;
            this.tBPur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBPur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            this.tBPur.Leave += new System.EventHandler(this.tBDept_Leave);
            // 
            // cBMun
            // 
            this.cBMun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBMun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMun.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBMun.FormattingEnabled = true;
            this.cBMun.Location = new System.Drawing.Point(481, 83);
            this.cBMun.Name = "cBMun";
            this.cBMun.Size = new System.Drawing.Size(215, 26);
            this.cBMun.TabIndex = 47;
            this.cBMun.SelectedIndexChanged += new System.EventHandler(this.cBMun_SelectedIndexChanged);
            this.cBMun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            // 
            // cBPro
            // 
            this.cBPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPro.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBPro.FormattingEnabled = true;
            this.cBPro.Location = new System.Drawing.Point(481, 51);
            this.cBPro.Name = "cBPro";
            this.cBPro.Size = new System.Drawing.Size(215, 26);
            this.cBPro.TabIndex = 46;
            this.cBPro.SelectedIndexChanged += new System.EventHandler(this.cBPro_SelectedIndexChanged);
            this.cBPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(366, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Purok / House # / Street :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(365, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Barangay:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Municipality:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(365, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Province:";
            // 
            // cBCount
            // 
            this.cBCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBCount.FormattingEnabled = true;
            this.cBCount.Location = new System.Drawing.Point(481, 19);
            this.cBCount.Name = "cBCount";
            this.cBCount.Size = new System.Drawing.Size(215, 26);
            this.cBCount.TabIndex = 41;
            this.cBCount.SelectedIndexChanged += new System.EventHandler(this.cBCount_SelectedIndexChanged);
            this.cBCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            // 
            // tBEmail
            // 
            this.tBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBEmail.Location = new System.Drawing.Point(119, 204);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(210, 24);
            this.tBEmail.TabIndex = 40;
            this.tBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBEmail.Leave += new System.EventHandler(this.tBEmail_Leave);
            // 
            // tBMob
            // 
            this.tBMob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMob.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBMob.Location = new System.Drawing.Point(119, 172);
            this.tBMob.Name = "tBMob";
            this.tBMob.Size = new System.Drawing.Size(210, 26);
            this.tBMob.TabIndex = 39;
            this.tBMob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBMob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBMob_KeyPress);
            this.tBMob.Leave += new System.EventHandler(this.tBMob_Leave);
            // 
            // tBLast
            // 
            this.tBLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLast.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBLast.Location = new System.Drawing.Point(119, 140);
            this.tBLast.Name = "tBLast";
            this.tBLast.Size = new System.Drawing.Size(210, 26);
            this.tBLast.TabIndex = 38;
            this.tBLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            this.tBLast.Leave += new System.EventHandler(this.tBDept_Leave);
            // 
            // tBMid
            // 
            this.tBMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMid.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBMid.Location = new System.Drawing.Point(119, 108);
            this.tBMid.Name = "tBMid";
            this.tBMid.Size = new System.Drawing.Size(210, 26);
            this.tBMid.TabIndex = 37;
            this.tBMid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBMid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            this.tBMid.Leave += new System.EventHandler(this.tBDept_Leave);
            // 
            // tBFirst
            // 
            this.tBFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFirst.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBFirst.Location = new System.Drawing.Point(119, 76);
            this.tBFirst.Name = "tBFirst";
            this.tBFirst.Size = new System.Drawing.Size(210, 26);
            this.tBFirst.TabIndex = 36;
            this.tBFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDept_KeyPress);
            this.tBFirst.Leave += new System.EventHandler(this.tBDept_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mobile #:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Midname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Firstname:";
            // 
            // btnBrow
            // 
            this.btnBrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrow.FlatAppearance.BorderSize = 0;
            this.btnBrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrow.Image = global::PROJ_admin_.Properties.Resources.upload_3_32;
            this.btnBrow.Location = new System.Drawing.Point(132, 119);
            this.btnBrow.Name = "btnBrow";
            this.btnBrow.Size = new System.Drawing.Size(37, 37);
            this.btnBrow.TabIndex = 32;
            this.btnBrow.UseVisualStyleBackColor = true;
            this.btnBrow.Click += new System.EventHandler(this.btnBrow_Click);
            // 
            // tBID
            // 
            this.tBID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tBID.Location = new System.Drawing.Point(376, 89);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(204, 29);
            this.tBID.TabIndex = 9;
            this.tBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBID_KeyPress);
            // 
            // pBImg
            // 
            this.pBImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBImg.Image = global::PROJ_admin_.Properties.Resources.download;
            this.pBImg.Location = new System.Drawing.Point(26, 56);
            this.pBImg.Name = "pBImg";
            this.pBImg.Size = new System.Drawing.Size(100, 100);
            this.pBImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImg.TabIndex = 31;
            this.pBImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(254, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number:";
            // 
            // empBio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(750, 548);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "empBio";
            this.Text = "empBio";
            this.Load += new System.EventHandler(this.empBio_Load);
            this.paneMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.gBDet.ResumeLayout(false);
            this.gBDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVList)).EndInit();
            this.gBInfo.ResumeLayout(false);
            this.gBInfo.PerformLayout();
            this.paneInfo.ResumeLayout(false);
            this.paneInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gBInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Button btnBrow;
        private System.Windows.Forms.PictureBox pBImg;
        private System.Windows.Forms.Panel paneInfo;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ComboBox cBBar;
        private System.Windows.Forms.TextBox tBPur;
        private System.Windows.Forms.ComboBox cBMun;
        private System.Windows.Forms.ComboBox cBPro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBCount;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBMob;
        private System.Windows.Forms.TextBox tBLast;
        private System.Windows.Forms.TextBox tBMid;
        private System.Windows.Forms.TextBox tBFirst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBDept;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.GroupBox gBDet;
        private System.Windows.Forms.DataGridView gVList;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
    }
}