namespace BMCSDL
{
    partial class MainForm
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
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.buttonNhanVien = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDangKy
            // 
            this.buttonDangKy.Location = new System.Drawing.Point(89, 209);
            this.buttonDangKy.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(249, 90);
            this.buttonDangKy.TabIndex = 0;
            this.buttonDangKy.Text = "Đăng ký cung cấp PassPort";
            this.buttonDangKy.UseVisualStyleBackColor = true;
            this.buttonDangKy.Click += new System.EventHandler(this.buttonDangKy_Click);
            // 
            // buttonNhanVien
            // 
            this.buttonNhanVien.Location = new System.Drawing.Point(518, 209);
            this.buttonNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNhanVien.Name = "buttonNhanVien";
            this.buttonNhanVien.Size = new System.Drawing.Size(249, 90);
            this.buttonNhanVien.TabIndex = 1;
            this.buttonNhanVien.Text = "Nhân viên";
            this.buttonNhanVien.UseVisualStyleBackColor = true;
            this.buttonNhanVien.Click += new System.EventHandler(this.buttonNhanVien_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(234, 80);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(466, 38);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Cung Cấp Hộ Chiếu Lần Đầu";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Bùi Lê Tấn Phi";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 30);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Vũ Trung Tín";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 438);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.buttonNhanVien);
            this.Controls.Add(this.buttonDangKy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDangKy;
        private System.Windows.Forms.Button buttonNhanVien;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}