using System.Windows.Forms;

namespace GUI
{
    partial class PhieuSucKhoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuSucKhoe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_phieusuckhoe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_muctieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_nhacnho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_huytim = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.dateTimePicker_tim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.textBox_nhietdocothe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_luongduong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_nhiptim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_huyetap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_cannang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_chieucao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_tinhtrang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_dangxuat,
            this.mnu_phieusuckhoe,
            this.mnu_muctieu,
            this.mnu_baocao,
            this.mnu_nhacnho,
            this.mnu_thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(949, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_dangxuat
            // 
            this.mnu_dangxuat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnu_dangxuat.Image = global::GUI.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout_24;
            this.mnu_dangxuat.Name = "mnu_dangxuat";
            this.mnu_dangxuat.Size = new System.Drawing.Size(162, 25);
            this.mnu_dangxuat.Text = "Đăng xuất      ";
            this.mnu_dangxuat.Click += new System.EventHandler(this.mnu_dangxuat_Click);
            // 
            // mnu_phieusuckhoe
            // 
            this.mnu_phieusuckhoe.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnu_phieusuckhoe.Image = global::GUI.Properties.Resources.Dtafalonso_Ios8_Health_24;
            this.mnu_phieusuckhoe.Name = "mnu_phieusuckhoe";
            this.mnu_phieusuckhoe.Size = new System.Drawing.Size(210, 25);
            this.mnu_phieusuckhoe.Text = "Phiếu sức khỏe      ";
            this.mnu_phieusuckhoe.Click += new System.EventHandler(this.mnu_phieusuckhoe_Click);
            // 
            // mnu_muctieu
            // 
            this.mnu_muctieu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnu_muctieu.Image = global::GUI.Properties.Resources.Gartoon_Team_Gartoon_Misc_Seahorse_Applet_Signed_24;
            this.mnu_muctieu.Name = "mnu_muctieu";
            this.mnu_muctieu.Size = new System.Drawing.Size(147, 25);
            this.mnu_muctieu.Text = "Mục tiêu      ";
            this.mnu_muctieu.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mnu_baocao
            // 
            this.mnu_baocao.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnu_baocao.Image = global::GUI.Properties.Resources.Inipagi_Business_Economic_Checklist_24;
            this.mnu_baocao.Name = "mnu_baocao";
            this.mnu_baocao.Size = new System.Drawing.Size(144, 25);
            this.mnu_baocao.Text = "Báo cáo      ";
            // 
            // mnu_nhacnho
            // 
            this.mnu_nhacnho.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnu_nhacnho.Image = global::GUI.Properties.Resources.Alecive_Flatwoken_Apps_Notifications_24;
            this.mnu_nhacnho.Name = "mnu_nhacnho";
            this.mnu_nhacnho.Size = new System.Drawing.Size(158, 25);
            this.mnu_nhacnho.Text = "Nhắc nhở      ";
            // 
            // mnu_thoat
            // 
            this.mnu_thoat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnu_thoat.Image = global::GUI.Properties.Resources.Saki_NuoveXT_2_Apps_session_logout_24;
            this.mnu_thoat.Name = "mnu_thoat";
            this.mnu_thoat.Size = new System.Drawing.Size(93, 25);
            this.mnu_thoat.Text = "Thoát";
            this.mnu_thoat.Click += new System.EventHandler(this.mnu_thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_huytim);
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.dateTimePicker_tim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(26, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(901, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm tra thông tin theo ngày";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_huytim
            // 
            this.btn_huytim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huytim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_huytim.Image = global::GUI.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_2_16;
            this.btn_huytim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huytim.Location = new System.Drawing.Point(728, 42);
            this.btn_huytim.Name = "btn_huytim";
            this.btn_huytim.Size = new System.Drawing.Size(120, 50);
            this.btn_huytim.TabIndex = 3;
            this.btn_huytim.Text = "  Hủy tìm";
            this.btn_huytim.UseVisualStyleBackColor = true;
            this.btn_huytim.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_tim.Image = global::GUI.Properties.Resources.Ampeross_Qetto_2_Search_16;
            this.btn_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim.Location = new System.Drawing.Point(552, 42);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(94, 50);
            this.btn_tim.TabIndex = 2;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // dateTimePicker_tim
            // 
            this.dateTimePicker_tim.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_tim.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker_tim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_tim.Location = new System.Drawing.Point(214, 53);
            this.dateTimePicker_tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_tim.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_tim.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_tim.Name = "dateTimePicker_tim";
            this.dateTimePicker_tim.Size = new System.Drawing.Size(247, 27);
            this.dateTimePicker_tim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Image = global::GUI.Properties.Resources.Icons8_Ios7_Time_And_Date_Calendar_24;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Ngày:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(26, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu sức khỏe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_huybo);
            this.groupBox3.Controls.Add(this.btn_capnhat);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Controls.Add(this.textBox_nhietdocothe);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_luongduong);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_nhiptim);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_huyetap);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_cannang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_chieucao);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.radioButton_nu);
            this.groupBox3.Controls.Add(this.radioButton_nam);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox_tinhtrang);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(26, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(901, 261);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập các chỉ số sức khỏe";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_huybo
            // 
            this.btn_huybo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huybo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_huybo.Image = global::GUI.Properties.Resources.Pictogrammers_Material_Light_Cancel1;
            this.btn_huybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huybo.Location = new System.Drawing.Point(728, 179);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(117, 50);
            this.btn_huybo.TabIndex = 23;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.UseVisualStyleBackColor = true;
            this.btn_huybo.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_capnhat.Image = global::GUI.Properties.Resources.Custom_Icon_Design_Flatastic_1_Edit1;
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(491, 179);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(133, 50);
            this.btn_capnhat.TabIndex = 22;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xoa.Image = global::GUI.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_21;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(269, 179);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(105, 50);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_them.Image = global::GUI.Properties.Resources.Icons8_Windows_8_Programming_Add_Property_16;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(61, 179);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(103, 50);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // textBox_nhietdocothe
            // 
            this.textBox_nhietdocothe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_nhietdocothe.Location = new System.Drawing.Point(801, 127);
            this.textBox_nhietdocothe.Multiline = true;
            this.textBox_nhietdocothe.Name = "textBox_nhietdocothe";
            this.textBox_nhietdocothe.Size = new System.Drawing.Size(94, 29);
            this.textBox_nhietdocothe.TabIndex = 19;
            this.textBox_nhietdocothe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_nhietdocothe.TextChanged += new System.EventHandler(this.textBox_nhietdocothe_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(673, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nhiệt độ cơ thể:";
            // 
            // textBox_luongduong
            // 
            this.textBox_luongduong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_luongduong.Location = new System.Drawing.Point(801, 77);
            this.textBox_luongduong.Multiline = true;
            this.textBox_luongduong.Name = "textBox_luongduong";
            this.textBox_luongduong.Size = new System.Drawing.Size(94, 29);
            this.textBox_luongduong.TabIndex = 17;
            this.textBox_luongduong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_luongduong.TextChanged += new System.EventHandler(this.textBox_luongduong_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(673, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lượng đường:";
            // 
            // textBox_nhiptim
            // 
            this.textBox_nhiptim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_nhiptim.Location = new System.Drawing.Point(801, 26);
            this.textBox_nhiptim.Multiline = true;
            this.textBox_nhiptim.Name = "textBox_nhiptim";
            this.textBox_nhiptim.Size = new System.Drawing.Size(94, 29);
            this.textBox_nhiptim.TabIndex = 15;
            this.textBox_nhiptim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_nhiptim.TextChanged += new System.EventHandler(this.textBox_nhiptim_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(673, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nhịp tim:";
            // 
            // textBox_huyetap
            // 
            this.textBox_huyetap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_huyetap.Location = new System.Drawing.Point(530, 127);
            this.textBox_huyetap.Multiline = true;
            this.textBox_huyetap.Name = "textBox_huyetap";
            this.textBox_huyetap.Size = new System.Drawing.Size(94, 29);
            this.textBox_huyetap.TabIndex = 13;
            this.textBox_huyetap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_huyetap.TextChanged += new System.EventHandler(this.textBox_huyetap_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(430, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Huyết áp:";
            // 
            // textBox_cannang
            // 
            this.textBox_cannang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_cannang.Location = new System.Drawing.Point(530, 79);
            this.textBox_cannang.Multiline = true;
            this.textBox_cannang.Name = "textBox_cannang";
            this.textBox_cannang.Size = new System.Drawing.Size(94, 29);
            this.textBox_cannang.TabIndex = 11;
            this.textBox_cannang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_cannang.TextChanged += new System.EventHandler(this.textBox_cannang_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(430, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cân nặng:";
            // 
            // textBox_chieucao
            // 
            this.textBox_chieucao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_chieucao.Location = new System.Drawing.Point(530, 31);
            this.textBox_chieucao.Multiline = true;
            this.textBox_chieucao.Name = "textBox_chieucao";
            this.textBox_chieucao.Size = new System.Drawing.Size(94, 29);
            this.textBox_chieucao.TabIndex = 9;
            this.textBox_chieucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_chieucao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(430, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chiều cao:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_nu.ForeColor = System.Drawing.Color.Black;
            this.radioButton_nu.Location = new System.Drawing.Point(214, 126);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(49, 21);
            this.radioButton_nu.TabIndex = 7;
            this.radioButton_nu.TabStop = true;
            this.radioButton_nu.Text = "Nữ";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_nam.ForeColor = System.Drawing.Color.Black;
            this.radioButton_nam.Location = new System.Drawing.Point(148, 126);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(60, 21);
            this.radioButton_nam.TabIndex = 6;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam\r\n";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            this.radioButton_nam.CheckedChanged += new System.EventHandler(this.radioButton_nam_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới tính:";
            // 
            // comboBox_tinhtrang
            // 
            this.comboBox_tinhtrang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_tinhtrang.FormattingEnabled = true;
            this.comboBox_tinhtrang.Items.AddRange(new object[] {
            "Khỏe mạnh",
            "Suy nhược",
            "Ốm yếu",
            "Mãn tính"});
            this.comboBox_tinhtrang.Location = new System.Drawing.Point(153, 79);
            this.comboBox_tinhtrang.Name = "comboBox_tinhtrang";
            this.comboBox_tinhtrang.Size = new System.Drawing.Size(172, 25);
            this.comboBox_tinhtrang.TabIndex = 4;
            this.comboBox_tinhtrang.SelectedIndexChanged += new System.EventHandler(this.comboBox_tinhtrang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tình trạng cơ thể:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 33);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(235, 25);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PhieuSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(949, 745);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhieuSucKhoe";
            this.Text = "PhieuSucKhoe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_dangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnu_phieusuckhoe;
        private System.Windows.Forms.ToolStripMenuItem mnu_muctieu;
        private System.Windows.Forms.ToolStripMenuItem mnu_baocao;
        private System.Windows.Forms.ToolStripMenuItem mnu_nhacnho;
        private System.Windows.Forms.ToolStripMenuItem mnu_thoat;
        private Button btn_xoa;
        private Button btn_capnhat;
        private Button btn_huybo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_huytim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tinhtrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.RadioButton radioButton_nam;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_nhietdocothe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_luongduong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_nhiptim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_huyetap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_cannang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_chieucao;
        private System.Windows.Forms.Button btn_them;
        private DataGridView dataGridView1;
    }
}