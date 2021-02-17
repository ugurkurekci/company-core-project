
namespace WinForms.Forms.Product
{
    partial class ProductUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdateForm));
            this.headerpnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productımagetxb = new System.Windows.Forms.TextBox();
            this.productquantitytxb = new System.Windows.Forms.TextBox();
            this.productpricetxb = new System.Windows.Forms.TextBox();
            this.productnametxb = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.ımagelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productnotxb = new System.Windows.Forms.TextBox();
            this.nolbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.headerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "PRODUCT UPDATE PANEL";
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
            // productımagetxb
            // 
            this.productımagetxb.BackColor = System.Drawing.SystemColors.Control;
            this.productımagetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productımagetxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productımagetxb.Location = new System.Drawing.Point(360, 212);
            this.productımagetxb.Name = "productımagetxb";
            this.productımagetxb.PlaceholderText = "Image";
            this.productımagetxb.Size = new System.Drawing.Size(161, 25);
            this.productımagetxb.TabIndex = 59;
            // 
            // productquantitytxb
            // 
            this.productquantitytxb.BackColor = System.Drawing.SystemColors.Control;
            this.productquantitytxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productquantitytxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productquantitytxb.Location = new System.Drawing.Point(360, 178);
            this.productquantitytxb.Name = "productquantitytxb";
            this.productquantitytxb.PlaceholderText = "Quantity";
            this.productquantitytxb.Size = new System.Drawing.Size(161, 25);
            this.productquantitytxb.TabIndex = 57;
            // 
            // productpricetxb
            // 
            this.productpricetxb.BackColor = System.Drawing.SystemColors.Control;
            this.productpricetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productpricetxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productpricetxb.Location = new System.Drawing.Point(360, 144);
            this.productpricetxb.Name = "productpricetxb";
            this.productpricetxb.PlaceholderText = "Price";
            this.productpricetxb.Size = new System.Drawing.Size(161, 25);
            this.productpricetxb.TabIndex = 58;
            // 
            // productnametxb
            // 
            this.productnametxb.BackColor = System.Drawing.SystemColors.Control;
            this.productnametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productnametxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productnametxb.Location = new System.Drawing.Point(360, 110);
            this.productnametxb.Name = "productnametxb";
            this.productnametxb.PlaceholderText = "Name";
            this.productnametxb.Size = new System.Drawing.Size(161, 25);
            this.productnametxb.TabIndex = 56;
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
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 51;
            // 
            // productnotxb
            // 
            this.productnotxb.BackColor = System.Drawing.SystemColors.Control;
            this.productnotxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productnotxb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productnotxb.Location = new System.Drawing.Point(361, 75);
            this.productnotxb.Name = "productnotxb";
            this.productnotxb.PlaceholderText = "No";
            this.productnotxb.ReadOnly = true;
            this.productnotxb.Size = new System.Drawing.Size(161, 25);
            this.productnotxb.TabIndex = 66;
            // 
            // nolbl
            // 
            this.nolbl.AutoSize = true;
            this.nolbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nolbl.Location = new System.Drawing.Point(302, 75);
            this.nolbl.Name = "nolbl";
            this.nolbl.Size = new System.Drawing.Size(52, 25);
            this.nolbl.TabIndex = 65;
            this.nolbl.Text = "NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(266, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 22);
            this.label2.TabIndex = 82;
            this.label2.Text = "Update Data then press button";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DarkOrange;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(316, 290);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(151, 43);
            this.updatebtn.TabIndex = 81;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtnn_Click);
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.productnotxb);
            this.Controls.Add(this.nolbl);
            this.Controls.Add(this.headerpnl);
            this.Controls.Add(this.productımagetxb);
            this.Controls.Add(this.productquantitytxb);
            this.Controls.Add(this.productpricetxb);
            this.Controls.Add(this.productnametxb);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.ımagelbl);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductUpdateForm";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Load);
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
        private System.Windows.Forms.TextBox productımagetxb;
        private System.Windows.Forms.TextBox productquantitytxb;
        private System.Windows.Forms.TextBox productpricetxb;
        private System.Windows.Forms.TextBox productnametxb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label ımagelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox productnotxb;
        private System.Windows.Forms.Label nolbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updatebtn;
    }
}