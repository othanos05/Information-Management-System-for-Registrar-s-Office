namespace RegSys
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pbox = new System.Windows.Forms.PictureBox();
            this.appointmentBTN = new System.Windows.Forms.Button();
            this.profileBTN = new System.Windows.Forms.Button();
            this.aboutBTN = new System.Windows.Forms.Button();
            this.dashboardBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.Image = ((System.Drawing.Image)(resources.GetObject("pbox.Image")));
            this.pbox.Location = new System.Drawing.Point(21, 12);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(100, 100);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 19;
            this.pbox.TabStop = false;
            // 
            // appointmentBTN
            // 
            this.appointmentBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBTN.Location = new System.Drawing.Point(440, 31);
            this.appointmentBTN.Name = "appointmentBTN";
            this.appointmentBTN.Size = new System.Drawing.Size(295, 60);
            this.appointmentBTN.TabIndex = 18;
            this.appointmentBTN.Text = "APPOINTMENT";
            this.appointmentBTN.UseVisualStyleBackColor = true;
            this.appointmentBTN.Click += new System.EventHandler(this.appointmentBTN_Click);
            // 
            // profileBTN
            // 
            this.profileBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBTN.Location = new System.Drawing.Point(741, 31);
            this.profileBTN.Name = "profileBTN";
            this.profileBTN.Size = new System.Drawing.Size(295, 60);
            this.profileBTN.TabIndex = 17;
            this.profileBTN.Text = "PROFILE";
            this.profileBTN.UseVisualStyleBackColor = true;
            this.profileBTN.Click += new System.EventHandler(this.profileBTN_Click);
            // 
            // aboutBTN
            // 
            this.aboutBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.aboutBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBTN.Location = new System.Drawing.Point(1042, 31);
            this.aboutBTN.Name = "aboutBTN";
            this.aboutBTN.Size = new System.Drawing.Size(295, 60);
            this.aboutBTN.TabIndex = 16;
            this.aboutBTN.Text = "ABOUT";
            this.aboutBTN.UseVisualStyleBackColor = false;
            this.aboutBTN.Click += new System.EventHandler(this.aboutBTN_Click);
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.Location = new System.Drawing.Point(139, 31);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(295, 60);
            this.dashboardBTN.TabIndex = 15;
            this.dashboardBTN.Text = "DASHBOARD";
            this.dashboardBTN.UseVisualStyleBackColor = true;
            this.dashboardBTN.Click += new System.EventHandler(this.dashboardBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 222);
            this.label1.TabIndex = 20;
            this.label1.Text = "      The Information Management \r\nSystem for Registrar\'s Office is \r\ndeveloped t" +
    "o provide a standalone \r\napplication to help the registrar\'s\r\n office on managin" +
    "g student\r\nacademic records. \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 192);
            this.label2.TabIndex = 21;
            this.label2.Text = "DEVELOPERS:\r\n\r\nDayao, Jericho\r\nLarida, John Emerson\r\nRapiza, Jonathan\r\nSulit, Les" +
    "ter Niel\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(194, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 539);
            this.panel1.TabIndex = 22;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.appointmentBTN);
            this.Controls.Add(this.profileBTN);
            this.Controls.Add(this.aboutBTN);
            this.Controls.Add(this.dashboardBTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button appointmentBTN;
        private System.Windows.Forms.Button profileBTN;
        private System.Windows.Forms.Button aboutBTN;
        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}