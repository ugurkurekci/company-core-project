
namespace WinForms.Forms.Product
{
    partial class ProductDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDeleteForm));
            this.headerpnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımagetxb = new System.Windows.Forms.TextBox();
            this.quantitytxb = new System.Windows.Forms.TextBox();
            this.pricetxb = new System.Windows.Forms.TextBox();
            this.nametxb = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.ımagelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletebtn = new System.Windows.Forms.Button();
            this.notxb = new System.Windows.Forms.TextBox();
            this.nolbl = new System.Windows.Forms.Label();
            this.headerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerpnl
            // 
            this.headerpnl.BackColor = System.Drawing.Color.Red;
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
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "PRODUCT DELETE PANEL";
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
            // ımagetxb
            // 
            this.ımagetxb.BackColor = System.Drawing.SystemColors.Control;
            this.ımagetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ımagetxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ımagetxb.Location = new System.Drawing.Point(360, 212);
            this.ımagetxb.Name = "ımagetxb";
            this.ımagetxb.PlaceholderText = "Email";
            this.ımagetxb.ReadOnly = true;
            this.ımagetxb.Size = new System.Drawing.Size(161, 25);
            this.ımagetxb.TabIndex = 59;
            // 
            // quantitytxb
            // 
            this.quantitytxb.BackColor = System.Drawing.SystemColors.Control;
            this.quantitytxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantitytxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantitytxb.Location = new System.Drawing.Point(360, 178);
            this.quantitytxb.Name = "quantitytxb";
            this.quantitytxb.PlaceholderText = "Quantity";
            this.quantitytxb.ReadOnly = true;
            this.quantitytxb.Size = new System.Drawing.Size(161, 25);
            this.quantitytxb.TabIndex = 57;
            // 
            // pricetxb
            // 
            this.pricetxb.BackColor = System.Drawing.SystemColors.Control;
            this.pricetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricetxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricetxb.Location = new System.Drawing.Point(360, 144);
            this.pricetxb.Name = "pricetxb";
            this.pricetxb.PlaceholderText = "Price";
            this.pricetxb.ReadOnly = true;
            this.pricetxb.Size = new System.Drawing.Size(161, 25);
            this.pricetxb.TabIndex = 58;
            // 
            // nametxb
            // 
            this.nametxb.BackColor = System.Drawing.SystemColors.Control;
            this.nametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nametxb.Location = new System.Drawing.Point(360, 110);
            this.nametxb.Name = "nametxb";
            this.nametxb.PlaceholderText = "Name";
            this.nametxb.ReadOnly = true;
            this.nametxb.Size = new System.Drawing.Size(161, 25);
            this.nametxb.TabIndex = 56;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(276, 110);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(78, 25);
            this.namelbl.TabIndex = 52;
            this.namelbl.Text = "Name :";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pricelbl.Location = new System.Drawing.Point(280, 144);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(74, 25);
            this.pricelbl.TabIndex = 53;
            this.pricelbl.Text = "Price :";
            // 
            // ımagelbl
            // 
            this.ımagelbl.AutoSize = true;
            this.ımagelbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ımagelbl.Location = new System.Drawing.Point(276, 212);
            this.ımagelbl.Name = "ımagelbl";
            this.ımagelbl.Size = new System.Drawing.Size(82, 25);
            this.ımagelbl.TabIndex = 55;
            this.ımagelbl.Text = "Image :";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantitylbl.Location = new System.Drawing.Point(245, 178);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(109, 25);
            this.quantitylbl.TabIndex = 54;
            this.quantitylbl.Text = "Quantity :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 51;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(322, 297);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(151, 43);
            this.deletebtn.TabIndex = 62;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // notxb
            // 
            this.notxb.BackColor = System.Drawing.SystemColors.Control;
            this.notxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notxb.Location = new System.Drawing.Point(361, 74);
            this.notxb.Name = "notxb";
            this.notxb.PlaceholderText = "No";
            this.notxb.ReadOnly = true;
            this.notxb.Size = new System.Drawing.Size(161, 25);
            this.notxb.TabIndex = 64;
            // 
            // nolbl
            // 
            this.nolbl.AutoSize = true;
            this.nolbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nolbl.Location = new System.Drawing.Point(302, 74);
            this.nolbl.Name = "nolbl";
            this.nolbl.Size = new System.Drawing.Size(52, 25);
            this.nolbl.TabIndex = 63;
            this.nolbl.Text = "NO :";
            // 
            // ProductDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notxb);
            this.Controls.Add(this.nolbl);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.headerpnl);
            this.Controls.Add(this.ımagetxb);
            this.Controls.Add(this.quantitytxb);
            this.Controls.Add(this.pricetxb);
            this.Controls.Add(this.nametxb);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.ımagelbl);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDeleteForm";
            this.Load += new System.EventHandler(this.ProductDeleteForm_Load);
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
        private System.Windows.Forms.TextBox ımagetxb;
        private System.Windows.Forms.TextBox quantitytxb;
        private System.Windows.Forms.TextBox pricetxb;
        private System.Windows.Forms.TextBox nametxb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label ımagelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox notxb;
        private System.Windows.Forms.Label nolbl;
    }
}