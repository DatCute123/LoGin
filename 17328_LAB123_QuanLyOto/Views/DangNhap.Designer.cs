namespace _17328_LAB123_QuanLyOto
{
    partial class from1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.tbx_taiKhoan = new System.Windows.Forms.TextBox();
            this.tbx_matKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_dangKy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_dangNhap.Location = new System.Drawing.Point(319, 252);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(168, 57);
            this.btn_dangNhap.TabIndex = 0;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // tbx_taiKhoan
            // 
            this.tbx_taiKhoan.Location = new System.Drawing.Point(319, 128);
            this.tbx_taiKhoan.Name = "tbx_taiKhoan";
            this.tbx_taiKhoan.Size = new System.Drawing.Size(255, 27);
            this.tbx_taiKhoan.TabIndex = 2;
            // 
            // tbx_matKhau
            // 
            this.tbx_matKhau.Location = new System.Drawing.Point(319, 177);
            this.tbx_matKhau.Name = "tbx_matKhau";
            this.tbx_matKhau.Size = new System.Drawing.Size(255, 27);
            this.tbx_matKhau.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // tbx_dangKy
            // 
            this.tbx_dangKy.AutoSize = true;
            this.tbx_dangKy.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbx_dangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_dangKy.Location = new System.Drawing.Point(319, 321);
            this.tbx_dangKy.Name = "tbx_dangKy";
            this.tbx_dangKy.Size = new System.Drawing.Size(202, 31);
            this.tbx_dangKy.TabIndex = 6;
            this.tbx_dangKy.Text = "Đăng ký tài khoản";
            this.tbx_dangKy.Click += new System.EventHandler(this.tbx_dangKy_Click);
            // 
            // from1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_dangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_matKhau);
            this.Controls.Add(this.tbx_taiKhoan);
            this.Controls.Add(this.btn_dangNhap);
            this.Name = "from1";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_dangNhap;
        private TextBox tbx_taiKhoan;
        private TextBox tbx_matKhau;
        private Label label1;
        private Label label2;
        private Label tbx_dangKy;
    }
}