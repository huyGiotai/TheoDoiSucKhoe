using BLL;
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
        {

        }

        private void texttimngay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttontimngay_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ngày từ TextBox (texttimngay)
                DateTime selectedDate;
                if (!DateTime.TryParse(texttimngay.Text, out selectedDate))
                {
                    MessageBox.Show("Vui lòng nhập ngày hợp lệ!");
                    return;
                }

                // Tạo đối tượng BLL để lấy dữ liệu
                BaoCaoBLL baoCaoBLL = new BaoCaoBLL();
                BaoCaoDTO baoCaoData = baoCaoBLL.GetBaoCaoData(selectedDate);

                if (baoCaoData == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho ngày này.");
                    return;
                }

                // Hiển thị dữ liệu lên các TextBox
                textBox_timchieucao.Text = baoCaoData.ChieuCao.ToString();
                textBox_timcannang.Text = baoCaoData.CanNang.ToString();
                textBox_timnhietdo.Text = baoCaoData.NhietDoCoThe.ToString();
                textBoxtimHuyetap.Text = baoCaoData.HuyetAp;
                textBoxtimnhiptim.Text = baoCaoData.NhipTim.ToString();

                // Tính và hiển thị BMI
                float bmi = baoCaoBLL.CalculateBMI(baoCaoData.ChieuCao, baoCaoData.CanNang);
                textBMI.Text = bmi.ToString("0.0");

                // Hiển thị trạng thái BMI
                texthienthi.Text = baoCaoBLL.GetBMIStatus(bmi);

                // Hiển thị trạng thái huyết áp, nhịp tim và nhiệt độ
                textBaocaohuyetap.Text = baoCaoBLL.GetBloodPressureStatus(baoCaoData.HuyetAp);
                textbaocaonhiptim.Text = baoCaoBLL.GetHeartRateStatus(baoCaoData.NhipTim);
                textbaocaonhietdocothe.Text = baoCaoBLL.GetTemperatureStatus(baoCaoData.NhietDoCoThe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
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

        }
    }
}
