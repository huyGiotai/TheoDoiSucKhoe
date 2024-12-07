using System;

namespace GUI
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_dangnahp = new System.Windows.Forms.Label();
            this.textBox_taikhoan = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.button_Dangky = new System.Windows.Forms.Button();
            this.checkBox_hienthi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_Nhaplainmk = new System.Windows.Forms.TextBox();
            this.label_nhaplaimk = new System.Windows.Forms.Label();
            this.label_taikhoan = new System.Windows.Forms.Label();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.label_dangnahp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 112);
            this.panel1.TabIndex = 0;
            // 
            // label_dangnahp
            // 
            this.label_dangnahp.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_dangnahp.ForeColor = System.Drawing.Color.White;
            this.label_dangnahp.Location = new System.Drawing.Point(270, 15);
            this.label_dangnahp.Name = "label_dangnahp";
            this.label_dangnahp.Size = new System.Drawing.Size(442, 78);
            this.label_dangnahp.TabIndex = 0;
            this.label_dangnahp.Text = "Đăng Ký";
            this.label_dangnahp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_taikhoan
            // 
            this.textBox_taikhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_taikhoan.Location = new System.Drawing.Point(233, 38);
            this.textBox_taikhoan.Multiline = true;
            this.textBox_taikhoan.Name = "textBox_taikhoan";
            this.textBox_taikhoan.Size = new System.Drawing.Size(274, 45);
            this.textBox_taikhoan.TabIndex = 2;
            this.textBox_taikhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_matkhau.Location = new System.Drawing.Point(233, 112);
            this.textBox_matkhau.Multiline = true;
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.PasswordChar = '*';
            this.textBox_matkhau.Size = new System.Drawing.Size(274, 43);
            this.textBox_matkhau.TabIndex = 4;
            this.textBox_matkhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_dangnhap.Location = new System.Drawing.Point(102, 269);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(130, 46);
            this.button_dangnhap.TabIndex = 5;
            this.button_dangnhap.Text = "Đăng nhập\r\n";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // button_Dangky
            // 
            this.button_Dangky.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Dangky.Location = new System.Drawing.Point(303, 269);
            this.button_Dangky.Name = "button_Dangky";
            this.button_Dangky.Size = new System.Drawing.Size(117, 46);
            this.button_Dangky.TabIndex = 6;
            this.button_Dangky.Text = "Đăng Ký";
            this.button_Dangky.UseVisualStyleBackColor = true;
            this.button_Dangky.Click += new System.EventHandler(this.button_Dangky_Click);
            // 
            // checkBox_hienthi
            // 
            this.checkBox_hienthi.AutoSize = true;
            this.checkBox_hienthi.Location = new System.Drawing.Point(351, 233);
            this.checkBox_hienthi.Name = "checkBox_hienthi";
            this.checkBox_hienthi.Size = new System.Drawing.Size(142, 21);
            this.checkBox_hienthi.TabIndex = 7;
            this.checkBox_hienthi.Text = "Hiển thị mật khẩu\r\n";
            this.checkBox_hienthi.UseVisualStyleBackColor = true;
            this.checkBox_hienthi.CheckedChanged += new System.EventHandler(this.checkBox_hienthi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 350);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.Streamlineicons_Streamline_Ux_Free_Doctor_hospital_512;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.text_Nhaplainmk);
            this.groupBox2.Controls.Add(this.label_nhaplaimk);
            this.groupBox2.Controls.Add(this.label_taikhoan);
            this.groupBox2.Controls.Add(this.textBox_taikhoan);
            this.groupBox2.Controls.Add(this.label_matkhau);
            this.groupBox2.Controls.Add(this.textBox_matkhau);
            this.groupBox2.Controls.Add(this.checkBox_hienthi);
            this.groupBox2.Controls.Add(this.button_dangnhap);
            this.groupBox2.Controls.Add(this.button_Dangky);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(431, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 350);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đăng nhập";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // text_Nhaplainmk
            // 
            this.text_Nhaplainmk.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.text_Nhaplainmk.Location = new System.Drawing.Point(233, 177);
            this.text_Nhaplainmk.Multiline = true;
            this.text_Nhaplainmk.Name = "text_Nhaplainmk";
            this.text_Nhaplainmk.PasswordChar = '*';
            this.text_Nhaplainmk.Size = new System.Drawing.Size(274, 43);
            this.text_Nhaplainmk.TabIndex = 10;
            // 
            // label_nhaplaimk
            // 
            this.label_nhaplaimk.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_nhaplaimk.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_nhaplaimk.Location = new System.Drawing.Point(-5, 179);
            this.label_nhaplaimk.Name = "label_nhaplaimk";
            this.label_nhaplaimk.Size = new System.Drawing.Size(221, 41);
            this.label_nhaplaimk.TabIndex = 9;
            this.label_nhaplaimk.Text = "NHập Lại Mật khẩu";
            this.label_nhaplaimk.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_taikhoan
            // 
            this.label_taikhoan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_taikhoan.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_taikhoan.Location = new System.Drawing.Point(-5, 43);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(188, 40);
            this.label_taikhoan.TabIndex = 1;
            this.label_taikhoan.Text = "Tài khoản";
            this.label_taikhoan.Click += new System.EventHandler(this.label_taikhoan_Click);
            // 
            // label_matkhau
            // 
            this.label_matkhau.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_matkhau.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_matkhau.Location = new System.Drawing.Point(0, 114);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(183, 41);
            this.label_matkhau.TabIndex = 3;
            this.label_matkhau.Text = "Mật khẩu";
            this.label_matkhau.Click += new System.EventHandler(this.label_matkhau_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_dangnahp;
        private System.Windows.Forms.Label label_taikhoan;
        private System.Windows.Forms.TextBox textBox_taikhoan;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Button button_Dangky;
        private System.Windows.Forms.CheckBox checkBox_hienthi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_nhaplaimk;
        private System.Windows.Forms.TextBox text_Nhaplainmk;
    }
}