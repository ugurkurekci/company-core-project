
namespace WinForms.Forms.AboutMe
{
    partial class AboutMeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.githublbl = new System.Windows.Forms.TextBox();
            this.linkedinlbl = new System.Windows.Forms.TextBox();
            this.joblbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 13);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 45);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(0, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 80);
            this.label2.TabIndex = 27;
            this.label2.Text = "About Me";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.ForeColor = System.Drawing.Color.Black;
            this.namelbl.Location = new System.Drawing.Point(218, 14);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(60, 22);
            this.namelbl.TabIndex = 22;
            this.namelbl.Text = "Name";
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnamelbl.ForeColor = System.Drawing.Color.Black;
            this.surnamelbl.Location = new System.Drawing.Point(218, 48);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(88, 22);
            this.surnamelbl.TabIndex = 23;
            this.surnamelbl.Text = "Surname";
            this.surnamelbl.Click += new System.EventHandler(this.surnamelbl_Click);
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.agelbl.ForeColor = System.Drawing.Color.Black;
            this.agelbl.Location = new System.Drawing.Point(218, 82);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(42, 22);
            this.agelbl.TabIndex = 24;
            this.agelbl.Text = "Age";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.githublbl);
            this.panel4.Controls.Add(this.linkedinlbl);
            this.panel4.Controls.Add(this.joblbl);
            this.panel4.Controls.Add(this.agelbl);
            this.panel4.Controls.Add(this.namelbl);
            this.panel4.Controls.Add(this.surnamelbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 515);
            this.panel4.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(177, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(468, 135);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // githublbl
            // 
            this.githublbl.BackColor = System.Drawing.Color.White;
            this.githublbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.githublbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.githublbl.Location = new System.Drawing.Point(218, 153);
            this.githublbl.Name = "githublbl";
            this.githublbl.ReadOnly = true;
            this.githublbl.Size = new System.Drawing.Size(427, 19);
            this.githublbl.TabIndex = 31;
            // 
            // linkedinlbl
            // 
            this.linkedinlbl.BackColor = System.Drawing.Color.White;
            this.linkedinlbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkedinlbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkedinlbl.Location = new System.Drawing.Point(218, 116);
            this.linkedinlbl.Name = "linkedinlbl";
            this.linkedinlbl.ReadOnly = true;
            this.linkedinlbl.Size = new System.Drawing.Size(427, 19);
            this.linkedinlbl.TabIndex = 32;
            // 
            // joblbl
            // 
            this.joblbl.AutoSize = true;
            this.joblbl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joblbl.ForeColor = System.Drawing.Color.Black;
            this.joblbl.Location = new System.Drawing.Point(260, 189);
            this.joblbl.Name = "joblbl";
            this.joblbl.Size = new System.Drawing.Size(252, 34);
            this.joblbl.TabIndex = 28;
            this.joblbl.Text = "BACKEND DEVELOPER";
            // 
            // AboutMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 573);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutMeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutMeForm";
            this.Load += new System.EventHandler(this.AboutMeForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label joblbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox githublbl;
        private System.Windows.Forms.TextBox linkedinlbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}