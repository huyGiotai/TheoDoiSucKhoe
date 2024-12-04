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
using DTO;

namespace GUI
{
    public partial class MucTieu : Form
    {
        private MucTieuBLL mucTieuBLL = new MucTieuBLL();
        public MucTieu()
        {
            InitializeComponent();
            LoadMucTieu();
            LoadMucTieuHoanThanh();
        }

        private void LoadMucTieu()
        {
            var data = mucTieuBLL.GetAllMucTieu();
            if (data.Count == 0)
            {
                MessageBox.Show("Không có mục tiêu nào để hiển thị!");
            }
            dataGridView_muctieu.DataSource = data;
            dataGridView_muctieu.Columns["MaPhieu"].Visible = false;
            dataGridView_muctieu.Columns["Id"].Visible = false;
        }

        private void LoadMucTieuHoanThanh()
        {
            var completedTargets = mucTieuBLL.GetAllMucTieuHoanThanh();
            if (completedTargets.Count == 0)
            {
                MessageBox.Show("Chưa có mục tiêu nào hoàn thành!");
            }
            dataGridView_hoanthanh.DataSource = completedTargets;
            dataGridView_hoanthanh.Columns["Id"].Visible = false; // Ẩn cột ID
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ChieuCaoVaCanNangDTO target = new ChieuCaoVaCanNangDTO
                {
                    MaPhieu = 1, // Giả lập, lấy từ người dùng hoặc session
                    ThoiGian = textBox_thoigian.Text,
                    ChieuCao = float.Parse(textBox_chieucao.Text),
                    CanNang = float.Parse(textBox_cannang.Text)
                };

                if (mucTieuBLL.AddMucTieu(target))
                {
                    MessageBox.Show("Thêm mục tiêu thành công!");
                    LoadMucTieu();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Thêm mục tiêu thất bại!");
                }
            }
        }

        private void button_capnhat_Click(object sender, EventArgs e)
        {
            if (dataGridView_muctieu.SelectedRows.Count > 0 && ValidateInput())
            {
                int id = (int)dataGridView_muctieu.SelectedRows[0].Cells["Id"].Value;

                ChieuCaoVaCanNangDTO target = new ChieuCaoVaCanNangDTO
                {
                    Id = id,
                    ThoiGian = textBox_thoigian.Text,
                    ChieuCao = float.Parse(textBox_chieucao.Text),
                    CanNang = float.Parse(textBox_cannang.Text)
                };

                if (mucTieuBLL.UpdateMucTieu(target))
                {
                    MessageBox.Show("Cập nhật mục tiêu thành công!");
                    LoadMucTieu();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục tiêu cần cập nhật!");
            }
        }

        private void button_xoas_Click(object sender, EventArgs e)
        {
            if (dataGridView_muctieu.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa mục tiêu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)dataGridView_muctieu.SelectedRows[0].Cells["Id"].Value;
                    if (mucTieuBLL.DeleteMucTieu(id))
                    {
                        MessageBox.Show("Xóa mục tiêu thành công!");
                        LoadMucTieu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! Vui lòng thử lại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục tiêu cần xóa!");
            }
        }

        private void button_hoanthanh_Click(object sender, EventArgs e)
        {
            if (dataGridView_muctieu.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView_muctieu.SelectedRows[0].Cells["Id"].Value;
                DataGridViewRow selectedRow = dataGridView_muctieu.SelectedRows[0];
                MucTieuHoanThanhDTO completedTarget = new MucTieuHoanThanhDTO
                {
                    ThoiGianHoanThanh = DateTime.Now.ToString(),
                    ChieuCaoHoanThanh = (float)selectedRow.Cells["ChieuCao"].Value,
                    CanNangHoanThanh = (float)selectedRow.Cells["CanNang"].Value
                };

                if (mucTieuBLL.CompleteMucTieu(completedTarget, id))
                {
                    MessageBox.Show("Mục tiêu đã hoàn thành!");
                    LoadMucTieu();
                    LoadMucTieuHoanThanh(); // Đảm bảo gọi lại phương thức này để hiển thị dữ liệu đã hoàn thành
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục tiêu để hoàn thành!");
            }
        }

        private void button_lammoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn làm mới tất cả mục tiêu?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool isCleared = mucTieuBLL.ClearAllMucTieu();
                    if (isCleared)
                    {
                        LoadMucTieu(); // Tải lại danh sách mục tiêu
                        LoadMucTieuHoanThanh(); // Tải lại danh sách mục tiêu hoàn thành
                        MessageBox.Show("Đã làm mới tất cả mục tiêu.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể làm mới mục tiêu, vui lòng thử lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi làm mới mục tiêu: {ex.Message}");
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_thoigian.Text) ||
                 string.IsNullOrWhiteSpace(textBox_chieucao.Text) ||
                 string.IsNullOrWhiteSpace(textBox_cannang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }

            if (!float.TryParse(textBox_chieucao.Text, out _) || !float.TryParse(textBox_cannang.Text, out _))
            {
                MessageBox.Show("Chiều cao và cân nặng phải là số hợp lệ!");
                return false;
            }

            float chieuCao = float.Parse(textBox_chieucao.Text);
            float canNang = float.Parse(textBox_cannang.Text);

            if (chieuCao <= 0)
            {
                MessageBox.Show("Chiều cao phải lớn hơn 0");
                return false;
            }

            if (canNang <= 0 || canNang > 500)
            {
                MessageBox.Show("Cân nặng phải trong khoảng từ 1 đến 500 kg!");
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            textBox_thoigian.Clear();
            textBox_chieucao.Clear();
            textBox_cannang.Clear();
        }

        private void dataGridView_hoanthanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_muctieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một dòng
            //if (e.RowIndex >= 0 && e.RowIndex < dataGridView_muctieu.Rows.Count)
            //{
            //    DataGridViewRow row = dataGridView_muctieu.Rows[e.RowIndex];

            //    // Kiểm tra nếu các giá trị không null
            //    if (row.Cells["ThoiGian"].Value != null &&
            //        row.Cells["ChieuCao"].Value != null &&
            //        row.Cells["CanNang"].Value != null)
            //    {
            //        textBox_thoigian.Text = row.Cells["ThoiGian"].Value.ToString();
            //        textBox_chieucao.Text = row.Cells["ChieuCao"].Value.ToString();
            //        textBox_cannang.Text = row.Cells["CanNang"].Value.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không có mục tiêu nào!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một mục tiêu!");
            //}
        }

        private void textBox_chieucao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
