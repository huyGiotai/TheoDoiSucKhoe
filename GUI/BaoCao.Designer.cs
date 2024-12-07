namespace GUI
{
    partial class BaoCao
    {
        private System.ComponentModel.IContainer components = null;
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonhuytim = new System.Windows.Forms.Button();
            this.dateTimetimngay = new System.Windows.Forms.DateTimePicker();
            this.buttontimngay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.texthienthi = new System.Windows.Forms.TextBox();
            this.textBaocaohuyetap = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.Buttonthoat = new System.Windows.Forms.Button();
            this.buttonloikhuyen = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView_baocao = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baocao)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_dangxuat,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(975, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_dangxuat
            // 
            this.mnu_dangxuat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnu_dangxuat.Image = global::GUI.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout_24;
            this.mnu_dangxuat.Name = "mnu_dangxuat";
            this.mnu_dangxuat.Size = new System.Drawing.Size(142, 25);
            this.mnu_dangxuat.Text = "Đăng xuất  ";
            this.mnu_dangxuat.Click += new System.EventHandler(this.mnu_dangxuat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItem1.Image = global::GUI.Properties.Resources.Dtafalonso_Ios8_Health_24;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 25);
            this.toolStripMenuItem1.Text = "Phiếu sức khỏe  ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItem2.Image = global::GUI.Properties.Resources.Gartoon_Team_Gartoon_Misc_Seahorse_Applet_Signed_24;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 25);
            this.toolStripMenuItem2.Text = "Mục tiêu   ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItem3.Image = global::GUI.Properties.Resources.Inipagi_Business_Economic_Checklist_24;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(139, 25);
            this.toolStripMenuItem3.Text = "Báo cáo     ";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItem4.Image = global::GUI.Properties.Resources.Alecive_Flatwoken_Apps_Notifications_24;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 25);
            this.toolStripMenuItem4.Text = "Nhắc nhở    ";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItem5.Image = global::GUI.Properties.Resources.Saki_NuoveXT_2_Apps_session_logout_24;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(93, 25);
            this.toolStripMenuItem5.Text = "Thoát";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Ngày Cần báo Cáo :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonhuytim);
            this.panel1.Controls.Add(this.dateTimetimngay);
            this.panel1.Controls.Add(this.buttontimngay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 77);
            this.panel1.TabIndex = 2;
            // 
            // buttonhuytim
            // 
            this.buttonhuytim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhuytim.ForeColor = System.Drawing.Color.Black;
            this.buttonhuytim.Location = new System.Drawing.Point(816, 13);
            this.buttonhuytim.Name = "buttonhuytim";
            this.buttonhuytim.Size = new System.Drawing.Size(120, 45);
            this.buttonhuytim.TabIndex = 15;
            this.buttonhuytim.Text = "Hủy Tìm";
            this.buttonhuytim.UseVisualStyleBackColor = true;
            this.buttonhuytim.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimetimngay
            // 
            this.dateTimetimngay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimetimngay.Location = new System.Drawing.Point(400, 19);
            this.dateTimetimngay.Name = "dateTimetimngay";
            this.dateTimetimngay.Size = new System.Drawing.Size(259, 34);
            this.dateTimetimngay.TabIndex = 14;
            // 
            // buttontimngay
            // 
            this.buttontimngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontimngay.ForeColor = System.Drawing.Color.Black;
            this.buttontimngay.Location = new System.Drawing.Point(676, 14);
            this.buttontimngay.Name = "buttontimngay";
            this.buttontimngay.Size = new System.Drawing.Size(120, 45);
            this.buttontimngay.TabIndex = 13;
            this.buttontimngay.Text = "Tìm Kiếm";
            this.buttontimngay.UseVisualStyleBackColor = true;
            this.buttontimngay.Click += new System.EventHandler(this.buttontimngay_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.texthienthi);
            this.panel4.Controls.Add(this.textBaocaohuyetap);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(789, 321);
            this.panel4.TabIndex = 4;
            // 
            // texthienthi
            // 
            this.texthienthi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.texthienthi.Location = new System.Drawing.Point(152, 73);
            this.texthienthi.Multiline = true;
            this.texthienthi.Name = "texthienthi";
            this.texthienthi.Size = new System.Drawing.Size(507, 29);
            this.texthienthi.TabIndex = 35;
            this.texthienthi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.texthienthi.TextChanged += new System.EventHandler(this.texthienthi_TextChanged);
            // 
            // textBaocaohuyetap
            // 
            this.textBaocaohuyetap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBaocaohuyetap.Location = new System.Drawing.Point(23, 108);
            this.textBaocaohuyetap.Multiline = true;
            this.textBaocaohuyetap.Name = "textBaocaohuyetap";
            this.textBaocaohuyetap.Size = new System.Drawing.Size(747, 186);
            this.textBaocaohuyetap.TabIndex = 32;
            this.textBaocaohuyetap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBaocaohuyetap.TextChanged += new System.EventHandler(this.textBaocaohuyetap_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label29);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(767, 64);
            this.panel5.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(767, 64);
            this.label29.TabIndex = 0;
            this.label29.Text = "Báo Cáo Chỉ số sức khỏe của ngày cần tìm:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Buttonthoat
            // 
            this.Buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonthoat.ForeColor = System.Drawing.Color.Black;
            this.Buttonthoat.Location = new System.Drawing.Point(817, 516);
            this.Buttonthoat.Name = "Buttonthoat";
            this.Buttonthoat.Size = new System.Drawing.Size(146, 84);
            this.Buttonthoat.TabIndex = 14;
            this.Buttonthoat.Text = "Thoát";
            this.Buttonthoat.UseVisualStyleBackColor = true;
            this.Buttonthoat.Click += new System.EventHandler(this.Buttonthoat_Click);
            // 
            // buttonloikhuyen
            // 
            this.buttonloikhuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonloikhuyen.ForeColor = System.Drawing.Color.Black;
            this.buttonloikhuyen.Location = new System.Drawing.Point(817, 347);
            this.buttonloikhuyen.Name = "buttonloikhuyen";
            this.buttonloikhuyen.Size = new System.Drawing.Size(146, 84);
            this.buttonloikhuyen.TabIndex = 15;
            this.buttonloikhuyen.Text = "Lời Khuyên";
            this.buttonloikhuyen.UseVisualStyleBackColor = true;
            this.buttonloikhuyen.Click += new System.EventHandler(this.buttonLoiKhuyen_Click);
            // 
            // dataGridView_baocao
            // 
            this.dataGridView_baocao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_baocao.Location = new System.Drawing.Point(12, 125);
            this.dataGridView_baocao.Name = "dataGridView_baocao";
            this.dataGridView_baocao.RowHeadersWidth = 51;
            this.dataGridView_baocao.RowTemplate.Height = 24;
            this.dataGridView_baocao.Size = new System.Drawing.Size(937, 197);
            this.dataGridView_baocao.TabIndex = 17;
            this.dataGridView_baocao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_baocao_CellContentClick);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(975, 672);
            this.Controls.Add(this.dataGridView_baocao);
            this.Controls.Add(this.buttonloikhuyen);
            this.Controls.Add(this.Buttonthoat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCao";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.BaoCao_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_dangxuat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttontimngay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBaocaohuyetap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button Buttonthoat;
        private System.Windows.Forms.Button buttonloikhuyen;
        private System.Windows.Forms.TextBox texthienthi;
        private System.Windows.Forms.DateTimePicker dateTimetimngay;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.DataGridView dataGridView_baocao;
        private System.Windows.Forms.Button buttonhuytim;
    }
}