namespace PROJ_admin_
{
    partial class frmQues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQues));
            this.paneMain = new System.Windows.Forms.Panel();
            this.gBQues = new System.Windows.Forms.GroupBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.gBDet = new System.Windows.Forms.GroupBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.tBSet = new System.Windows.Forms.TextBox();
            this.cBType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBPer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBSub = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.lblProID = new System.Windows.Forms.Label();
            this.paneQues = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCho = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.TextBox();
            this.tBAns = new System.Windows.Forms.TextBox();
            this.btnNum = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.gVData = new System.Windows.Forms.DataGridView();
            this.tBQues = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.paneIns = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefDet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDropIden = new System.Windows.Forms.Button();
            this.btnRefIden = new System.Windows.Forms.Button();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.paneMain.SuspendLayout();
            this.gBQues.SuspendLayout();
            this.gBDet.SuspendLayout();
            this.paneQues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVData)).BeginInit();
            this.paneIns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.gBQues);
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(818, 521);
            this.paneMain.TabIndex = 0;
            // 
            // gBQues
            // 
            this.gBQues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBQues.Controls.Add(this.btnPre);
            this.gBQues.Controls.Add(this.gBDet);
            this.gBQues.Controls.Add(this.tBCode);
            this.gBQues.Controls.Add(this.lblProID);
            this.gBQues.Controls.Add(this.paneQues);
            this.gBQues.Controls.Add(this.paneIns);
            this.gBQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBQues.ForeColor = System.Drawing.Color.White;
            this.gBQues.Location = new System.Drawing.Point(12, 57);
            this.gBQues.Name = "gBQues";
            this.gBQues.Size = new System.Drawing.Size(794, 452);
            this.gBQues.TabIndex = 8;
            this.gBQues.TabStop = false;
            this.gBQues.Text = "Questionaire Maker:";
            // 
            // btnPre
            // 
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.SlateGray;
            this.btnPre.Location = new System.Drawing.Point(6, 412);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(210, 27);
            this.btnPre.TabIndex = 101;
            this.btnPre.Text = "PREVIEW QUESTIONS";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // gBDet
            // 
            this.gBDet.Controls.Add(this.btnRefDet);
            this.gBDet.Controls.Add(this.lblErr);
            this.gBDet.Controls.Add(this.tBSet);
            this.gBDet.Controls.Add(this.cBType);
            this.gBDet.Controls.Add(this.label3);
            this.gBDet.Controls.Add(this.cBPer);
            this.gBDet.Controls.Add(this.label2);
            this.gBDet.Controls.Add(this.label1);
            this.gBDet.Controls.Add(this.cBSub);
            this.gBDet.Controls.Add(this.label16);
            this.gBDet.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gBDet.Location = new System.Drawing.Point(6, 110);
            this.gBDet.Name = "gBDet";
            this.gBDet.Size = new System.Drawing.Size(210, 291);
            this.gBDet.TabIndex = 75;
            this.gBDet.TabStop = false;
            this.gBDet.Text = "Details:";
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(6, 244);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(131, 19);
            this.lblErr.TabIndex = 83;
            this.lblErr.Text = "Incomplete Field/s!";
            this.lblErr.Visible = false;
            // 
            // tBSet
            // 
            this.tBSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBSet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSet.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBSet.Location = new System.Drawing.Point(151, 147);
            this.tBSet.Name = "tBSet";
            this.tBSet.Size = new System.Drawing.Size(48, 29);
            this.tBSet.TabIndex = 82;
            this.tBSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cBType
            // 
            this.cBType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBType.FormattingEnabled = true;
            this.cBType.Items.AddRange(new object[] {
            "Identification",
            "Enumeration",
            "Multiple Choice"});
            this.cBType.Location = new System.Drawing.Point(10, 213);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(189, 28);
            this.cBType.TabIndex = 78;
            this.cBType.SelectedIndexChanged += new System.EventHandler(this.cBType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(147, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Set:";
            // 
            // cBPer
            // 
            this.cBPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPer.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBPer.FormattingEnabled = true;
            this.cBPer.Items.AddRange(new object[] {
            "Prelim",
            "MidTerm",
            "Semi-Final",
            "Final"});
            this.cBPer.Location = new System.Drawing.Point(10, 147);
            this.cBPer.Name = "cBPer";
            this.cBPer.Size = new System.Drawing.Size(127, 28);
            this.cBPer.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Period:";
            // 
            // cBSub
            // 
            this.cBSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSub.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBSub.FormattingEnabled = true;
            this.cBSub.Location = new System.Drawing.Point(10, 81);
            this.cBSub.Name = "cBSub";
            this.cBSub.Size = new System.Drawing.Size(189, 28);
            this.cBSub.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 73;
            this.label16.Text = "Subject:";
            // 
            // tBCode
            // 
            this.tBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBCode.Location = new System.Drawing.Point(81, 54);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(120, 29);
            this.tBCode.TabIndex = 74;
            this.tBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCode_KeyPress);
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProID.ForeColor = System.Drawing.Color.Yellow;
            this.lblProID.Location = new System.Drawing.Point(11, 55);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(64, 27);
            this.lblProID.TabIndex = 34;
            this.lblProID.Text = "Code:";
            // 
            // paneQues
            // 
            this.paneQues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneQues.Controls.Add(this.btnAdd);
            this.paneQues.Controls.Add(this.btnOk);
            this.paneQues.Controls.Add(this.btnCho);
            this.paneQues.Controls.Add(this.lblType);
            this.paneQues.Controls.Add(this.tBAns);
            this.paneQues.Controls.Add(this.btnNum);
            this.paneQues.Controls.Add(this.label11);
            this.paneQues.Controls.Add(this.gVData);
            this.paneQues.Controls.Add(this.btnDropIden);
            this.paneQues.Controls.Add(this.tBQues);
            this.paneQues.Controls.Add(this.label12);
            this.paneQues.Controls.Add(this.label13);
            this.paneQues.Controls.Add(this.btnRefIden);
            this.paneQues.Location = new System.Drawing.Point(225, 21);
            this.paneQues.Name = "paneQues";
            this.paneQues.Size = new System.Drawing.Size(563, 425);
            this.paneQues.TabIndex = 9;
            this.paneQues.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.Location = new System.Drawing.Point(467, 391);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 27);
            this.btnOk.TabIndex = 94;
            this.btnOk.Text = "UPDATE";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCho
            // 
            this.btnCho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCho.ForeColor = System.Drawing.Color.Lime;
            this.btnCho.Location = new System.Drawing.Point(7, 391);
            this.btnCho.Name = "btnCho";
            this.btnCho.Size = new System.Drawing.Size(115, 27);
            this.btnCho.TabIndex = 93;
            this.btnCho.Text = "SET CHOICES";
            this.btnCho.UseVisualStyleBackColor = true;
            this.btnCho.Visible = false;
            this.btnCho.Click += new System.EventHandler(this.btnCho_Click);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Lime;
            this.lblType.Location = new System.Drawing.Point(181, 3);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(188, 23);
            this.lblType.TabIndex = 83;
            this.lblType.Text = "MULTIPLE CHOICE";
            this.lblType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAns
            // 
            this.tBAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAns.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBAns.Location = new System.Drawing.Point(275, 303);
            this.tBAns.Margin = new System.Windows.Forms.Padding(7);
            this.tBAns.Multiline = true;
            this.tBAns.Name = "tBAns";
            this.tBAns.Size = new System.Drawing.Size(276, 84);
            this.tBAns.TabIndex = 91;
            this.tBAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum.ForeColor = System.Drawing.Color.White;
            this.btnNum.Location = new System.Drawing.Point(45, 239);
            this.btnNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.btnNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(58, 26);
            this.btnNum.TabIndex = 88;
            this.btnNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SlateGray;
            this.label11.Location = new System.Drawing.Point(271, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 92;
            this.label11.Text = "Answer:";
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
            this.gVData.Location = new System.Drawing.Point(7, 38);
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
            this.gVData.Size = new System.Drawing.Size(544, 192);
            this.gVData.TabIndex = 45;
            this.gVData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVData_CellClick);
            // 
            // tBQues
            // 
            this.tBQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBQues.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBQues.Location = new System.Drawing.Point(7, 303);
            this.tBQues.Margin = new System.Windows.Forms.Padding(7);
            this.tBQues.Multiline = true;
            this.tBQues.Name = "tBQues";
            this.tBQues.Size = new System.Drawing.Size(251, 84);
            this.tBQues.TabIndex = 90;
            this.tBQues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SlateGray;
            this.label12.Location = new System.Drawing.Point(3, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 89;
            this.label12.Text = "Question:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SlateGray;
            this.label13.Location = new System.Drawing.Point(3, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 87;
            this.label13.Text = "No:";
            // 
            // paneIns
            // 
            this.paneIns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIns.Controls.Add(this.panel1);
            this.paneIns.Controls.Add(this.label6);
            this.paneIns.ForeColor = System.Drawing.Color.White;
            this.paneIns.Location = new System.Drawing.Point(225, 21);
            this.paneIns.Name = "paneIns";
            this.paneIns.Size = new System.Drawing.Size(563, 425);
            this.paneIns.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(28, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 291);
            this.panel1.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(194, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 84;
            this.label6.Text = "INSTRUCTIONS:";
            // 
            // btnRefDet
            // 
            this.btnRefDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefDet.FlatAppearance.BorderSize = 0;
            this.btnRefDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefDet.ForeColor = System.Drawing.Color.Red;
            this.btnRefDet.Image = global::PROJ_admin_.Properties.Resources.Button_Refresh_icon24;
            this.btnRefDet.Location = new System.Drawing.Point(175, 17);
            this.btnRefDet.Name = "btnRefDet";
            this.btnRefDet.Size = new System.Drawing.Size(29, 29);
            this.btnRefDet.TabIndex = 84;
            this.btnRefDet.UseVisualStyleBackColor = true;
            this.btnRefDet.Click += new System.EventHandler(this.btnRefDet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Image = global::PROJ_admin_.Properties.Resources.Add_icon;
            this.btnAdd.Location = new System.Drawing.Point(275, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 29);
            this.btnAdd.TabIndex = 95;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // btnDropIden
            // 
            this.btnDropIden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropIden.FlatAppearance.BorderSize = 0;
            this.btnDropIden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropIden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropIden.ForeColor = System.Drawing.Color.Red;
            this.btnDropIden.Image = global::PROJ_admin_.Properties.Resources.trash24;
            this.btnDropIden.Location = new System.Drawing.Point(524, 236);
            this.btnDropIden.Name = "btnDropIden";
            this.btnDropIden.Size = new System.Drawing.Size(29, 29);
            this.btnDropIden.TabIndex = 83;
            this.btnDropIden.UseVisualStyleBackColor = true;
            this.btnDropIden.Click += new System.EventHandler(this.btnDropIden_Click);
            // 
            // btnRefIden
            // 
            this.btnRefIden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefIden.FlatAppearance.BorderSize = 0;
            this.btnRefIden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefIden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefIden.ForeColor = System.Drawing.Color.Red;
            this.btnRefIden.Image = global::PROJ_admin_.Properties.Resources.Button_Refresh_icon24;
            this.btnRefIden.Location = new System.Drawing.Point(522, 3);
            this.btnRefIden.Name = "btnRefIden";
            this.btnRefIden.Size = new System.Drawing.Size(29, 29);
            this.btnRefIden.TabIndex = 82;
            this.btnRefIden.UseVisualStyleBackColor = true;
            // 
            // pBClose
            // 
            this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClose.Image = global::PROJ_admin_.Properties.Resources.x_mark_32;
            this.pBClose.Location = new System.Drawing.Point(12, 12);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(27, 23);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBClose.TabIndex = 7;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // frmQues
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
            this.Name = "frmQues";
            this.Text = "frmQues";
            this.Load += new System.EventHandler(this.frmQues_Load);
            this.paneMain.ResumeLayout(false);
            this.gBQues.ResumeLayout(false);
            this.gBQues.PerformLayout();
            this.gBDet.ResumeLayout(false);
            this.gBDet.PerformLayout();
            this.paneQues.ResumeLayout(false);
            this.paneQues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVData)).EndInit();
            this.paneIns.ResumeLayout(false);
            this.paneIns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBQues;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.GroupBox gBDet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cBSub;
        private System.Windows.Forms.ComboBox cBPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDropIden;
        private System.Windows.Forms.Panel paneIns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBSet;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Button btnRefDet;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Panel paneQues;
        private System.Windows.Forms.DataGridView gVData;
        private System.Windows.Forms.Button btnRefIden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBAns;
        private System.Windows.Forms.TextBox tBQues;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown btnNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCho;
        private System.Windows.Forms.TextBox lblType;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
    }
}