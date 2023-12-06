using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_với_CSDL
{
    public partial class Bang_cap : Form
    {
        public Bang_cap()
        {
            InitializeComponent();
        }

        SqlConnect data = new SqlConnect();

        public void LoadBangCap()
        {
            DGV_BangCap.DataSource = data.table("Select * From BangCap");
            DGV_BangCap.AutoResizeColumns();
        }
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select manv, tenbangcap,xeploai From NhanVien_BangCap inner join BangCap on NhanVien_BangCap.mabangcap = BangCap.mabangcap");
            DGV_NhanVien.AutoResizeColumns();
        }
        public void LoadComboBox()
        {
            cbb_MBC.DataSource = data.table("Select * From BangCap");
            cbb_MBC.DisplayMember = "tenbangcap";
            cbb_MBC.ValueMember = "mabangcap";
        }

        public int CheckBangCap(string ma)
        {
            string query = "select COUNT(*) from BangCap where mabangcap = '" + ma +"'";
            return data.kiemtra(query);
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int Check_NVBC(string manv, string mabc)
        {
            string query = "select COUNT(*) from NhanVien_BangCap where manv = '" + manv + "' and mabangcap = '" + mabc + "'";
            return data.kiemtra(query);
        }

        public void ResetBangCap()
        {
            txt_MBC.ResetText();
            txt_TBC.ResetText();
            txt_MBC.Focus();
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            cbb_MBC.SelectedIndex = 0;
            cbb_XL.SelectedIndex = 0;
            txt_MNV.Focus();
        }

        private void Bang_cap_Load(object sender, EventArgs e)
        {
            LoadBangCap();
            LoadNhanVien();
            LoadComboBox();
            cbb_XL.Items.Add("Xuất sắc");
            cbb_XL.Items.Add("Giỏi");
            cbb_XL.Items.Add("Khá");
            cbb_XL.Items.Add("Trung bình");
            cbb_XL.SelectedIndex = 0;
        }

        private void btn_Them1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBC.Text) || string.IsNullOrEmpty(txt_TBC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bằng cấp");
            }
            else if(CheckBangCap(txt_MBC.Text) == 1)
            {
                MessageBox.Show("Mã bằng cấp đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into BangCap values ('" + txt_MBC.Text + "',N'" + txt_TBC.Text + "')";
                    data.command(query);
                    LoadBangCap();
                    LoadComboBox();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBangCap();
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBC.Text) || string.IsNullOrEmpty(txt_TBC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bằng cấp");
            }
            else if (CheckBangCap(txt_MBC.Text) == 0)
            {
                MessageBox.Show("Mã bằng cấp không tồn tại");
            }
            else
            {
                try
                {
                    string query = "update BangCap set tenbangcap = N'" + txt_TBC.Text + "' where mabangcap ='" + txt_MBC.Text + "'";
                    data.command(query);
                    LoadBangCap();
                    LoadComboBox();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBangCap();
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MBC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bằng cấp");
            }
            else if (CheckBangCap(txt_MBC.Text) == 0)
            {
                MessageBox.Show("Mã bằng cấp không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from BangCap where mabangcap = '" + txt_MBC.Text + "'";
                    data.command(query);
                    LoadBangCap();
                    LoadComboBox();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetBangCap();
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
            else if(Check_NVBC(txt_MNV.Text, cbb_MBC.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }    
            else
            {
                try
                {
                    string query = "insert into NhanVien_BangCap values ('" + txt_MNV.Text + "','" + cbb_MBC.SelectedValue.ToString() + "',N'" + cbb_XL.Text + "')";
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

        private void btn_Sua2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã nhân viên");
            }
            else if (CheckNhanVien(txt_MNV.Text) == 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else if (Check_NVBC(txt_MNV.Text, cbb_MBC.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần sửa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien_BangCap values ('" + txt_MNV.Text + "','" + cbb_MBC.SelectedValue.ToString() + "',N'" + cbb_XL.Text + "')";
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
            else if (Check_NVBC(txt_MNV.Text, cbb_MBC.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Thông tin cần xóa không tồn tại");
            }
            else
            {
                try
                {
                    string query = "delete from NhanVien_BangCap where manv = '" + txt_MNV.Text + "' and mabangcap = '" + cbb_MBC.SelectedValue + "'";
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
    }
}
