namespace PROJ_admin_
{
    partial class frmSet
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
            this.paneMain = new System.Windows.Forms.Panel();
            this.gBSet = new System.Windows.Forms.GroupBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.tBUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.paneCode = new System.Windows.Forms.Panel();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBFold = new System.Windows.Forms.TextBox();
            this.lblFold = new System.Windows.Forms.Label();
            this.pBOk = new System.Windows.Forms.PictureBox();
            this.btnBrow = new System.Windows.Forms.Button();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.paneMain.SuspendLayout();
            this.gBSet.SuspendLayout();
            this.paneCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.Controls.Add(this.gBSet);
            this.paneMain.Controls.Add(this.pBClose);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Margin = new System.Windows.Forms.Padding(4);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(750, 548);
            this.paneMain.TabIndex = 0;
            // 
            // gBSet
            // 
            this.gBSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBSet.Controls.Add(this.lblPass);
            this.gBSet.Controls.Add(this.pBOk);
            this.gBSet.Controls.Add(this.tBPass);
            this.gBSet.Controls.Add(this.tBUser);
            this.gBSet.Controls.Add(this.label5);
            this.gBSet.Controls.Add(this.label4);
            this.gBSet.Controls.Add(this.btnSave);
            this.gBSet.Controls.Add(this.btnBrow);
            this.gBSet.Controls.Add(this.paneCode);
            this.gBSet.Controls.Add(this.btnVer);
            this.gBSet.Controls.Add(this.tBEmail);
            this.gBSet.Controls.Add(this.label2);
            this.gBSet.Controls.Add(this.tBFold);
            this.gBSet.Controls.Add(this.lblFold);
            this.gBSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSet.ForeColor = System.Drawing.Color.White;
            this.gBSet.Location = new System.Drawing.Point(102, 86);
            this.gBSet.Name = "gBSet";
            this.gBSet.Size = new System.Drawing.Size(547, 376);
            this.gBSet.TabIndex = 6;
            this.gBSet.TabStop = false;
            this.gBSet.Text = "Current Settings:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Red;
            this.lblPass.Location = new System.Drawing.Point(257, 164);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(50, 16);
            this.lblPass.TabIndex = 62;
            this.lblPass.Text = "label14";
            this.lblPass.Visible = false;
            // 
            // tBPass
            // 
            this.tBPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBPass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tBPass.Location = new System.Drawing.Point(260, 132);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(189, 29);
            this.tBPass.TabIndex = 60;
            this.tBPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBPass.Enter += new System.EventHandler(this.tBPass_Enter);
            this.tBPass.Leave += new System.EventHandler(this.tBPass_Leave);
            // 
            // tBUser
            // 
            this.tBUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tBUser.Location = new System.Drawing.Point(260, 88);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(189, 29);
            this.tBUser.TabIndex = 59;
            this.tBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(143, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(143, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Username:";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Location = new System.Drawing.Point(147, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(353, 27);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "UPDATE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // paneCode
            // 
            this.paneCode.Controls.Add(this.tBCode);
            this.paneCode.Controls.Add(this.label3);
            this.paneCode.Location = new System.Drawing.Point(6, 280);
            this.paneCode.Name = "paneCode";
            this.paneCode.Size = new System.Drawing.Size(253, 39);
            this.paneCode.TabIndex = 52;
            this.paneCode.Visible = false;
            // 
            // tBCode
            // 
            this.tBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBCode.ForeColor = System.Drawing.Color.Lime;
            this.tBCode.Location = new System.Drawing.Point(141, 3);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(99, 29);
            this.tBCode.TabIndex = 13;
            this.tBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Code:";
            // 
            // btnVer
            // 
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Lime;
            this.btnVer.Location = new System.Drawing.Point(409, 287);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(91, 27);
            this.btnVer.TabIndex = 51;
            this.btnVer.Text = "CHANGE";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // tBEmail
            // 
            this.tBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBEmail.Location = new System.Drawing.Point(147, 248);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(353, 26);
            this.tBEmail.TabIndex = 12;
            this.tBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBEmail_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(17, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email:";
            // 
            // tBFold
            // 
            this.tBFold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tBFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFold.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBFold.Location = new System.Drawing.Point(147, 213);
            this.tBFold.Name = "tBFold";
            this.tBFold.Size = new System.Drawing.Size(353, 26);
            this.tBFold.TabIndex = 10;
            this.tBFold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFold
            // 
            this.lblFold.AutoSize = true;
            this.lblFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFold.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFold.Location = new System.Drawing.Point(17, 213);
            this.lblFold.Name = "lblFold";
            this.lblFold.Size = new System.Drawing.Size(124, 24);
            this.lblFold.TabIndex = 1;
            this.lblFold.Text = "Folder Path:";
            // 
            // pBOk
            // 
            this.pBOk.Image = global::PROJ_admin_.Properties.Resources.Ok_icon__1_;
            this.pBOk.Location = new System.Drawing.Point(506, 246);
            this.pBOk.Name = "pBOk";
            this.pBOk.Size = new System.Drawing.Size(30, 30);
            this.pBOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBOk.TabIndex = 61;
            this.pBOk.TabStop = false;
            // 
            // btnBrow
            // 
            this.btnBrow.FlatAppearance.BorderSize = 0;
            this.btnBrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrow.Image = global::PROJ_admin_.Properties.Resources.Folder_Generic_Green_icon;
            this.btnBrow.Location = new System.Drawing.Point(506, 210);
            this.btnBrow.Name = "btnBrow";
            this.btnBrow.Size = new System.Drawing.Size(30, 30);
            this.btnBrow.TabIndex = 54;
            this.btnBrow.UseVisualStyleBackColor = true;
            this.btnBrow.Click += new System.EventHandler(this.btnBrow_Click);
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
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // frmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(750, 548);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSet";
            this.Text = "frmSet";
            this.Load += new System.EventHandler(this.frmSet_Load);
            this.paneMain.ResumeLayout(false);
            this.gBSet.ResumeLayout(false);
            this.gBSet.PerformLayout();
            this.paneCode.ResumeLayout(false);
            this.paneCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.GroupBox gBSet;
        private System.Windows.Forms.Label lblFold;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBFold;
        private System.Windows.Forms.Panel paneCode;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.TextBox tBUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pBOk;
        private System.Windows.Forms.Label lblPass;
    }
}