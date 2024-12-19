namespace RegSys
{
    partial class Form1
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
            this.pbox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.untb = new System.Windows.Forms.TextBox();
            this.pwtb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SPcb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(72, 254);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(240, 228);
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 19.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 19.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // untb
            // 
            this.untb.BackColor = System.Drawing.Color.Honeydew;
            this.untb.Font = new System.Drawing.Font("Lucida Console", 20.25F);
            this.untb.Location = new System.Drawing.Point(17, 139);
            this.untb.Name = "untb";
            this.untb.Size = new System.Drawing.Size(323, 34);
            this.untb.TabIndex = 4;
            this.untb.TextChanged += new System.EventHandler(this.untb_TextChanged);
            // 
            // pwtb
            // 
            this.pwtb.BackColor = System.Drawing.Color.Honeydew;
            this.pwtb.Font = new System.Drawing.Font("Lucida Console", 20.25F);
            this.pwtb.Location = new System.Drawing.Point(17, 234);
            this.pwtb.Name = "pwtb";
            this.pwtb.Size = new System.Drawing.Size(323, 34);
            this.pwtb.TabIndex = 5;
            this.pwtb.TextChanged += new System.EventHandler(this.pwtb_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SPcb
            // 
            this.SPcb.AutoSize = true;
            this.SPcb.BackColor = System.Drawing.Color.Transparent;
            this.SPcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPcb.Location = new System.Drawing.Point(207, 277);
            this.SPcb.Name = "SPcb";
            this.SPcb.Size = new System.Drawing.Size(136, 22);
            this.SPcb.TabIndex = 7;
            this.SPcb.Text = "Show Password";
            this.SPcb.UseVisualStyleBackColor = false;
            this.SPcb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 150);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar\'s\r\n  Office";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(752, -13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 827);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SPcb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.untb);
            this.panel1.Controls.Add(this.pwtb);
            this.panel1.Location = new System.Drawing.Point(112, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 490);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox untb;
        private System.Windows.Forms.TextBox pwtb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SPcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}

