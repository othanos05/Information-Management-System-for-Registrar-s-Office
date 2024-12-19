namespace RegSys
{
    partial class ManUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManUser));
            this.label2 = new System.Windows.Forms.Label();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.mubtn = new System.Windows.Forms.Button();
            this.thbtn = new System.Windows.Forms.Button();
            this.mabtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.pfpbox = new System.Windows.Forms.PictureBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(885, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search";
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(974, 111);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(338, 44);
            this.searchtb.TabIndex = 16;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // mubtn
            // 
            this.mubtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mubtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.mubtn.Location = new System.Drawing.Point(596, 106);
            this.mubtn.Name = "mubtn";
            this.mubtn.Size = new System.Drawing.Size(270, 55);
            this.mubtn.TabIndex = 15;
            this.mubtn.Text = "MANAGE USERS";
            this.mubtn.UseVisualStyleBackColor = false;
            this.mubtn.Click += new System.EventHandler(this.mubtn_Click);
            // 
            // thbtn
            // 
            this.thbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thbtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.thbtn.Location = new System.Drawing.Point(320, 106);
            this.thbtn.Name = "thbtn";
            this.thbtn.Size = new System.Drawing.Size(270, 55);
            this.thbtn.TabIndex = 14;
            this.thbtn.Text = "TRANSACTION HISTORY";
            this.thbtn.UseVisualStyleBackColor = false;
            this.thbtn.Click += new System.EventHandler(this.thbtn_Click);
            // 
            // mabtn
            // 
            this.mabtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mabtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.mabtn.Location = new System.Drawing.Point(44, 106);
            this.mabtn.Name = "mabtn";
            this.mabtn.Size = new System.Drawing.Size(270, 55);
            this.mabtn.TabIndex = 13;
            this.mabtn.Text = "MANAGE APPOINTMENTS\r\n";
            this.mabtn.UseVisualStyleBackColor = false;
            this.mabtn.Click += new System.EventHandler(this.mabtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 85);
            this.panel1.TabIndex = 12;
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
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvUser.ColumnHeadersHeight = 50;
            this.dgvUser.Location = new System.Drawing.Point(44, 167);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(1063, 517);
            this.dgvUser.TabIndex = 18;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pfpbox
            // 
            this.pfpbox.BackColor = System.Drawing.Color.CadetBlue;
            this.pfpbox.Image = ((System.Drawing.Image)(resources.GetObject("pfpbox.Image")));
            this.pfpbox.Location = new System.Drawing.Point(1265, 12);
            this.pfpbox.Name = "pfpbox";
            this.pfpbox.Size = new System.Drawing.Size(72, 61);
            this.pfpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pfpbox.TabIndex = 19;
            this.pfpbox.TabStop = false;
            this.pfpbox.Click += new System.EventHandler(this.pfpbox_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.addbtn.Location = new System.Drawing.Point(1123, 194);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(214, 55);
            this.addbtn.TabIndex = 20;
            this.addbtn.Text = "CREATE ACCOUNT";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold);
            this.deletebtn.Location = new System.Drawing.Point(1123, 255);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(214, 55);
            this.deletebtn.TabIndex = 21;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // ManUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.pfpbox);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.mubtn);
            this.Controls.Add(this.thbtn);
            this.Controls.Add(this.mabtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManUser";
            this.Text = "ManUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Button mubtn;
        private System.Windows.Forms.Button thbtn;
        private System.Windows.Forms.Button mabtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.PictureBox pfpbox;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}