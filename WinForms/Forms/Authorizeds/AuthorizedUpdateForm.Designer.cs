
namespace WinForms.Forms.Authorizeds
{
    partial class AuthorizedUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizedUpdateForm));
            this.headerpnl = new System.Windows.Forms.Panel();
            this.exitpng = new System.Windows.Forms.PictureBox();
            this.notxb = new System.Windows.Forms.TextBox();
            this.nolbl = new System.Windows.Forms.Label();
            this.dateofouttxb = new System.Windows.Forms.TextBox();
            this.dateofstarttxb = new System.Windows.Forms.TextBox();
            this.salarytxb = new System.Windows.Forms.TextBox();
            this.surnametxb = new System.Windows.Forms.TextBox();
            this.nametxb = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.dateofoutlbl = new System.Windows.Forms.Label();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.dateofstartlbl = new System.Windows.Forms.Label();
            this.salarylbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatebtnn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitpng)).BeginInit();
            this.SuspendLayout();
            // 
            // headerpnl
            // 
            this.headerpnl.BackColor = System.Drawing.Color.Orange;
            this.headerpnl.Controls.Add(this.label2);
            this.headerpnl.Controls.Add(this.exitpng);
            this.headerpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpnl.Location = new System.Drawing.Point(0, 0);
            this.headerpnl.Name = "headerpnl";
            this.headerpnl.Size = new System.Drawing.Size(800, 34);
            this.headerpnl.TabIndex = 52;
            this.headerpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseDown);
            this.headerpnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseMove);
            this.headerpnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseUp);
            // 
            // exitpng
            // 
            this.exitpng.Image = ((System.Drawing.Image)(resources.GetObject("exitpng.Image")));
            this.exitpng.Location = new System.Drawing.Point(729, 0);
            this.exitpng.Name = "exitpng";
            this.exitpng.Size = new System.Drawing.Size(71, 34);
            this.exitpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitpng.TabIndex = 0;
            this.exitpng.TabStop = false;
            this.exitpng.Click += new System.EventHandler(this.exitpng_Click);
            // 
            // notxb
            // 
            this.notxb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.notxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notxb.ForeColor = System.Drawing.Color.Black;
            this.notxb.Location = new System.Drawing.Point(367, 98);
            this.notxb.Name = "notxb";
            this.notxb.PlaceholderText = "No";
            this.notxb.ReadOnly = true;
            this.notxb.Size = new System.Drawing.Size(161, 25);
            this.notxb.TabIndex = 54;
            // 
            // nolbl
            // 
            this.nolbl.AutoSize = true;
            this.nolbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nolbl.Location = new System.Drawing.Point(308, 98);
            this.nolbl.Name = "nolbl";
            this.nolbl.Size = new System.Drawing.Size(52, 25);
            this.nolbl.TabIndex = 53;
            this.nolbl.Text = "NO :";
            // 
            // dateofouttxb
            // 
            this.dateofouttxb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateofouttxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateofouttxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateofouttxb.ForeColor = System.Drawing.Color.Black;
            this.dateofouttxb.Location = new System.Drawing.Point(367, 268);
            this.dateofouttxb.Name = "dateofouttxb";
            this.dateofouttxb.PlaceholderText = "DateofOut";
            this.dateofouttxb.Size = new System.Drawing.Size(161, 25);
            this.dateofouttxb.TabIndex = 50;
            // 
            // dateofstarttxb
            // 
            this.dateofstarttxb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateofstarttxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateofstarttxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateofstarttxb.ForeColor = System.Drawing.Color.Black;
            this.dateofstarttxb.Location = new System.Drawing.Point(367, 234);
            this.dateofstarttxb.Name = "dateofstarttxb";
            this.dateofstarttxb.PlaceholderText = "DateofStart";
            this.dateofstarttxb.Size = new System.Drawing.Size(161, 25);
            this.dateofstarttxb.TabIndex = 49;
            // 
            // salarytxb
            // 
            this.salarytxb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salarytxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salarytxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salarytxb.ForeColor = System.Drawing.Color.Black;
            this.salarytxb.Location = new System.Drawing.Point(367, 200);
            this.salarytxb.Name = "salarytxb";
            this.salarytxb.PlaceholderText = "Salary";
            this.salarytxb.Size = new System.Drawing.Size(161, 25);
            this.salarytxb.TabIndex = 47;
            // 
            // surnametxb
            // 
            this.surnametxb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.surnametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnametxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnametxb.ForeColor = System.Drawing.Color.Black;
            this.surnametxb.Location = new System.Drawing.Point(367, 166);
            this.surnametxb.Name = "surnametxb";
            this.surnametxb.PlaceholderText = "Surname";
            this.surnametxb.Size = new System.Drawing.Size(161, 25);
            this.surnametxb.TabIndex = 48;
            // 
            // nametxb
            // 
            this.nametxb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nametxb.ForeColor = System.Drawing.Color.Black;
            this.nametxb.Location = new System.Drawing.Point(367, 132);
            this.nametxb.Name = "nametxb";
            this.nametxb.PlaceholderText = "Name";
            this.nametxb.Size = new System.Drawing.Size(161, 25);
            this.nametxb.TabIndex = 46;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(282, 132);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(78, 25);
            this.namelbl.TabIndex = 41;
            this.namelbl.Text = "Name :";
            // 
            // dateofoutlbl
            // 
            this.dateofoutlbl.AutoSize = true;
            this.dateofoutlbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateofoutlbl.Location = new System.Drawing.Point(237, 268);
            this.dateofoutlbl.Name = "dateofoutlbl";
            this.dateofoutlbl.Size = new System.Drawing.Size(123, 25);
            this.dateofoutlbl.TabIndex = 45;
            this.dateofoutlbl.Text = "DateofOut :";
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnamelbl.Location = new System.Drawing.Point(249, 166);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(111, 25);
            this.surnamelbl.TabIndex = 42;
            this.surnamelbl.Text = "Surname :";
            // 
            // dateofstartlbl
            // 
            this.dateofstartlbl.AutoSize = true;
            this.dateofstartlbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateofstartlbl.Location = new System.Drawing.Point(225, 234);
            this.dateofstartlbl.Name = "dateofstartlbl";
            this.dateofstartlbl.Size = new System.Drawing.Size(135, 25);
            this.dateofstartlbl.TabIndex = 44;
            this.dateofstartlbl.Text = "DateofStart :";
            // 
            // salarylbl
            // 
            this.salarylbl.AutoSize = true;
            this.salarylbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salarylbl.Location = new System.Drawing.Point(277, 200);
            this.salarylbl.Name = "salarylbl";
            this.salarylbl.Size = new System.Drawing.Size(83, 25);
            this.salarylbl.TabIndex = 43;
            this.salarylbl.Text = "Salary :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 40;
            // 
            // updatebtnn
            // 
            this.updatebtnn.BackColor = System.Drawing.Color.DarkOrange;
            this.updatebtnn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtnn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebtnn.ForeColor = System.Drawing.Color.White;
            this.updatebtnn.Location = new System.Drawing.Point(319, 326);
            this.updatebtnn.Name = "updatebtnn";
            this.updatebtnn.Size = new System.Drawing.Size(151, 43);
            this.updatebtnn.TabIndex = 55;
            this.updatebtnn.Text = "UPDATE";
            this.updatebtnn.UseVisualStyleBackColor = false;
            this.updatebtnn.Click += new System.EventHandler(this.updatebtnn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Update Data then press button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Authorızed Update Panel";
            // 
            // AuthorizedUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatebtnn);
            this.Controls.Add(this.headerpnl);
            this.Controls.Add(this.notxb);
            this.Controls.Add(this.nolbl);
            this.Controls.Add(this.dateofouttxb);
            this.Controls.Add(this.dateofstarttxb);
            this.Controls.Add(this.salarytxb);
            this.Controls.Add(this.surnametxb);
            this.Controls.Add(this.nametxb);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.dateofoutlbl);
            this.Controls.Add(this.surnamelbl);
            this.Controls.Add(this.dateofstartlbl);
            this.Controls.Add(this.salarylbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizedUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizedUpdateForm";
            this.Load += new System.EventHandler(this.AuthorizedUpdateForm_Load);
            this.headerpnl.ResumeLayout(false);
            this.headerpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitpng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerpnl;
        private System.Windows.Forms.PictureBox exitpng;
        private System.Windows.Forms.TextBox notxb;
        private System.Windows.Forms.Label nolbl;
        private System.Windows.Forms.TextBox dateofouttxb;
        private System.Windows.Forms.TextBox dateofstarttxb;
        private System.Windows.Forms.TextBox salarytxb;
        private System.Windows.Forms.TextBox surnametxb;
        private System.Windows.Forms.TextBox nametxb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label dateofoutlbl;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.Label dateofstartlbl;
        private System.Windows.Forms.Label salarylbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updatebtnn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}