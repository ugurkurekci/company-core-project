
namespace WinForms.Forms.Customers
{
    partial class CustomersAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersAddForm));
            this.headerpnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.adresstxb = new System.Windows.Forms.TextBox();
            this.emailtxb = new System.Windows.Forms.TextBox();
            this.telephonetxb = new System.Windows.Forms.TextBox();
            this.surnametxb = new System.Windows.Forms.TextBox();
            this.nametxb = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.dateofoutlbl = new System.Windows.Forms.Label();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.dateofstartlbl = new System.Windows.Forms.Label();
            this.salarylbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerpnl
            // 
            this.headerpnl.BackColor = System.Drawing.Color.Teal;
            this.headerpnl.Controls.Add(this.label1);
            this.headerpnl.Controls.Add(this.pictureBox1);
            this.headerpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpnl.Location = new System.Drawing.Point(0, 0);
            this.headerpnl.Name = "headerpnl";
            this.headerpnl.Size = new System.Drawing.Size(800, 34);
            this.headerpnl.TabIndex = 37;
            this.headerpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseDown);
            this.headerpnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseMove);
            this.headerpnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(314, 287);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(163, 47);
            this.addbtn.TabIndex = 36;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // adresstxb
            // 
            this.adresstxb.BackColor = System.Drawing.SystemColors.Control;
            this.adresstxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresstxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adresstxb.Location = new System.Drawing.Point(373, 226);
            this.adresstxb.Name = "adresstxb";
            this.adresstxb.PlaceholderText = "Adress";
            this.adresstxb.Size = new System.Drawing.Size(161, 25);
            this.adresstxb.TabIndex = 35;
            // 
            // emailtxb
            // 
            this.emailtxb.BackColor = System.Drawing.SystemColors.Control;
            this.emailtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailtxb.Location = new System.Drawing.Point(373, 192);
            this.emailtxb.Name = "emailtxb";
            this.emailtxb.PlaceholderText = "Email";
            this.emailtxb.Size = new System.Drawing.Size(161, 25);
            this.emailtxb.TabIndex = 34;
            // 
            // telephonetxb
            // 
            this.telephonetxb.BackColor = System.Drawing.SystemColors.Control;
            this.telephonetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telephonetxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telephonetxb.Location = new System.Drawing.Point(373, 158);
            this.telephonetxb.Name = "telephonetxb";
            this.telephonetxb.PlaceholderText = "Telephone";
            this.telephonetxb.Size = new System.Drawing.Size(161, 25);
            this.telephonetxb.TabIndex = 32;
            // 
            // surnametxb
            // 
            this.surnametxb.BackColor = System.Drawing.SystemColors.Control;
            this.surnametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnametxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnametxb.Location = new System.Drawing.Point(373, 124);
            this.surnametxb.Name = "surnametxb";
            this.surnametxb.PlaceholderText = "Surname";
            this.surnametxb.Size = new System.Drawing.Size(161, 25);
            this.surnametxb.TabIndex = 33;
            // 
            // nametxb
            // 
            this.nametxb.BackColor = System.Drawing.SystemColors.Control;
            this.nametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nametxb.Location = new System.Drawing.Point(373, 90);
            this.nametxb.Name = "nametxb";
            this.nametxb.PlaceholderText = "Name";
            this.nametxb.Size = new System.Drawing.Size(161, 25);
            this.nametxb.TabIndex = 31;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(289, 90);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(78, 25);
            this.namelbl.TabIndex = 26;
            this.namelbl.Text = "Name :";
            // 
            // dateofoutlbl
            // 
            this.dateofoutlbl.AutoSize = true;
            this.dateofoutlbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateofoutlbl.Location = new System.Drawing.Point(276, 226);
            this.dateofoutlbl.Name = "dateofoutlbl";
            this.dateofoutlbl.Size = new System.Drawing.Size(91, 25);
            this.dateofoutlbl.TabIndex = 30;
            this.dateofoutlbl.Text = "Adress :";
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnamelbl.Location = new System.Drawing.Point(256, 124);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(111, 25);
            this.surnamelbl.TabIndex = 27;
            this.surnamelbl.Text = "Surname :";
            // 
            // dateofstartlbl
            // 
            this.dateofstartlbl.AutoSize = true;
            this.dateofstartlbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateofstartlbl.Location = new System.Drawing.Point(289, 192);
            this.dateofstartlbl.Name = "dateofstartlbl";
            this.dateofstartlbl.Size = new System.Drawing.Size(78, 25);
            this.dateofstartlbl.TabIndex = 29;
            this.dateofstartlbl.Text = "Email :";
            // 
            // salarylbl
            // 
            this.salarylbl.AutoSize = true;
            this.salarylbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salarylbl.Location = new System.Drawing.Point(243, 158);
            this.salarylbl.Name = "salarylbl";
            this.salarylbl.Size = new System.Drawing.Size(124, 25);
            this.salarylbl.TabIndex = 28;
            this.salarylbl.Text = "Telephone :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer Add Panel";
            // 
            // CustomersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerpnl);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.adresstxb);
            this.Controls.Add(this.emailtxb);
            this.Controls.Add(this.telephonetxb);
            this.Controls.Add(this.surnametxb);
            this.Controls.Add(this.nametxb);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.dateofoutlbl);
            this.Controls.Add(this.surnamelbl);
            this.Controls.Add(this.dateofstartlbl);
            this.Controls.Add(this.salarylbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersAddForm";
            this.headerpnl.ResumeLayout(false);
            this.headerpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerpnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox adresstxb;
        private System.Windows.Forms.TextBox emailtxb;
        private System.Windows.Forms.TextBox telephonetxb;
        private System.Windows.Forms.TextBox surnametxb;
        private System.Windows.Forms.TextBox nametxb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label dateofoutlbl;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.Label dateofstartlbl;
        private System.Windows.Forms.Label salarylbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}