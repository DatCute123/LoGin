namespace _17328_Login_Sigup
{
    partial class Login
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
            this.ten_dn = new System.Windows.Forms.Label();
            this.m_khau = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.CheckBox();
            this.d_nhap = new System.Windows.Forms.Button();
            this.quen_mk = new System.Windows.Forms.Label();
            this.dky_tk = new System.Windows.Forms.Label();
            this.tbox_dn = new System.Windows.Forms.TextBox();
            this.tbox_mk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ten_dn
            // 
            this.ten_dn.AutoSize = true;
            this.ten_dn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ten_dn.Location = new System.Drawing.Point(153, 110);
            this.ten_dn.Name = "ten_dn";
            this.ten_dn.Size = new System.Drawing.Size(134, 25);
            this.ten_dn.TabIndex = 0;
            this.ten_dn.Text = "Tên đăng nhập";
            this.ten_dn.Click += new System.EventHandler(this.ten_dn_Click);
            // 
            // m_khau
            // 
            this.m_khau.AutoSize = true;
            this.m_khau.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_khau.Location = new System.Drawing.Point(153, 198);
            this.m_khau.Name = "m_khau";
            this.m_khau.Size = new System.Drawing.Size(89, 25);
            this.m_khau.TabIndex = 1;
            this.m_khau.Text = "Mật khẩu";
            this.m_khau.Click += new System.EventHandler(this.m_khau_Click);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check.Location = new System.Drawing.Point(153, 256);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(248, 29);
            this.check.TabIndex = 2;
            this.check.Text = "Tôi không phải người máy";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // d_nhap
            // 
            this.d_nhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.d_nhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d_nhap.Location = new System.Drawing.Point(153, 316);
            this.d_nhap.Name = "d_nhap";
            this.d_nhap.Size = new System.Drawing.Size(170, 80);
            this.d_nhap.TabIndex = 3;
            this.d_nhap.Text = "Đăng nhập";
            this.d_nhap.UseVisualStyleBackColor = false;
            this.d_nhap.Click += new System.EventHandler(this.d_nhap_Click);
            // 
            // quen_mk
            // 
            this.quen_mk.AutoSize = true;
            this.quen_mk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quen_mk.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quen_mk.ForeColor = System.Drawing.Color.Red;
            this.quen_mk.Location = new System.Drawing.Point(408, 316);
            this.quen_mk.Name = "quen_mk";
            this.quen_mk.Size = new System.Drawing.Size(143, 25);
            this.quen_mk.TabIndex = 4;
            this.quen_mk.Text = "Quên mật khẩu";
            this.quen_mk.Click += new System.EventHandler(this.quen_mk_Click);
            // 
            // dky_tk
            // 
            this.dky_tk.AutoSize = true;
            this.dky_tk.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.dky_tk.ForeColor = System.Drawing.Color.Blue;
            this.dky_tk.Location = new System.Drawing.Point(408, 357);
            this.dky_tk.Name = "dky_tk";
            this.dky_tk.Size = new System.Drawing.Size(249, 25);
            this.dky_tk.TabIndex = 5;
            this.dky_tk.Text = "Chưa có tài khoản? Đăng ký";
            this.dky_tk.Click += new System.EventHandler(this.dky_tk_Click);
            this.dky_tk.MouseHover += new System.EventHandler(this.dky_tk_MouseHover);
            // 
            // tbox_dn
            // 
            this.tbox_dn.Location = new System.Drawing.Point(309, 110);
            this.tbox_dn.Name = "tbox_dn";
            this.tbox_dn.Size = new System.Drawing.Size(365, 27);
            this.tbox_dn.TabIndex = 6;
            // 
            // tbox_mk
            // 
            this.tbox_mk.Location = new System.Drawing.Point(309, 195);
            this.tbox_mk.Name = "tbox_mk";
            this.tbox_mk.Size = new System.Drawing.Size(365, 27);
            this.tbox_mk.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbox_mk);
            this.Controls.Add(this.tbox_dn);
            this.Controls.Add(this.dky_tk);
            this.Controls.Add(this.quen_mk);
            this.Controls.Add(this.d_nhap);
            this.Controls.Add(this.check);
            this.Controls.Add(this.m_khau);
            this.Controls.Add(this.ten_dn);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ten_dn;
        private Label m_khau;
        private CheckBox check;
        private Button d_nhap;
        private Label quen_mk;
        private Label dky_tk;
        private TextBox tbox_dn;
        private TextBox tbox_mk;
    }
}