using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace GUI
{
    public partial class PhieuSucKhoe : Form
    {
        private ChiSoSuckhoeBLL bll = new ChiSoSuckhoeBLL();
        private readonly ChiSoSucKhoeDAL chiSoDAL = new ChiSoSucKhoeDAL();
        public PhieuSucKhoe()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable dataTable = chiSoDAL.GetAll();
                dataGridView1.DataSource = dataTable;

                // Ẩn các cột "MaPhieu" và "UserID"
                if (dataGridView1.Columns["MaPhieu"] != null)
                {
                    dataGridView1.Columns["MaPhieu"].Visible = false;
                }

                if (dataGridView1.Columns["UserID"] != null)
                {
                    dataGridView1.Columns["UserID"].Visible = false;
                }

                // Cập nhật tiêu đề các cột
                dataGridView1.Columns["Ngay"].HeaderText = "Ngày";
                dataGridView1.Columns["TinhTrangCoThe"].HeaderText = "Tình Trạng Cơ Thể";
                dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dataGridView1.Columns["ChieuCao"].HeaderText = "Chiều Cao (cm)";
                dataGridView1.Columns["CanNang"].HeaderText = "Cân Nặng (kg)";
                dataGridView1.Columns["HuyetAp"].HeaderText = "Huyết Áp";
                dataGridView1.Columns["NhipTim"].HeaderText = "Nhịp Tim";
                dataGridView1.Columns["LuongDuongMau"].HeaderText = "Lượng Đường Máu";
                dataGridView1.Columns["NhietDoCoThe"].HeaderText = "Nhiệt Độ Cơ Thể";

                // Làm mới DataGridView sau khi ẩn cột
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        


        private void mnu_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MucTieu muctieu = new MucTieu();
            muctieu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData(); // Hiển thị lại toàn bộ dữ liệu
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // Làm mới các trường nhập

            // Đặt lại giá trị cho DateTimePicker
            dateTimePicker2.Value = DateTime.Now; // Hoặc một giá trị mặc định nếu cần

            // Đặt lại giá trị cho ComboBox (Tình Trạng Cơ Thể)
            comboBox_tinhtrang.SelectedIndex = -1; // Đặt lại ComboBox về trạng thái mặc định (không chọn gì)

            // Đặt lại giá trị cho RadioButton (Giới Tính)
            radioButton_nam.Checked = false;
            radioButton_nu.Checked = false;

            // Đặt lại giá trị cho TextBox
            textBox_chieucao.Clear();
            textBox_cannang.Clear();
            textBox_huyetap.Clear();
            textBox_nhiptim.Clear();
            textBox_luongduong.Clear();
            textBox_nhietdocothe.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng đã chọn một dòng hợp lệ
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị dữ liệu vào các trường nhập
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["Ngay"].Value);
                comboBox_tinhtrang.SelectedItem = row.Cells["TinhTrangCoThe"].Value.ToString();

                // Cập nhật các trường nhập theo dữ liệu từ dòng
                radioButton_nam.Checked = row.Cells["GioiTinh"].Value.ToString() == "Nam";
                radioButton_nu.Checked = row.Cells["GioiTinh"].Value.ToString() == "Nữ";

                textBox_chieucao.Text = row.Cells["ChieuCao"].Value.ToString();
                textBox_cannang.Text = row.Cells["CanNang"].Value.ToString();
                textBox_huyetap.Text = row.Cells["HuyetAp"].Value.ToString();
                textBox_nhiptim.Text = row.Cells["NhipTim"].Value.ToString();
                textBox_luongduong.Text = row.Cells["LuongDuongMau"].Value.ToString();
                textBox_nhietdocothe.Text = row.Cells["NhietDoCoThe"].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox_chieucao.Text) || !float.TryParse(textBox_chieucao.Text, out float chieuCao) || chieuCao <= 0)
            //{
            //    MessageBox.Show("Chiều cao phải là số dương.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) // Gọi phương thức kiểm tra dữ liệu đầu vào
                    return;

                ChiSoSucKhoeDTO chiSo = new ChiSoSucKhoeDTO
                {
                    UserID = 1, // Tạm đặt cố định hoặc lấy từ thông tin đăng nhập
                    Ngay = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                    TinhTrangCoThe = comboBox_tinhtrang.SelectedItem.ToString(),
                    GioiTinh = radioButton_nam.Checked ? "Nam" : "Nữ",
                    ChieuCao = float.Parse(textBox_chieucao.Text),
                    CanNang = float.Parse(textBox_cannang.Text),
                    HuyetAp = textBox_huyetap.Text,
                    NhipTim = int.Parse(textBox_nhiptim.Text),
                    LuongDuongMau = float.Parse(textBox_luongduong.Text),
                    NhietDoCoThe = float.Parse(textBox_nhietdocothe.Text)
                };

                if (bll.AddChiSo(chiSo))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputFields(); // Xóa trắng các trường nhập liệu sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            StringBuilder errorMsg = new StringBuilder();

            if (comboBox_tinhtrang.SelectedIndex == -1)
                errorMsg.AppendLine("Vui lòng chọn tình trạng cơ thể.");

            if (!float.TryParse(textBox_chieucao.Text, out float chieuCao) || chieuCao <= 0)
                errorMsg.AppendLine("Chiều cao phải là số dương.");

            if (!float.TryParse(textBox_cannang.Text, out float canNang) || canNang <= 0)
                errorMsg.AppendLine("Cân nặng phải là số dương.");

            if (string.IsNullOrEmpty(textBox_huyetap.Text))
                errorMsg.AppendLine("Vui lòng nhập huyết áp.");

            if (!int.TryParse(textBox_nhiptim.Text, out int nhipTim) || nhipTim <= 0)
                errorMsg.AppendLine("Nhịp tim phải là số dương.");

            if (!float.TryParse(textBox_luongduong.Text, out float luongDuongMau) || luongDuongMau <= 0)
                errorMsg.AppendLine("Lượng đường máu phải là số dương.");

            if (!float.TryParse(textBox_nhietdocothe.Text, out float nhietDoCoThe) || nhietDoCoThe <= 0)
                errorMsg.AppendLine("Nhiệt độ cơ thể phải là số dương.");

            if (errorMsg.Length > 0)
            {
                MessageBox.Show(errorMsg.ToString(), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            comboBox_tinhtrang.SelectedIndex = -1;
            radioButton_nam.Checked = false;
            radioButton_nu.Checked = false;
            textBox_chieucao.Clear();
            textBox_cannang.Clear();
            textBox_huyetap.Clear();
            textBox_nhiptim.Clear();
            textBox_luongduong.Clear();
            textBox_nhietdocothe.Clear();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string ngayTim = dateTimePicker_tim.Value.ToString("yyyy-MM-dd");

            DataTable dt = bll.GetAll();
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"Ngay = '{ngayTim}'"; // Tìm kiếm theo ngày lưu dạng chuỗi
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Không tìm thấy chỉ số sức khỏe trong ngày này.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int maPhieu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaPhieu"].Value);

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bll.DeleteChiSo(maPhieu))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInputs()) // Kiểm tra dữ liệu nhập vào
                    return;

                ChiSoSucKhoeDTO chiSo = new ChiSoSucKhoeDTO
                {
                    MaPhieu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaPhieu"].Value),
                    UserID = 1, // Tạm thời gán UserID cố định
                    Ngay = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                    TinhTrangCoThe = comboBox_tinhtrang.SelectedItem.ToString(),
                    GioiTinh = radioButton_nam.Checked ? "Nam" : "Nữ",
                    ChieuCao = float.Parse(textBox_chieucao.Text),
                    CanNang = float.Parse(textBox_cannang.Text),
                    HuyetAp = textBox_huyetap.Text,
                    NhipTim = int.Parse(textBox_nhiptim.Text),
                    LuongDuongMau = float.Parse(textBox_luongduong.Text),
                    NhietDoCoThe = float.Parse(textBox_nhietdocothe.Text)
                };

                if (bll.UpdateChiSo(chiSo))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputFields(); // Làm mới trường nhập liệu sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_tinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_cannang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_huyetap_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_nhiptim_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox_luongduong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_nhietdocothe_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mnu_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnu_phieusuckhoe_Click(object sender, EventArgs e)
        {

        }

        private void mnu_baocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCao mainForm = new BaoCao();
            mainForm.Show();
        }

        private void mnu_nhacnho_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loikhuyen mainForm = new Loikhuyen();
            mainForm.Show();
        }
    }
}
