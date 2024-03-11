namespace SD19308_Bai2
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.cbbMauSac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoiMau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 51;
            this.listBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.listBox1.Location = new System.Drawing.Point(148, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(403, 463);
            this.listBox1.TabIndex = 0;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(148, 623);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(322, 73);
            this.btnHienThi.TabIndex = 1;
            this.btnHienThi.Text = "Hien Thi";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cbbMauSac
            // 
            this.cbbMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMauSac.FormattingEnabled = true;
            this.cbbMauSac.Items.AddRange(new object[] {
            "Do",
            "Vang",
            "Den",
            "Xanh"});
            this.cbbMauSac.Location = new System.Drawing.Point(790, 171);
            this.cbbMauSac.Name = "cbbMauSac";
            this.cbbMauSac.Size = new System.Drawing.Size(500, 59);
            this.cbbMauSac.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(785, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "ABC";
            // 
            // btnDoiMau
            // 
            this.btnDoiMau.Location = new System.Drawing.Point(794, 331);
            this.btnDoiMau.Name = "btnDoiMau";
            this.btnDoiMau.Size = new System.Drawing.Size(322, 73);
            this.btnDoiMau.TabIndex = 4;
            this.btnDoiMau.Text = "Doi Mau";
            this.btnDoiMau.UseVisualStyleBackColor = true;
            this.btnDoiMau.Click += new System.EventHandler(this.btnDoiMau_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 833);
            this.Controls.Add(this.btnDoiMau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMauSac);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.ComboBox cbbMauSac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoiMau;
    }
}

