namespace PROJ_stud_
{
    partial class frmStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStud));
            this.paneMain = new System.Windows.Forms.Panel();
            this.gBDet = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBSet = new System.Windows.Forms.TextBox();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneSlide = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tBID = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.paneMain.SuspendLayout();
            this.gBDet.SuspendLayout();
            this.paneLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.paneLogo);
            this.paneMain.Controls.Add(this.gBDet);
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(1078, 700);
            this.paneMain.TabIndex = 0;
            // 
            // gBDet
            // 
            this.gBDet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBDet.Controls.Add(this.btnRef);
            this.gBDet.Controls.Add(this.tBID);
            this.gBDet.Controls.Add(this.label1);
            this.gBDet.Controls.Add(this.tBSet);
            this.gBDet.Controls.Add(this.cBCode);
            this.gBDet.Controls.Add(this.btnStart);
            this.gBDet.Controls.Add(this.label4);
            this.gBDet.Controls.Add(this.label16);
            this.gBDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDet.ForeColor = System.Drawing.Color.White;
            this.gBDet.Location = new System.Drawing.Point(375, 250);
            this.gBDet.Name = "gBDet";
            this.gBDet.Size = new System.Drawing.Size(328, 201);
            this.gBDet.TabIndex = 10;
            this.gBDet.TabStop = false;
            this.gBDet.Text = "Details:";
            this.gBDet.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label16.Location = new System.Drawing.Point(36, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 75;
            this.label16.Text = "StudID:";
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Location = new System.Drawing.Point(198, 151);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 27);
            this.btnStart.TabIndex = 103;
            this.btnStart.Text = "LOGIN";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(36, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Code:";
            // 
            // cBCode
            // 
            this.cBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.cBCode.FormattingEnabled = true;
            this.cBCode.Location = new System.Drawing.Point(113, 108);
            this.cBCode.Name = "cBCode";
            this.cBCode.Size = new System.Drawing.Size(178, 32);
            this.cBCode.TabIndex = 88;
            this.cBCode.SelectedIndexChanged += new System.EventHandler(this.cBCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(36, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Set:";
            // 
            // tBSet
            // 
            this.tBSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSet.ForeColor = System.Drawing.Color.Yellow;
            this.tBSet.Location = new System.Drawing.Point(113, 146);
            this.tBSet.Multiline = true;
            this.tBSet.Name = "tBSet";
            this.tBSet.Size = new System.Drawing.Size(67, 32);
            this.tBSet.TabIndex = 109;
            this.tBSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paneLogo
            // 
            this.paneLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.paneLogo.Controls.Add(this.pictureBox4);
            this.paneLogo.Controls.Add(this.label5);
            this.paneLogo.Controls.Add(this.panel1);
            this.paneLogo.Location = new System.Drawing.Point(562, 593);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(504, 95);
            this.paneLogo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(102, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Exam Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.paneSlide);
            this.panel1.Location = new System.Drawing.Point(108, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 13);
            this.panel1.TabIndex = 2;
            // 
            // paneSlide
            // 
            this.paneSlide.BackColor = System.Drawing.Color.LightSlateGray;
            this.paneSlide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneSlide.ForeColor = System.Drawing.Color.White;
            this.paneSlide.Location = new System.Drawing.Point(266, -1);
            this.paneSlide.Name = "paneSlide";
            this.paneSlide.Size = new System.Drawing.Size(114, 15);
            this.paneSlide.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tBID
            // 
            this.tBID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBID.ForeColor = System.Drawing.Color.White;
            this.tBID.Location = new System.Drawing.Point(113, 70);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(178, 29);
            this.tBID.TabIndex = 110;
            this.tBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBID_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PROJ_stud_.Properties.Resources.cartoon_geeky_nerd_kid_is_typing_notebook_enthusiastically_9633_12;
            this.pictureBox4.Location = new System.Drawing.Point(6, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btnRef
            // 
            this.btnRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRef.Image = global::PROJ_stud_.Properties.Resources.Button_Refresh_icon24;
            this.btnRef.Location = new System.Drawing.Point(291, 15);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(34, 30);
            this.btnRef.TabIndex = 111;
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // pBClose
            // 
            this.pBClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClose.Image = global::PROJ_stud_.Properties.Resources.x_mark_32;
            this.pBClose.Location = new System.Drawing.Point(1032, 12);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(34, 36);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBClose.TabIndex = 9;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // frmStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1078, 700);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.paneMain.ResumeLayout(false);
            this.gBDet.ResumeLayout(false);
            this.gBDet.PerformLayout();
            this.paneLogo.ResumeLayout(false);
            this.paneLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBDet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBSet;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneSlide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Timer timer;
    }
}

