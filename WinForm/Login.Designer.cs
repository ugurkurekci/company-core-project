
namespace WinForm
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
            this.panelsaydam = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SingIn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Passwordtxb = new System.Windows.Forms.TextBox();
            this.Usernametxb = new System.Windows.Forms.TextBox();
            this.passwordpng = new System.Windows.Forms.PictureBox();
            this.usernamepng = new System.Windows.Forms.PictureBox();
            this.Imgpicture = new System.Windows.Forms.PictureBox();
            this.Exitpng = new System.Windows.Forms.PictureBox();
            this.Headerlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordpng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamepng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitpng)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsaydam
            // 
            this.panelsaydam.Location = new System.Drawing.Point(308, 160);
            this.panelsaydam.Name = "panelsaydam";
            this.panelsaydam.Size = new System.Drawing.Size(523, 459);
            this.panelsaydam.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.SingIn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelheader);
            this.panel1.Controls.Add(this.Registerbtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Passwordtxb);
            this.panel1.Controls.Add(this.Usernametxb);
            this.panel1.Controls.Add(this.passwordpng);
            this.panel1.Controls.Add(this.usernamepng);
            this.panel1.Controls.Add(this.Imgpicture);
            this.panel1.Controls.Add(this.Exitpng);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 661);
            this.panel1.TabIndex = 2;
            // 
            // SingIn
            // 
            this.SingIn.BackColor = System.Drawing.Color.OrangeRed;
            this.SingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingIn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SingIn.ForeColor = System.Drawing.Color.White;
            this.SingIn.Location = new System.Drawing.Point(38, 435);
            this.SingIn.Name = "SingIn";
            this.SingIn.Size = new System.Drawing.Size(281, 56);
            this.SingIn.TabIndex = 17;
            this.SingIn.Text = "SingIn";
            this.SingIn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(38, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 1);
            this.panel2.TabIndex = 6;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.CadetBlue;
            this.panelheader.Controls.Add(this.Headerlbl);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(363, 25);
            this.panelheader.TabIndex = 16;
            this.panelheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseDown_1);
            this.panelheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseMove_1);
            this.panelheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseUp);
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Registerbtn.ForeColor = System.Drawing.Color.White;
            this.Registerbtn.Location = new System.Drawing.Point(42, 529);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(281, 56);
            this.Registerbtn.TabIndex = 9;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(38, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 1);
            this.panel3.TabIndex = 7;
            // 
            // Passwordtxb
            // 
            this.Passwordtxb.BackColor = System.Drawing.Color.DarkCyan;
            this.Passwordtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passwordtxb.ForeColor = System.Drawing.Color.White;
            this.Passwordtxb.Location = new System.Drawing.Point(91, 367);
            this.Passwordtxb.Name = "Passwordtxb";
            this.Passwordtxb.PlaceholderText = "Password";
            this.Passwordtxb.Size = new System.Drawing.Size(214, 19);
            this.Passwordtxb.TabIndex = 6;
            this.Passwordtxb.UseSystemPasswordChar = true;
            this.Passwordtxb.TextChanged += new System.EventHandler(this.Passwordtxb_TextChanged_1);
            // 
            // Usernametxb
            // 
            this.Usernametxb.BackColor = System.Drawing.Color.DarkCyan;
            this.Usernametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernametxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Usernametxb.ForeColor = System.Drawing.Color.White;
            this.Usernametxb.Location = new System.Drawing.Point(91, 318);
            this.Usernametxb.Multiline = true;
            this.Usernametxb.Name = "Usernametxb";
            this.Usernametxb.PlaceholderText = "Username";
            this.Usernametxb.Size = new System.Drawing.Size(216, 23);
            this.Usernametxb.TabIndex = 4;
            this.Usernametxb.TextChanged += new System.EventHandler(this.Usernametxb_TextChanged_1);
            // 
            // passwordpng
            // 
            this.passwordpng.BackColor = System.Drawing.Color.Transparent;
            this.passwordpng.Image = ((System.Drawing.Image)(resources.GetObject("passwordpng.Image")));
            this.passwordpng.Location = new System.Drawing.Point(40, 350);
            this.passwordpng.Name = "passwordpng";
            this.passwordpng.Size = new System.Drawing.Size(49, 43);
            this.passwordpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordpng.TabIndex = 3;
            this.passwordpng.TabStop = false;
            // 
            // usernamepng
            // 
            this.usernamepng.BackColor = System.Drawing.Color.Transparent;
            this.usernamepng.Image = ((System.Drawing.Image)(resources.GetObject("usernamepng.Image")));
            this.usernamepng.Location = new System.Drawing.Point(40, 301);
            this.usernamepng.Name = "usernamepng";
            this.usernamepng.Size = new System.Drawing.Size(49, 43);
            this.usernamepng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamepng.TabIndex = 2;
            this.usernamepng.TabStop = false;
            // 
            // Imgpicture
            // 
            this.Imgpicture.Image = ((System.Drawing.Image)(resources.GetObject("Imgpicture.Image")));
            this.Imgpicture.Location = new System.Drawing.Point(40, 80);
            this.Imgpicture.Name = "Imgpicture";
            this.Imgpicture.Size = new System.Drawing.Size(285, 172);
            this.Imgpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imgpicture.TabIndex = 1;
            this.Imgpicture.TabStop = false;
            // 
            // Exitpng
            // 
            this.Exitpng.Image = ((System.Drawing.Image)(resources.GetObject("Exitpng.Image")));
            this.Exitpng.Location = new System.Drawing.Point(289, 24);
            this.Exitpng.Name = "Exitpng";
            this.Exitpng.Size = new System.Drawing.Size(71, 50);
            this.Exitpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exitpng.TabIndex = 0;
            this.Exitpng.TabStop = false;
            this.Exitpng.Click += new System.EventHandler(this.Exitpng_Click_1);
            // 
            // Headerlbl
            // 
            this.Headerlbl.AutoSize = true;
            this.Headerlbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Headerlbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.Headerlbl.Location = new System.Drawing.Point(0, 0);
            this.Headerlbl.Name = "Headerlbl";
            this.Headerlbl.Size = new System.Drawing.Size(114, 22);
            this.Headerlbl.TabIndex = 1;
            this.Headerlbl.Text = "Login_Panel";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordpng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamepng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitpng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelsaydam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Passwordtxb;
        private System.Windows.Forms.TextBox Usernametxb;
        private System.Windows.Forms.PictureBox passwordpng;
        private System.Windows.Forms.PictureBox usernamepng;
        private System.Windows.Forms.PictureBox Imgpicture;
        private System.Windows.Forms.PictureBox Exitpng;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button SingIn;
        private System.Windows.Forms.Label Headerlbl;
    }
}