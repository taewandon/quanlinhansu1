using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_với_CSDL
{
    public partial class Chung_chi : Form
    {
        public Chung_chi()
        {
            InitializeComponent();
        }
        SqlConnect data = new SqlConnect();
        public void LoadChungChi()
        {
            DGV_ChungChi.DataSource = data.table("Select * from ChungChi");
            DGV_ChungChi.AutoResizeColumns();
        }
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select manv, machungchi From NhanVien_ChungChi inner join ChungChi on NhanVien_ChungChi.machungchi = ChungChi.machungchi");
            DGV_NhanVien.AutoResizeColumns();
        }
        public void LoadComboBox()
        {
            cbb_CC.DataSource = data.table("Select * From ChungChi");
            cbb_CC.DisplayMember = "tenchungchi";
            cbb_CC.ValueMember = "machungchi";
        }
            public int CheckChungChi(string ma)
        {
            string query = "select COUNT(*) from ChungChi where machungchi = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int Check_NVCC(string manv, string macc)
        {
            string query = "select COUNT(*) from NhanVien_ChungChi where manv = '" + manv + "' and machungchi = '" + macc + "'";
            return data.kiemtra(query);
        }

        public void ResetChungChi()
        {
            txt_MCC.ResetText();
            txt_TCC.ResetText();
            txt_TH.ResetText();
            txt_MCC.Focus();
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            cbb_CC.SelectedIndex = 0;
            txt_MNV.Focus();
        }

        private void btn_Them1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MCC.Text) || string.IsNullOrEmpty(txt_TCC.Text) || string.IsNullOrEmpty(txt_TH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chứng chỉ");
            }
            else if (CheckChungChi(txt_MCC.Text) == 1)
            {
                MessageBox.Show("Mã chứng chỉ đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into ChungChi values ('" + txt_MCC.Text + "',N'" + txt_TCC.Text + "','" + txt_TH.Text + "')";
                    data.command(query);
                    LoadChungChi();
                    LoadComboBox();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetChungChi();
        }

        private void Chung_chi_Load_1(object sender, EventArgs e)
        {
            LoadChungChi();
            LoadNhanVien();
            LoadComboBox();
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MCC.Text) || string.IsNullOrEmpty(txt_TCC.Text) || string.IsNullOrEmpty(txt_TH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chứng chỉ");
            }
            else if (CheckChungChi(txt_MCC.Text) == 0)
            {
                MessageBox.Show("Mã chứng chỉ không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update ChungChi set tenchungchi = N'" + txt_TCC.Text + "', thoihan = '" + txt_TH.Text + "'where machungchi ='" + txt_MCC.Text + "'";
                    data.command(query);
                    LoadChungChi();
                    LoadComboBox();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetChungChi();
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã chứng chi");
            }
            else if (CheckChungChi(txt_MCC.Text) == 0)
            {
                MessageBox.Show("Mã chứng chỉ không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from ChungChi where machungchi = '" + txt_MCC.Text + "'";
                    data.command(query);
                    LoadChungChi();
                    LoadComboBox();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetChungChi();
        }

        private void btn_Them2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else if (Check_NVCC(txt_MNV.Text, cbb_CC.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien_ChungChi values ('" + txt_MNV.Text + "','" + cbb_CC.SelectedValue.ToString() + "','" + dateTime_NC.Value + "')";
                    data.command(query);
                    LoadNhanVien();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetNhanVien();
        }

        private void btn_Xoa2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from NhanVien_ChungChi where manv = '" + txt_MNV.Text + "' and machungchi = '" + cbb_CC.SelectedValue.ToString() + "'";
                    data.command(query);
                    LoadNhanVien();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetNhanVien();
        }

        private void btn_Sua2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update NhanVien_ChungChi set ngaycap ='" + dateTime_NC.Value + "' where manv ='" + txt_MNV.Text + "' and machungchi = '" + cbb_CC.SelectedValue.ToString() + "'";
                    data.command(query);
                    LoadNhanVien();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetNhanVien();
        }
    }
}

