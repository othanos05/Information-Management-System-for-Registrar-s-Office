namespace RegSys
{
    partial class Appointment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_Form));
            this.pbox = new System.Windows.Forms.PictureBox();
            this.appointmentBTN = new System.Windows.Forms.Button();
            this.profileBTN = new System.Windows.Forms.Button();
            this.aboutBTN = new System.Windows.Forms.Button();
            this.dashboardBTN = new System.Windows.Forms.Button();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.submitbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.dgvdocs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbox.ErrorImage")));
            this.pbox.Image = ((System.Drawing.Image)(resources.GetObject("pbox.Image")));
            this.pbox.Location = new System.Drawing.Point(21, 12);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(100, 100);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 9;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // appointmentBTN
            // 
            this.appointmentBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.appointmentBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBTN.Location = new System.Drawing.Point(440, 31);
            this.appointmentBTN.Name = "appointmentBTN";
            this.appointmentBTN.Size = new System.Drawing.Size(295, 60);
            this.appointmentBTN.TabIndex = 8;
            this.appointmentBTN.Text = "APPOINTMENT";
            this.appointmentBTN.UseVisualStyleBackColor = false;
            this.appointmentBTN.Click += new System.EventHandler(this.appointmentBTN_Click);
            // 
            // profileBTN
            // 
            this.profileBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBTN.Location = new System.Drawing.Point(741, 31);
            this.profileBTN.Name = "profileBTN";
            this.profileBTN.Size = new System.Drawing.Size(295, 60);
            this.profileBTN.TabIndex = 7;
            this.profileBTN.Text = "PROFILE";
            this.profileBTN.UseVisualStyleBackColor = true;
            this.profileBTN.Click += new System.EventHandler(this.profileBTN_Click);
            // 
            // aboutBTN
            // 
            this.aboutBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBTN.Location = new System.Drawing.Point(1042, 31);
            this.aboutBTN.Name = "aboutBTN";
            this.aboutBTN.Size = new System.Drawing.Size(295, 60);
            this.aboutBTN.TabIndex = 6;
            this.aboutBTN.Text = "ABOUT";
            this.aboutBTN.UseVisualStyleBackColor = true;
            this.aboutBTN.Click += new System.EventHandler(this.aboutBTN_Click);
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.Location = new System.Drawing.Point(139, 31);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(295, 60);
            this.dashboardBTN.TabIndex = 5;
            this.dashboardBTN.Text = "DASHBOARD";
            this.dashboardBTN.UseVisualStyleBackColor = true;
            this.dashboardBTN.Click += new System.EventHandler(this.dashboardBTN_Click);
            // 
            // clb
            // 
            this.clb.BackColor = System.Drawing.Color.CadetBlue;
            this.clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(35, 158);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(399, 184);
            this.clb.TabIndex = 10;
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(35, 378);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(399, 20);
            this.dtp.TabIndex = 11;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(139, 454);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(185, 45);
            this.submitbtn.TabIndex = 12;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click_1);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(139, 505);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(185, 45);
            this.clearbtn.TabIndex = 13;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click_1);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(139, 556);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(185, 45);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click_1);
            // 
            // dgvdocs
            // 
            this.dgvdocs.AllowUserToAddRows = false;
            this.dgvdocs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdocs.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvdocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdocs.Location = new System.Drawing.Point(454, 158);
            this.dgvdocs.Name = "dgvdocs";
            this.dgvdocs.ReadOnly = true;
            this.dgvdocs.Size = new System.Drawing.Size(883, 550);
            this.dgvdocs.TabIndex = 15;
            this.dgvdocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdocs_CellContentClick);
            // 
            // Appointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dgvdocs);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.clb);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.appointmentBTN);
            this.Controls.Add(this.profileBTN);
            this.Controls.Add(this.aboutBTN);
            this.Controls.Add(this.dashboardBTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Appointment_Form";
            this.Text = "Appointment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Appointment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button appointmentBTN;
        private System.Windows.Forms.Button profileBTN;
        private System.Windows.Forms.Button aboutBTN;
        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView dgvdocs;
    }
}