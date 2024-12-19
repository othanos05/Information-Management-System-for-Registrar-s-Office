namespace RegSys
{
    partial class TranHis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranHis));
            this.label2 = new System.Windows.Forms.Label();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.mubtn = new System.Windows.Forms.Button();
            this.thbtn = new System.Windows.Forms.Button();
            this.mabtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.dgvTranHis = new System.Windows.Forms.DataGridView();
            this.pfpbox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranHis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(885, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search";
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(974, 111);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(338, 44);
            this.searchtb.TabIndex = 10;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // mubtn
            // 
            this.mubtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mubtn.Location = new System.Drawing.Point(596, 106);
            this.mubtn.Name = "mubtn";
            this.mubtn.Size = new System.Drawing.Size(270, 55);
            this.mubtn.TabIndex = 9;
            this.mubtn.Text = "MANAGE USERS";
            this.mubtn.UseVisualStyleBackColor = true;
            this.mubtn.Click += new System.EventHandler(this.mubtn_Click);
            // 
            // thbtn
            // 
            this.thbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.thbtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thbtn.Location = new System.Drawing.Point(320, 106);
            this.thbtn.Name = "thbtn";
            this.thbtn.Size = new System.Drawing.Size(270, 55);
            this.thbtn.TabIndex = 8;
            this.thbtn.Text = "TRANSACTION HISTORY";
            this.thbtn.UseVisualStyleBackColor = false;
            this.thbtn.Click += new System.EventHandler(this.thbtn_Click);
            // 
            // mabtn
            // 
            this.mabtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mabtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mabtn.Location = new System.Drawing.Point(44, 106);
            this.mabtn.Name = "mabtn";
            this.mabtn.Size = new System.Drawing.Size(270, 55);
            this.mabtn.TabIndex = 7;
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
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // dgvTranHis
            // 
            this.dgvTranHis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTranHis.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvTranHis.ColumnHeadersHeight = 50;
            this.dgvTranHis.Location = new System.Drawing.Point(44, 167);
            this.dgvTranHis.Name = "dgvTranHis";
            this.dgvTranHis.Size = new System.Drawing.Size(1063, 517);
            this.dgvTranHis.TabIndex = 12;
            // 
            // pfpbox
            // 
            this.pfpbox.BackColor = System.Drawing.Color.CadetBlue;
            this.pfpbox.Image = ((System.Drawing.Image)(resources.GetObject("pfpbox.Image")));
            this.pfpbox.Location = new System.Drawing.Point(1265, 12);
            this.pfpbox.Name = "pfpbox";
            this.pfpbox.Size = new System.Drawing.Size(72, 61);
            this.pfpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pfpbox.TabIndex = 13;
            this.pfpbox.TabStop = false;
            this.pfpbox.Click += new System.EventHandler(this.pfpbox_Click);
            // 
            // TranHis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pfpbox);
            this.Controls.Add(this.dgvTranHis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.mubtn);
            this.Controls.Add(this.thbtn);
            this.Controls.Add(this.mabtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TranHis";
            this.Text = "TranHis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TranHis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranHis)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTranHis;
        private System.Windows.Forms.PictureBox pfpbox;
    }
}