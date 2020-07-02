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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPro));
            this.paneMain = new System.Windows.Forms.Panel();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.gBPro = new System.Windows.Forms.GroupBox();
            this.paneSub = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
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
            this.gBGrade = new System.Windows.Forms.GroupBox();
            this.gBDet = new System.Windows.Forms.GroupBox();
            this.tBGrade = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.cBRemarks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gVGrade = new System.Windows.Forms.DataGridView();
            this.paneMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.gBPro.SuspendLayout();
            this.paneSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).BeginInit();
            this.gBGrade.SuspendLayout();
            this.gBDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Controls.Add(this.gBGrade);
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
            this.paneSub.Controls.Add(this.label4);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(309, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Current Handled Subjects:";
            // 
            // btnStud
            // 
            this.btnStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStud.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnStud.Location = new System.Drawing.Point(621, 247);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(156, 27);
            this.btnStud.TabIndex = 4;
            this.btnStud.Text = "GRADING SCHEME";
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
            this.btnDrop.Location = new System.Drawing.Point(313, 246);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(29, 29);
            this.btnDrop.TabIndex = 3;
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
            this.btnSub.TabIndex = 2;
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
            this.tBName.TabIndex = 1;
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
            this.tBCode.TabIndex = 0;
            this.tBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 66);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gVSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVSub.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVSub.DefaultCellStyle = dataGridViewCellStyle5;
            this.gVSub.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVSub.Location = new System.Drawing.Point(313, 34);
            this.gVSub.Name = "gVSub";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVSub.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gVSub.RowHeadersVisible = false;
            this.gVSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVSub.Size = new System.Drawing.Size(464, 207);
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
            // gBGrade
            // 
            this.gBGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBGrade.Controls.Add(this.gBDet);
            this.gBGrade.Controls.Add(this.btnBack);
            this.gBGrade.Controls.Add(this.gVGrade);
            this.gBGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBGrade.ForeColor = System.Drawing.Color.White;
            this.gBGrade.Location = new System.Drawing.Point(12, 57);
            this.gBGrade.Name = "gBGrade";
            this.gBGrade.Size = new System.Drawing.Size(794, 454);
            this.gBGrade.TabIndex = 11;
            this.gBGrade.TabStop = false;
            this.gBGrade.Text = "Grading Scheme:";
            this.gBGrade.Visible = false;
            // 
            // gBDet
            // 
            this.gBDet.Controls.Add(this.tBGrade);
            this.gBDet.Controls.Add(this.btnGrade);
            this.gBDet.Controls.Add(this.cBRemarks);
            this.gBDet.Controls.Add(this.label3);
            this.gBDet.Controls.Add(this.label2);
            this.gBDet.Controls.Add(this.numPer);
            this.gBDet.Controls.Add(this.label1);
            this.gBDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDet.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gBDet.Location = new System.Drawing.Point(17, 95);
            this.gBDet.Name = "gBDet";
            this.gBDet.Size = new System.Drawing.Size(220, 229);
            this.gBDet.TabIndex = 56;
            this.gBDet.TabStop = false;
            this.gBDet.Text = "Grade Details:";
            // 
            // tBGrade
            // 
            this.tBGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBGrade.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBGrade.Location = new System.Drawing.Point(118, 107);
            this.tBGrade.Name = "tBGrade";
            this.tBGrade.Size = new System.Drawing.Size(71, 29);
            this.tBGrade.TabIndex = 1;
            this.tBGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGrade
            // 
            this.btnGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGrade.Location = new System.Drawing.Point(125, 183);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(89, 27);
            this.btnGrade.TabIndex = 3;
            this.btnGrade.Text = "ADD";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // cBRemarks
            // 
            this.cBRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBRemarks.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBRemarks.FormattingEnabled = true;
            this.cBRemarks.Items.AddRange(new object[] {
            "PASSED",
            "FAILED"});
            this.cBRemarks.Location = new System.Drawing.Point(10, 182);
            this.cBRemarks.Name = "cBRemarks";
            this.cBRemarks.Size = new System.Drawing.Size(108, 28);
            this.cBRemarks.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Remarks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Grade:";
            // 
            // numPer
            // 
            this.numPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.numPer.ForeColor = System.Drawing.Color.White;
            this.numPer.Location = new System.Drawing.Point(118, 64);
            this.numPer.Name = "numPer";
            this.numPer.Size = new System.Drawing.Size(71, 29);
            this.numPer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Percentage:";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Image = global::PROJ_admin_.Properties.Resources.Go_back_icon;
            this.btnBack.Location = new System.Drawing.Point(755, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gVGrade
            // 
            this.gVGrade.AllowUserToAddRows = false;
            this.gVGrade.AllowUserToResizeRows = false;
            this.gVGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVGrade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gVGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gVGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVGrade.DefaultCellStyle = dataGridViewCellStyle2;
            this.gVGrade.GridColor = System.Drawing.Color.DodgerBlue;
            this.gVGrade.Location = new System.Drawing.Point(259, 28);
            this.gVGrade.Name = "gVGrade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVGrade.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gVGrade.RowHeadersVisible = false;
            this.gVGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVGrade.Size = new System.Drawing.Size(525, 381);
            this.gVGrade.TabIndex = 3;
            this.gVGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVGrade_CellClick);
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
            this.gBGrade.ResumeLayout(false);
            this.gBDet.ResumeLayout(false);
            this.gBDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBGrade;
        private System.Windows.Forms.DataGridView gVGrade;
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
        private System.Windows.Forms.GroupBox gBDet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBRemarks;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.TextBox tBGrade;
        private System.Windows.Forms.Label label4;
    }
}