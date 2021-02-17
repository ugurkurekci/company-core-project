
namespace WinForms.Forms.Order
{
    partial class OrderUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUpdateForm));
            this.notxb = new System.Windows.Forms.TextBox();
            this.nolbl = new System.Windows.Forms.Label();
            this.headerpnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnamecbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namecbx = new System.Windows.Forms.ComboBox();
            this.pricetxb = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productcbx = new System.Windows.Forms.ComboBox();
            this.quantitytxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.headerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notxb
            // 
            this.notxb.BackColor = System.Drawing.SystemColors.Control;
            this.notxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notxb.Location = new System.Drawing.Point(363, 87);
            this.notxb.Name = "notxb";
            this.notxb.PlaceholderText = "No";
            this.notxb.ReadOnly = true;
            this.notxb.Size = new System.Drawing.Size(177, 25);
            this.notxb.TabIndex = 96;
            // 
            // nolbl
            // 
            this.nolbl.AutoSize = true;
            this.nolbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nolbl.Location = new System.Drawing.Point(296, 87);
            this.nolbl.Name = "nolbl";
            this.nolbl.Size = new System.Drawing.Size(52, 25);
            this.nolbl.TabIndex = 95;
            this.nolbl.Text = "NO :";
            // 
            // headerpnl
            // 
            this.headerpnl.BackColor = System.Drawing.Color.Orange;
            this.headerpnl.Controls.Add(this.label1);
            this.headerpnl.Controls.Add(this.pictureBox1);
            this.headerpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpnl.Location = new System.Drawing.Point(0, 0);
            this.headerpnl.Name = "headerpnl";
            this.headerpnl.Size = new System.Drawing.Size(800, 34);
            this.headerpnl.TabIndex = 89;
            this.headerpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseDown);
            this.headerpnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseMove);
            this.headerpnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerpnl_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "ORDER UPDATE PANEL";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Product :";
            // 
            // surnamecbx
            // 
            this.surnamecbx.BackColor = System.Drawing.SystemColors.Control;
            this.surnamecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surnamecbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surnamecbx.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnamecbx.FormattingEnabled = true;
            this.surnamecbx.Location = new System.Drawing.Point(363, 159);
            this.surnamecbx.Name = "surnamecbx";
            this.surnamecbx.Size = new System.Drawing.Size(177, 27);
            this.surnamecbx.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(237, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Surname :";
            // 
            // namecbx
            // 
            this.namecbx.BackColor = System.Drawing.SystemColors.Control;
            this.namecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namecbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namecbx.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namecbx.FormattingEnabled = true;
            this.namecbx.Location = new System.Drawing.Point(363, 124);
            this.namecbx.Name = "namecbx";
            this.namecbx.Size = new System.Drawing.Size(177, 27);
            this.namecbx.TabIndex = 90;
            // 
            // pricetxb
            // 
            this.pricetxb.BackColor = System.Drawing.SystemColors.Control;
            this.pricetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricetxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricetxb.Location = new System.Drawing.Point(363, 228);
            this.pricetxb.Name = "pricetxb";
            this.pricetxb.PlaceholderText = "Price";
            this.pricetxb.Size = new System.Drawing.Size(177, 25);
            this.pricetxb.TabIndex = 88;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(270, 123);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(78, 25);
            this.namelbl.TabIndex = 84;
            this.namelbl.Text = "Name :";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricelbl.Location = new System.Drawing.Point(274, 228);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(74, 25);
            this.pricelbl.TabIndex = 85;
            this.pricelbl.Text = "Price :";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantitylbl.Location = new System.Drawing.Point(239, 264);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(109, 25);
            this.quantitylbl.TabIndex = 86;
            this.quantitylbl.Text = "Quantity :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 83;
            // 
            // productcbx
            // 
            this.productcbx.BackColor = System.Drawing.SystemColors.Control;
            this.productcbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productcbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productcbx.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productcbx.FormattingEnabled = true;
            this.productcbx.Location = new System.Drawing.Point(363, 194);
            this.productcbx.Name = "productcbx";
            this.productcbx.Size = new System.Drawing.Size(177, 27);
            this.productcbx.TabIndex = 94;
            // 
            // quantitytxb
            // 
            this.quantitytxb.BackColor = System.Drawing.SystemColors.Control;
            this.quantitytxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantitytxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantitytxb.Location = new System.Drawing.Point(363, 264);
            this.quantitytxb.Name = "quantitytxb";
            this.quantitytxb.PlaceholderText = "Quantity";
            this.quantitytxb.Size = new System.Drawing.Size(177, 25);
            this.quantitytxb.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 22);
            this.label4.TabIndex = 98;
            this.label4.Text = "Update Data then press button";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DarkOrange;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(314, 312);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(163, 47);
            this.updatebtn.TabIndex = 99;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // OrderUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notxb);
            this.Controls.Add(this.nolbl);
            this.Controls.Add(this.headerpnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnamecbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namecbx);
            this.Controls.Add(this.pricetxb);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productcbx);
            this.Controls.Add(this.quantitytxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderUpdateForm";
            this.Load += new System.EventHandler(this.OrderUpdateForm_Load);
            this.headerpnl.ResumeLayout(false);
            this.headerpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox notxb;
        private System.Windows.Forms.Label nolbl;
        private System.Windows.Forms.Panel headerpnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox surnamecbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox namecbx;
        private System.Windows.Forms.TextBox pricetxb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox productcbx;
        private System.Windows.Forms.TextBox quantitytxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updatebtn;
    }
}