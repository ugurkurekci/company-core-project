
namespace WinForms.Forms.Order
{
    partial class OrderAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAddForm));
            this.headerpnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.quantitytxb = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.namecbx = new System.Windows.Forms.ComboBox();
            this.surnamecbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productcbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetxb = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
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
            this.headerpnl.TabIndex = 61;
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
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "ORDER ADD PANEL";
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
            this.addbtn.TabIndex = 60;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // quantitytxb
            // 
            this.quantitytxb.BackColor = System.Drawing.SystemColors.Control;
            this.quantitytxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantitytxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantitytxb.Location = new System.Drawing.Point(361, 220);
            this.quantitytxb.Name = "quantitytxb";
            this.quantitytxb.PlaceholderText = "Quantity";
            this.quantitytxb.Size = new System.Drawing.Size(177, 25);
            this.quantitytxb.TabIndex = 57;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(268, 82);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(78, 25);
            this.namelbl.TabIndex = 52;
            this.namelbl.Text = "Name :";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantitylbl.Location = new System.Drawing.Point(237, 220);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(109, 25);
            this.quantitylbl.TabIndex = 54;
            this.quantitylbl.Text = "Quantity :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 51;
            // 
            // namecbx
            // 
            this.namecbx.BackColor = System.Drawing.SystemColors.Control;
            this.namecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namecbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namecbx.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namecbx.FormattingEnabled = true;
            this.namecbx.Location = new System.Drawing.Point(361, 80);
            this.namecbx.Name = "namecbx";
            this.namecbx.Size = new System.Drawing.Size(177, 27);
            this.namecbx.TabIndex = 62;
            // 
            // surnamecbx
            // 
            this.surnamecbx.BackColor = System.Drawing.SystemColors.Control;
            this.surnamecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surnamecbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surnamecbx.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnamecbx.FormattingEnabled = true;
            this.surnamecbx.Location = new System.Drawing.Point(361, 115);
            this.surnamecbx.Name = "surnamecbx";
            this.surnamecbx.Size = new System.Drawing.Size(177, 27);
            this.surnamecbx.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Surname :";
            // 
            // productcbx
            // 
            this.productcbx.BackColor = System.Drawing.SystemColors.Control;
            this.productcbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productcbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productcbx.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productcbx.FormattingEnabled = true;
            this.productcbx.Location = new System.Drawing.Point(361, 150);
            this.productcbx.Name = "productcbx";
            this.productcbx.Size = new System.Drawing.Size(177, 27);
            this.productcbx.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(244, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Product :";
            // 
            // pricetxb
            // 
            this.pricetxb.BackColor = System.Drawing.SystemColors.Control;
            this.pricetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricetxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricetxb.Location = new System.Drawing.Point(361, 184);
            this.pricetxb.Name = "pricetxb";
            this.pricetxb.PlaceholderText = "Price";
            this.pricetxb.Size = new System.Drawing.Size(177, 25);
            this.pricetxb.TabIndex = 58;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricelbl.Location = new System.Drawing.Point(272, 184);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(74, 25);
            this.pricelbl.TabIndex = 53;
            this.pricelbl.Text = "Price :";
            // 
            // OrderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productcbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnamecbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namecbx);
            this.Controls.Add(this.headerpnl);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.quantitytxb);
            this.Controls.Add(this.pricetxb);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderAddForm";
            this.Load += new System.EventHandler(this.OrderAddForm_Load);
            this.headerpnl.ResumeLayout(false);
            this.headerpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerpnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox quantitytxb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox namecbx;
        private System.Windows.Forms.ComboBox surnamecbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productcbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetxb;
        private System.Windows.Forms.Label pricelbl;
    }
}