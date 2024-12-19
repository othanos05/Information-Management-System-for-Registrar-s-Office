namespace RegSys
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.picsave = new System.Windows.Forms.Button();
            this.picupload = new System.Windows.Forms.Button();
            this.emailsave = new System.Windows.Forms.Button();
            this.contactsave = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.IDtb = new System.Windows.Forms.TextBox();
            this.yearsecTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.emailEditbtn = new System.Windows.Forms.Button();
            this.contactEditbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpbox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.thbtn = new System.Windows.Forms.Button();
            this.mabtn = new System.Windows.Forms.Button();
            this.mubtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpbox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.CadetBlue;
            this.picturebox.Image = ((System.Drawing.Image)(resources.GetObject("picturebox.Image")));
            this.picturebox.Location = new System.Drawing.Point(1265, 16);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(72, 61);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 21;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.pfpbox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picturebox);
            this.panel1.Controls.Add(this.pbox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 85);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(97, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar\'s Office";
            // 
            // pbox
            // 
            this.pbox.Image = ((System.Drawing.Image)(resources.GetObject("pbox.Image")));
            this.pbox.Location = new System.Drawing.Point(3, 3);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(88, 79);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold);
            this.logoutbtn.Location = new System.Drawing.Point(513, 468);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(304, 43);
            this.logoutbtn.TabIndex = 72;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // picsave
            // 
            this.picsave.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picsave.Location = new System.Drawing.Point(130, 281);
            this.picsave.Name = "picsave";
            this.picsave.Size = new System.Drawing.Size(109, 29);
            this.picsave.TabIndex = 71;
            this.picsave.Text = "SAVE";
            this.picsave.UseVisualStyleBackColor = true;
            this.picsave.Click += new System.EventHandler(this.picsave_Click);
            // 
            // picupload
            // 
            this.picupload.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picupload.Location = new System.Drawing.Point(130, 249);
            this.picupload.Name = "picupload";
            this.picupload.Size = new System.Drawing.Size(109, 29);
            this.picupload.TabIndex = 70;
            this.picupload.Text = "UPLOAD";
            this.picupload.UseVisualStyleBackColor = true;
            this.picupload.Click += new System.EventHandler(this.picupload_Click);
            // 
            // emailsave
            // 
            this.emailsave.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailsave.Location = new System.Drawing.Point(701, 401);
            this.emailsave.Name = "emailsave";
            this.emailsave.Size = new System.Drawing.Size(77, 29);
            this.emailsave.TabIndex = 69;
            this.emailsave.Text = "SAVE";
            this.emailsave.UseVisualStyleBackColor = true;
            this.emailsave.Click += new System.EventHandler(this.emailsave_Click);
            // 
            // contactsave
            // 
            this.contactsave.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsave.Location = new System.Drawing.Point(701, 328);
            this.contactsave.Name = "contactsave";
            this.contactsave.Size = new System.Drawing.Size(77, 29);
            this.contactsave.TabIndex = 68;
            this.contactsave.Text = "SAVE";
            this.contactsave.UseVisualStyleBackColor = true;
            this.contactsave.Click += new System.EventHandler(this.contactsave_Click);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(320, 401);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(280, 31);
            this.emailTB.TabIndex = 67;
            // 
            // contactTB
            // 
            this.contactTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTB.Location = new System.Drawing.Point(320, 328);
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(281, 31);
            this.contactTB.TabIndex = 66;
            // 
            // IDtb
            // 
            this.IDtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtb.Location = new System.Drawing.Point(319, 257);
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(280, 31);
            this.IDtb.TabIndex = 65;
            // 
            // yearsecTB
            // 
            this.yearsecTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsecTB.Location = new System.Drawing.Point(320, 152);
            this.yearsecTB.Name = "yearsecTB";
            this.yearsecTB.Size = new System.Drawing.Size(214, 31);
            this.yearsecTB.TabIndex = 64;
            this.yearsecTB.TextChanged += new System.EventHandler(this.yearsecTB_TextChanged);
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(319, 66);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(609, 80);
            this.nameTB.TabIndex = 63;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // emailEditbtn
            // 
            this.emailEditbtn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailEditbtn.Location = new System.Drawing.Point(618, 401);
            this.emailEditbtn.Name = "emailEditbtn";
            this.emailEditbtn.Size = new System.Drawing.Size(77, 29);
            this.emailEditbtn.TabIndex = 62;
            this.emailEditbtn.Text = "EDIT";
            this.emailEditbtn.UseVisualStyleBackColor = true;
            this.emailEditbtn.Click += new System.EventHandler(this.emailEditbtn_Click);
            // 
            // contactEditbtn
            // 
            this.contactEditbtn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactEditbtn.Location = new System.Drawing.Point(618, 328);
            this.contactEditbtn.Name = "contactEditbtn";
            this.contactEditbtn.Size = new System.Drawing.Size(77, 29);
            this.contactEditbtn.TabIndex = 61;
            this.contactEditbtn.Text = "EDIT";
            this.contactEditbtn.UseVisualStyleBackColor = true;
            this.contactEditbtn.Click += new System.EventHandler(this.contactEditbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Email Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Contact Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dpbox
            // 
            this.dpbox.Location = new System.Drawing.Point(90, 38);
            this.dpbox.Name = "dpbox";
            this.dpbox.Size = new System.Drawing.Size(195, 194);
            this.dpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dpbox.TabIndex = 57;
            this.dpbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Student ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.logoutbtn);
            this.panel2.Controls.Add(this.picsave);
            this.panel2.Controls.Add(this.picupload);
            this.panel2.Controls.Add(this.emailsave);
            this.panel2.Controls.Add(this.contactsave);
            this.panel2.Controls.Add(this.emailTB);
            this.panel2.Controls.Add(this.contactTB);
            this.panel2.Controls.Add(this.IDtb);
            this.panel2.Controls.Add(this.yearsecTB);
            this.panel2.Controls.Add(this.nameTB);
            this.panel2.Controls.Add(this.emailEditbtn);
            this.panel2.Controls.Add(this.contactEditbtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dpbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(163, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 629);
            this.panel2.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(191, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 43);
            this.button1.TabIndex = 73;
            this.button1.Text = "CHANGE PASSWORD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thbtn
            // 
            this.thbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thbtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.thbtn.Location = new System.Drawing.Point(557, 117);
            this.thbtn.Name = "thbtn";
            this.thbtn.Size = new System.Drawing.Size(270, 55);
            this.thbtn.TabIndex = 23;
            this.thbtn.Text = "TRANSACTION HISTORY";
            this.thbtn.UseVisualStyleBackColor = false;
            this.thbtn.Click += new System.EventHandler(this.thbtn_Click);
            // 
            // mabtn
            // 
            this.mabtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mabtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.mabtn.Location = new System.Drawing.Point(267, 117);
            this.mabtn.Name = "mabtn";
            this.mabtn.Size = new System.Drawing.Size(270, 55);
            this.mabtn.TabIndex = 22;
            this.mabtn.Text = "MANAGE APPOINTMENTS\r\n";
            this.mabtn.UseVisualStyleBackColor = false;
            this.mabtn.Click += new System.EventHandler(this.mabtn_Click);
            // 
            // mubtn
            // 
            this.mubtn.BackColor = System.Drawing.Color.White;
            this.mubtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.mubtn.Location = new System.Drawing.Point(845, 117);
            this.mubtn.Name = "mubtn";
            this.mubtn.Size = new System.Drawing.Size(270, 55);
            this.mubtn.TabIndex = 24;
            this.mubtn.Text = "MANAGE USERS";
            this.mubtn.UseVisualStyleBackColor = false;
            this.mubtn.Click += new System.EventHandler(this.mubtn_Click);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.thbtn);
            this.Controls.Add(this.mubtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mabtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpbox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button picsave;
        private System.Windows.Forms.Button picupload;
        private System.Windows.Forms.Button emailsave;
        private System.Windows.Forms.Button contactsave;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.TextBox IDtb;
        private System.Windows.Forms.TextBox yearsecTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button emailEditbtn;
        private System.Windows.Forms.Button contactEditbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox dpbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mubtn;
        private System.Windows.Forms.Button thbtn;
        private System.Windows.Forms.Button mabtn;
        private System.Windows.Forms.Button button1;
    }
}