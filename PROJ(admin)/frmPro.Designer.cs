namespace PROJ_admin_
{
    partial class frmPro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPro));
            this.paneMain = new System.Windows.Forms.Panel();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.gBPro = new System.Windows.Forms.GroupBox();
            this.paneSub = new System.Windows.Forms.Panel();
            this.btnStud = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gVSub = new System.Windows.Forms.DataGridView();
            this.lblProDept = new System.Windows.Forms.Label();
            this.lblProName = new System.Windows.Forms.Label();
            this.lblProID = new System.Windows.Forms.Label();
            this.pBImg = new System.Windows.Forms.PictureBox();
            this.gBStud = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBSub = new System.Windows.Forms.ComboBox();
            this.gVStud = new System.Windows.Forms.DataGridView();
            this.paneMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.gBPro.SuspendLayout();
            this.paneSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).BeginInit();
            this.gBStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVStud)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Controls.Add(this.gBStud);
            this.paneMain.Controls.Add(this.gBPro);
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
            this.pBClose.TabIndex = 6;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // gBPro
            // 
            this.gBPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBPro.Controls.Add(this.paneSub);
            this.gBPro.Controls.Add(this.lblProDept);
            this.gBPro.Controls.Add(this.lblProName);
            this.gBPro.Controls.Add(this.lblProID);
            this.gBPro.Controls.Add(this.pBImg);
            this.gBPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBPro.ForeColor = System.Drawing.Color.White;
            this.gBPro.Location = new System.Drawing.Point(12, 57);
            this.gBPro.Name = "gBPro";
            this.gBPro.Size = new System.Drawing.Size(794, 453);
            this.gBPro.TabIndex = 10;
            this.gBPro.TabStop = false;
            this.gBPro.Text = "Subject Profile:";
            // 
            // paneSub
            // 
            this.paneSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneSub.Controls.Add(this.btnStud);
            this.paneSub.Controls.Add(this.btnDrop);
            this.paneSub.Controls.Add(this.btnSub);
            this.paneSub.Controls.Add(this.tBName);
            this.paneSub.Controls.Add(this.label17);
            this.paneSub.Controls.Add(this.tBCode);
            this.paneSub.Controls.Add(this.label16);
            this.paneSub.Controls.Add(this.gVSub);
            this.paneSub.Location = new System.Drawing.Point(6, 167);
            this.paneSub.Name = "paneSub";
            this.paneSub.Size = new System.Drawing.Size(782, 279);
            this.paneSub.TabIndex = 36;
            // 
            // btnStud
            // 
            this.btnStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStud.ForeColor = System.Drawing.Color.Lime;
            this.btnStud.Location = new System.Drawing.Point(621, 245);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(156, 27);
            this.btnStud.TabIndex = 60;
            this.btnStud.Text = "STUDENT LIST";
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrop.FlatAppearance.BorderSize = 0;
            this.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrop.ForeColor = System.Drawing.Color.Red;
            this.btnDrop.Image = global::PROJ_admin_.Properties.Resources.trash24;
            this.btnDrop.Location = new System.Drawing.Point(308, 244);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(29, 29);
            this.btnDrop.TabIndex = 54;
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSub.Location = new System.Drawing.Point(186, 193);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(89, 27);
            this.btnSub.TabIndex = 76;
            this.btnSub.Text = "ADD";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // tBName
            // 
            this.tBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBName.Location = new System.Drawing.Point(10, 128);
            this.tBName.Multiline = true;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(265, 59);
            this.tBName.TabIndex = 75;
            this.tBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 20);
            this.label17.TabIndex = 74;
            this.label17.Text = "Description:";
            // 
            // tBCode
            // 
            this.tBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBCode.Location = new System.Drawing.Point(134, 61);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(112, 29);
            this.tBCode.TabIndex = 73;
            this.tBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 72;
            this.label16.Text = "Subject Code:";
            // 
            // gVSub
            // 
            this.gVSub.AllowUserToAddRows = false;
            this.gVSub.AllowUserToResizeRows = false;
            this.gVSub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVSub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gVSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVSub.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVSub.DefaultCellStyle = dataGridViewCellStyle8;
            this.gVSub.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVSub.Location = new System.Drawing.Point(313, 3);
            this.gVSub.Name = "gVSub";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVSub.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gVSub.RowHeadersVisible = false;
            this.gVSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVSub.Size = new System.Drawing.Size(464, 236);
            this.gVSub.TabIndex = 2;
            this.gVSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVSub_CellClick);
            // 
            // lblProDept
            // 
            this.lblProDept.AutoSize = true;
            this.lblProDept.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProDept.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblProDept.Location = new System.Drawing.Point(141, 122);
            this.lblProDept.Name = "lblProDept";
            this.lblProDept.Size = new System.Drawing.Size(129, 27);
            this.lblProDept.TabIndex = 35;
            this.lblProDept.Text = "Department:";
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblProName.Location = new System.Drawing.Point(141, 86);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(112, 27);
            this.lblProName.TabIndex = 34;
            this.lblProName.Text = "Full Name:";
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblProID.Location = new System.Drawing.Point(141, 49);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(36, 27);
            this.lblProID.TabIndex = 33;
            this.lblProID.Text = "ID";
            // 
            // pBImg
            // 
            this.pBImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBImg.Image = global::PROJ_admin_.Properties.Resources.download;
            this.pBImg.Location = new System.Drawing.Point(17, 49);
            this.pBImg.Name = "pBImg";
            this.pBImg.Size = new System.Drawing.Size(100, 100);
            this.pBImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImg.TabIndex = 32;
            this.pBImg.TabStop = false;
            // 
            // gBStud
            // 
            this.gBStud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBStud.Controls.Add(this.btnBack);
            this.gBStud.Controls.Add(this.dataGridView1);
            this.gBStud.Controls.Add(this.cBSub);
            this.gBStud.Controls.Add(this.gVStud);
            this.gBStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBStud.ForeColor = System.Drawing.Color.White;
            this.gBStud.Location = new System.Drawing.Point(12, 57);
            this.gBStud.Name = "gBStud";
            this.gBStud.Size = new System.Drawing.Size(794, 454);
            this.gBStud.TabIndex = 11;
            this.gBStud.TabStop = false;
            this.gBStud.Text = "My Students:";
            this.gBStud.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Image = global::PROJ_admin_.Properties.Resources.Go_back_icon;
            this.btnBack.Location = new System.Drawing.Point(755, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 29);
            this.btnBack.TabIndex = 55;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(503, 60);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(281, 354);
            this.dataGridView1.TabIndex = 43;
            // 
            // cBSub
            // 
            this.cBSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSub.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBSub.FormattingEnabled = true;
            this.cBSub.Location = new System.Drawing.Point(10, 420);
            this.cBSub.Name = "cBSub";
            this.cBSub.Size = new System.Drawing.Size(128, 26);
            this.cBSub.TabIndex = 42;
            this.cBSub.SelectedIndexChanged += new System.EventHandler(this.cBSub_SelectedIndexChanged);
            // 
            // gVStud
            // 
            this.gVStud.AllowUserToAddRows = false;
            this.gVStud.AllowUserToResizeRows = false;
            this.gVStud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVStud.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVStud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gVStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVStud.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVStud.DefaultCellStyle = dataGridViewCellStyle5;
            this.gVStud.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVStud.Location = new System.Drawing.Point(10, 60);
            this.gVStud.Name = "gVStud";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVStud.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gVStud.RowHeadersVisible = false;
            this.gVStud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVStud.Size = new System.Drawing.Size(472, 354);
            this.gVStud.TabIndex = 3;
            // 
            // frmPro
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
            this.Name = "frmPro";
            this.Text = "frmPro";
            this.Load += new System.EventHandler(this.frmPro_Load);
            this.paneMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.gBPro.ResumeLayout(false);
            this.gBPro.PerformLayout();
            this.paneSub.ResumeLayout(false);
            this.paneSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).EndInit();
            this.gBStud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVStud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBStud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cBSub;
        private System.Windows.Forms.DataGridView gVStud;
        private System.Windows.Forms.GroupBox gBPro;
        private System.Windows.Forms.Panel paneSub;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView gVSub;
        private System.Windows.Forms.Label lblProDept;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.PictureBox pBImg;
        private System.Windows.Forms.Button btnBack;
    }
}