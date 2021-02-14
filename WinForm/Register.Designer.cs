
namespace WinForm
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.exitpng = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Usernametxb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Emailtxb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Passtxb = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Headerlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitpng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelheader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // exitpng
            // 
            this.exitpng.Image = ((System.Drawing.Image)(resources.GetObject("exitpng.Image")));
            this.exitpng.Location = new System.Drawing.Point(284, 24);
            this.exitpng.Name = "exitpng";
            this.exitpng.Size = new System.Drawing.Size(71, 50);
            this.exitpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitpng.TabIndex = 0;
            this.exitpng.TabStop = false;
            this.exitpng.Click += new System.EventHandler(this.Exitpng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Usernametxb
            // 
            this.Usernametxb.BackColor = System.Drawing.Color.DarkCyan;
            this.Usernametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernametxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Usernametxb.ForeColor = System.Drawing.Color.White;
            this.Usernametxb.Location = new System.Drawing.Point(85, 319);
            this.Usernametxb.Multiline = true;
            this.Usernametxb.Name = "Usernametxb";
            this.Usernametxb.PlaceholderText = "Username";
            this.Usernametxb.Size = new System.Drawing.Size(216, 23);
            this.Usernametxb.TabIndex = 4;
            this.Usernametxb.TextChanged += new System.EventHandler(this.Usernametxb_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(36, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 1);
            this.panel2.TabIndex = 5;
            // 
            // Emailtxb
            // 
            this.Emailtxb.BackColor = System.Drawing.Color.DarkCyan;
            this.Emailtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emailtxb.ForeColor = System.Drawing.Color.White;
            this.Emailtxb.Location = new System.Drawing.Point(85, 368);
            this.Emailtxb.Name = "Emailtxb";
            this.Emailtxb.PlaceholderText = "Email";
            this.Emailtxb.Size = new System.Drawing.Size(214, 19);
            this.Emailtxb.TabIndex = 6;
            this.Emailtxb.TextChanged += new System.EventHandler(this.usernamemail_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(32, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 1);
            this.panel3.TabIndex = 7;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.CadetBlue;
            this.panelheader.Controls.Add(this.Headerlbl);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(358, 27);
            this.panelheader.TabIndex = 14;
            this.panelheader.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelheader_Paint);
            this.panelheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panelheader_MouseDown);
            this.panelheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panelheader_MouseMove);
            this.panelheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panelheader_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Passtxb);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.panelheader);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Emailtxb);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Usernametxb);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitpng);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 666);
            this.panel1.TabIndex = 3;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Orange;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(34, 506);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(281, 56);
            this.RegisterBtn.TabIndex = 18;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(32, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 1);
            this.panel4.TabIndex = 17;
            // 
            // Passtxb
            // 
            this.Passtxb.BackColor = System.Drawing.Color.DarkCyan;
            this.Passtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passtxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passtxb.ForeColor = System.Drawing.Color.White;
            this.Passtxb.Location = new System.Drawing.Point(85, 417);
            this.Passtxb.Name = "Passtxb";
            this.Passtxb.PlaceholderText = "Password";
            this.Passtxb.Size = new System.Drawing.Size(214, 19);
            this.Passtxb.TabIndex = 16;
            this.Passtxb.UseSystemPasswordChar = true;
            this.Passtxb.TextChanged += new System.EventHandler(this.usernamepassw_TextChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(34, 400);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 351);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Headerlbl
            // 
            this.Headerlbl.AutoSize = true;
            this.Headerlbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Headerlbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.Headerlbl.Location = new System.Drawing.Point(0, 0);
            this.Headerlbl.Name = "Headerlbl";
            this.Headerlbl.Size = new System.Drawing.Size(140, 22);
            this.Headerlbl.TabIndex = 2;
            this.Headerlbl.Text = "Register_Panel";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(342, 666);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.exitpng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitpng;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Usernametxb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Emailtxb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Passtxb;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label Headerlbl;
    }
}