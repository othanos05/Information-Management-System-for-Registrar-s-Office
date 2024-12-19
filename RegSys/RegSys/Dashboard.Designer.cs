namespace RegSys
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dashboardBTN = new System.Windows.Forms.Button();
            this.aboutBTN = new System.Windows.Forms.Button();
            this.profileBTN = new System.Windows.Forms.Button();
            this.appointmentBTN = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.dashpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.dashpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dashboardBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.Location = new System.Drawing.Point(139, 31);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(295, 60);
            this.dashboardBTN.TabIndex = 0;
            this.dashboardBTN.Text = "DASHBOARD";
            this.dashboardBTN.UseVisualStyleBackColor = false;
            this.dashboardBTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aboutBTN
            // 
            this.aboutBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBTN.Location = new System.Drawing.Point(1042, 31);
            this.aboutBTN.Name = "aboutBTN";
            this.aboutBTN.Size = new System.Drawing.Size(295, 60);
            this.aboutBTN.TabIndex = 1;
            this.aboutBTN.Text = "ABOUT";
            this.aboutBTN.UseVisualStyleBackColor = true;
            this.aboutBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // profileBTN
            // 
            this.profileBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBTN.Location = new System.Drawing.Point(741, 31);
            this.profileBTN.Name = "profileBTN";
            this.profileBTN.Size = new System.Drawing.Size(295, 60);
            this.profileBTN.TabIndex = 2;
            this.profileBTN.Text = "PROFILE";
            this.profileBTN.UseVisualStyleBackColor = true;
            this.profileBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // appointmentBTN
            // 
            this.appointmentBTN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBTN.Location = new System.Drawing.Point(440, 31);
            this.appointmentBTN.Name = "appointmentBTN";
            this.appointmentBTN.Size = new System.Drawing.Size(295, 60);
            this.appointmentBTN.TabIndex = 3;
            this.appointmentBTN.Text = "APPOINTMENT";
            this.appointmentBTN.UseVisualStyleBackColor = true;
            this.appointmentBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // pbox
            // 
            this.pbox.Image = ((System.Drawing.Image)(resources.GetObject("pbox.Image")));
            this.pbox.Location = new System.Drawing.Point(21, 12);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(100, 100);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 4;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // dashpanel
            // 
            this.dashpanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dashpanel.Controls.Add(this.panel1);
            this.dashpanel.Location = new System.Drawing.Point(12, 118);
            this.dashpanel.Name = "dashpanel";
            this.dashpanel.Size = new System.Drawing.Size(1292, 599);
            this.dashpanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO REGISTRAR\'S OFFICE!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 270);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "MISSION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(572, 324);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(62, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 544);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(837, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "VISION";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.appointmentBTN);
            this.Controls.Add(this.profileBTN);
            this.Controls.Add(this.aboutBTN);
            this.Controls.Add(this.dashboardBTN);
            this.Controls.Add(this.dashpanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.dashpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.Button aboutBTN;
        private System.Windows.Forms.Button profileBTN;
        private System.Windows.Forms.Button appointmentBTN;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Panel dashpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}