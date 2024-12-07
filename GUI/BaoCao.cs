using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BaoCao : Form
    {
        private BaoCaoBLL baocaoBLL = new BaoCaoBLL();
        public BaoCao()

        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                DataTable dataTable = baocaoBLL.GetAll();  // Get data using BLL
                dataGridView_baocao.DataSource = dataTable;  // Bind the data to DataGridView

                // Hide the columns "MaPhieu" and "UserID"
                if (dataGridView_baocao.Columns["MaPhieu"] != null)
                {
                    dataGridView_baocao.Columns["MaPhieu"].Visible = false;
                }

                if (dataGridView_baocao.Columns["UserID"] != null)
                {
                    dataGridView_baocao.Columns["UserID"].Visible = false;
                }

                // Update column headers
                dataGridView_baocao.Columns["Ngay"].HeaderText = "Ngày";
                dataGridView_baocao.Columns["TinhTrangCoThe"].HeaderText = "Tình Trạng Cơ Thể";
                dataGridView_baocao.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dataGridView_baocao.Columns["ChieuCao"].HeaderText = "Chiều Cao (cm)";
                dataGridView_baocao.Columns["CanNang"].HeaderText = "Cân Nặng (kg)";
                dataGridView_baocao.Columns["HuyetAp"].HeaderText = "Huyết Áp";
                dataGridView_baocao.Columns["NhipTim"].HeaderText = "Nhịp Tim";
                dataGridView_baocao.Columns["LuongDuongMau"].HeaderText = "Lượng Đường Máu";
                dataGridView_baocao.Columns["NhietDoCoThe"].HeaderText = "Nhiệt Độ Cơ Thể";

                dataGridView_baocao.Refresh();  // Refresh the DataGridView to reflect changes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
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


        private void dataGridView_hoanthanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_muctieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxtimchieucao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MucTieu_Load(object sender, EventArgs e)
        {

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBaoCaoNhipTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoiKhuyen_Click(object sender, EventArgs e)
        {// Kiểm tra nếu có dòng nào được chọn
            if (dataGridView_baocao.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                DataGridViewRow row = dataGridView_baocao.SelectedRows[0];

                // Lấy các giá trị từ dòng để tính BMI và so sánh các chỉ số
                float chieuCao = Convert.ToSingle(row.Cells["ChieuCao"].Value);
                float canNang = Convert.ToSingle(row.Cells["CanNang"].Value);
                string huyetAp = row.Cells["HuyetAp"].Value.ToString();
                int nhipTim = Convert.ToInt32(row.Cells["NhipTim"].Value);
                float nhietDo = Convert.ToSingle(row.Cells["NhietDoCoThe"].Value);

                // Tính toán BMI
                float bmi = CalculateBMI(chieuCao, canNang);
                string bmiStatus = CompareWithHealthyBMI(bmi);

                // So sánh các chỉ số sức khỏe
                string healthStatus = CompareWithHealthyStandard(huyetAp, nhipTim, nhietDo);

                // Hiển thị kết quả
                texthienthi.Text = $"BMI: {bmi:F2} ({bmiStatus})";
                textBaocaohuyetap.Text = $"Huyết áp: {healthStatus}";
                

                // Cung cấp lời khuyên dựa trên các chỉ số
                string advice = "Lời khuyên:\n";
                if (bmiStatus.Contains("Béo phì") || healthStatus.Contains("Không bình thường"))
                {
                    advice += "Bạn cần cải thiện chế độ ăn uống và vận động thường xuyên. Hãy tham khảo ý kiến bác sĩ để có kế hoạch điều chỉnh.";
                }
                else
                {
                    advice += "Chỉ số của bạn ổn định. Tiếp tục duy trì chế độ sinh hoạt lành mạnh!";
                }

                MessageBox.Show(advice);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng để xem thông tin.");
            }
        }

        private void texttimngay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttontimngay_Click(object sender, EventArgs e)
        {
            string selectedDate = dateTimetimngay.Value.ToString("yyyy-MM-dd");

            BaoCaoBLL bll = new BaoCaoBLL();
            List<BaoCaoDTO> list = bll.GetBaoCaoByDate(selectedDate);  // Get reports by date

            if (list.Count > 0)
            {
                dataGridView_baocao.DataSource = list;  // Bind filtered data to DataGridView
            }
            else
            {
                MessageBox.Show("No data found for this date.");
            }
        }

        private void textBox_timcannang_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_timnhietdo_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttimttct_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtimHuyetap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtimnhiptim_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void texthienthi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBaocaohuyetap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbaocaonhietdocothe_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BaoCao_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public float CalculateBMI(float chieuCao, float canNang)
        {
            // Công thức BMI = Cân nặng (kg) / Chiều cao^2 (m^2)
            return canNang / (chieuCao / 100 * chieuCao / 100); // Chuyển chiều cao từ cm sang m
        }
       
        public string CompareWithHealthyBMI(float bmi)
        {
            if (bmi < 18.5) return "Thiếu cân";
            else if (bmi >= 18.5 && bmi < 24.9) return "Cân nặng bình thường";
            else if (bmi >= 25 && bmi < 29.9) return "Thừa cân";
            else return "Béo phì";
        }
        public string CompareWithHealthyStandard(string huyetAp, int nhipTim, float nhietDo)
        {
            string huyetApStatus = huyetAp == "120/80"
                ? "Bình thường"
                : "Không bình thường: Điều chỉnh chế độ ăn uống (giảm muối, tăng kali), tập thể dục đều đặn, và kiểm tra sức khỏe định kỳ. Nếu vấn đề nghiêm trọng, cần tham khảo bác sĩ để được điều trị.";

            string nhipTimStatus = (nhipTim >= 60 && nhipTim <= 100)
                ? "Bình thường"
                : "Không bình thường: Kiểm soát chế độ ăn, hạn chế đường và carbohydrate tinh chế, tăng cường tập luyện thể dục. Tham khảo bác sĩ để kiểm tra đường huyết và điều chỉnh thuốc nếu cần.";

            string nhietDoStatus = (nhietDo >= 36.5 && nhietDo <= 37.5)
                ? "Bình thường"
                : "Không bình thường: Nếu sốt, cần nghỉ ngơi, uống đủ nước, và sử dụng thuốc hạ sốt nếu cần. Nếu nhiệt độ quá thấp (hạ thân nhiệt), cần giữ ấm cơ thể và tham khảo ý kiến bác sĩ.";

            return $"Huyết áp: {huyetApStatus}\nNhịp tim: {nhipTimStatus}\nNhiệt độ cơ thể: {nhietDoStatus}";
        }




        private void dataGridView_baocao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Kiểm tra nếu có dòng hợp lệ được chọn
            {
                // Lấy dòng đã chọn
                DataGridViewRow row = dataGridView_baocao.Rows[e.RowIndex];

                // Lấy các giá trị từ dòng để tính BMI và so sánh các chỉ số
                float chieuCao = Convert.ToSingle(row.Cells["ChieuCao"].Value);
                float canNang = Convert.ToSingle(row.Cells["CanNang"].Value);
                string huyetAp = row.Cells["HuyetAp"].Value.ToString();
                int nhipTim = Convert.ToInt32(row.Cells["NhipTim"].Value);
                float nhietDo = Convert.ToSingle(row.Cells["NhietDoCoThe"].Value);

                // Tính toán BMI
                float bmi = CalculateBMI(chieuCao, canNang);
                string bmiStatus = CompareWithHealthyBMI(bmi);

                // So sánh các chỉ số sức khỏe
                string healthStatus = CompareWithHealthyStandard(huyetAp, nhipTim, nhietDo);

                // Hiển thị kết quả lên các textbox hoặc label tương ứng
                texthienthi.Text = $"BMI: {bmi:F2} ({bmiStatus})";
                textBaocaohuyetap.Text = $"Huyết áp: {healthStatus}";

            }
        }

        private void mnu_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhieuSucKhoe phieuSucKhoe = new PhieuSucKhoe();
            phieuSucKhoe.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MucTieu muctieu = new MucTieu();
            muctieu.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loikhuyen mainForm = new Loikhuyen();
            mainForm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
