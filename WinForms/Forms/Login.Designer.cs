
namespace WinForms.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Headerpnl = new System.Windows.Forms.Panel();
            this.exitpng = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SignInbtn = new System.Windows.Forms.Button();
            this.passwordpnl = new System.Windows.Forms.Panel();
            this.usernamepnl = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.usernametxb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Sociallbl = new System.Windows.Forms.Label();
            this.Headerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitpng)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Headerpnl
            // 
            this.Headerpnl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Headerpnl.Controls.Add(this.exitpng);
            this.Headerpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpnl.Location = new System.Drawing.Point(0, 0);
            this.Headerpnl.Name = "Headerpnl";
            this.Headerpnl.Size = new System.Drawing.Size(444, 30);
            this.Headerpnl.TabIndex = 0;
            this.Headerpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Headerpnl_Paint);
            this.Headerpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Headerpnl_MouseDown);
            this.Headerpnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Headerpnl_MouseMove);
            this.Headerpnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Headerpnl_MouseUp);
            // 
            // exitpng
            // 
            this.exitpng.Image = ((System.Drawing.Image)(resources.GetObject("exitpng.Image")));
            this.exitpng.Location = new System.Drawing.Point(390, 0);
            this.exitpng.Name = "exitpng";
            this.exitpng.Size = new System.Drawing.Size(54, 31);
            this.exitpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitpng.TabIndex = 2;
            this.exitpng.TabStop = false;
            this.exitpng.Click += new System.EventHandler(this.exitpng_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 134);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 134);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.SignInbtn);
            this.panel2.Controls.Add(this.passwordpnl);
            this.panel2.Controls.Add(this.usernamepnl);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.registerbtn);
            this.panel2.Controls.Add(this.passwordtxb);
            this.panel2.Controls.Add(this.usernametxb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 264);
            this.panel2.TabIndex = 2;
            // 
            // SignInbtn
            // 
            this.SignInbtn.BackColor = System.Drawing.Color.Red;
            this.SignInbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignInbtn.FlatAppearance.BorderSize = 0;
            this.SignInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignInbtn.ForeColor = System.Drawing.Color.White;
            this.SignInbtn.Location = new System.Drawing.Point(73, 136);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.Size = new System.Drawing.Size(312, 61);
            this.SignInbtn.TabIndex = 24;
            this.SignInbtn.Text = "SIGN IN";
            this.SignInbtn.UseVisualStyleBackColor = false;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // passwordpnl
            // 
            this.passwordpnl.BackColor = System.Drawing.Color.Black;
            this.passwordpnl.Location = new System.Drawing.Point(73, 95);
            this.passwordpnl.Name = "passwordpnl";
            this.passwordpnl.Size = new System.Drawing.Size(314, 1);
            this.passwordpnl.TabIndex = 23;
            // 
            // usernamepnl
            // 
            this.usernamepnl.BackColor = System.Drawing.Color.Black;
            this.usernamepnl.Location = new System.Drawing.Point(73, 61);
            this.usernamepnl.Name = "usernamepnl";
            this.usernamepnl.Size = new System.Drawing.Size(314, 1);
            this.usernamepnl.TabIndex = 21;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(71, 68);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(73, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.Orange;
            this.registerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerbtn.FlatAppearance.BorderSize = 0;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerbtn.ForeColor = System.Drawing.Color.White;
            this.registerbtn.Location = new System.Drawing.Point(289, 222);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(96, 32);
            this.registerbtn.TabIndex = 17;
            this.registerbtn.Text = "REGISTER";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // passwordtxb
            // 
            this.passwordtxb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.passwordtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordtxb.ForeColor = System.Drawing.Color.Black;
            this.passwordtxb.Location = new System.Drawing.Point(116, 70);
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.PlaceholderText = "Password";
            this.passwordtxb.Size = new System.Drawing.Size(271, 19);
            this.passwordtxb.TabIndex = 16;
            this.passwordtxb.UseSystemPasswordChar = true;
            // 
            // usernametxb
            // 
            this.usernametxb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.usernametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernametxb.ForeColor = System.Drawing.Color.Black;
            this.usernametxb.Location = new System.Drawing.Point(114, 40);
            this.usernametxb.Multiline = true;
            this.usernametxb.Name = "usernametxb";
            this.usernametxb.PlaceholderText = "Username";
            this.usernametxb.Size = new System.Drawing.Size(271, 24);
            this.usernametxb.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.Sociallbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 213);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(114, 151);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(241, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(117, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(241, 151);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // Sociallbl
            // 
            this.Sociallbl.AutoSize = true;
            this.Sociallbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sociallbl.Location = new System.Drawing.Point(112, 29);
            this.Sociallbl.Name = "Sociallbl";
            this.Sociallbl.Size = new System.Drawing.Size(229, 25);
            this.Sociallbl.TabIndex = 7;
            this.Sociallbl.Text = "Social Media Accounts";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 637);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Headerpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Headerpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitpng)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headerpnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exitpng;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel passwordpnl;
        private System.Windows.Forms.Panel usernamepnl;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox passwordtxb;
        private System.Windows.Forms.TextBox usernametxb;
        private System.Windows.Forms.Button SignInbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Sociallbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}