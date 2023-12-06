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
    public partial class Phong_ban : Form
    {
        public Phong_ban()
        {
            InitializeComponent();
        }
        SqlConnect data=new SqlConnect();
        public void LoadPhongBan()
        {
            DGV_PhongBan.DataSource = data.table("Select * From PhongBan");
            DGV_PhongBan.AutoResizeColumns();
        }
        public void LoadNhanVien()
        {
            DGV_NhanVien.DataSource = data.table("Select manv,tenphongban From NhanVien_PhongBan inner join PhongBan on NhanVien_PhongBan.maphongban = PhongBan.maphongban");
            DGV_NhanVien.AutoResizeColumns();
        }
        public void LoadComboBox()
        {
            cbb_PB.DataSource = data.table("Select * From PhongBan");
            cbb_PB.DisplayMember = "tenphongban";
            cbb_PB.ValueMember = "maphongban";
        }

        public int CheckPhongBan(string ma)
        {
            string query = "select COUNT(*) from PhongBan where maphongban = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int CheckNhanVien(string ma)
        {
            string query = "select COUNT(*) from NhanVien where manv = '" + ma + "'";
            return data.kiemtra(query);
        }
        public int Check_NVPB(string manv, string mapb)
        {
            string query = "select COUNT(*) from NhanVien_PhongBan where manv = '" + manv + "' and maphongban = '" + mapb + "'";
            return data.kiemtra(query);
        }

        public void ResetPhongBan()
        {
            txt_MPB.ResetText();
            txt_TPB.ResetText();
            txt_MPB.Focus();
        }
        public void ResetNhanVien()
        {
            txt_MNV.ResetText();
            cbb_PB.SelectedIndex = 0;
            txt_MNV.Focus();
        }
        private void btn_Them1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MPB.Text) || string.IsNullOrEmpty(txt_TPB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng ban");
            }
            else if (CheckPhongBan(txt_MPB.Text) == 1)
            {
                MessageBox.Show("Phòng ban này đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into PhongBan values ('" + txt_MPB.Text + "',N'" + txt_TPB.Text + "')";
                    data.command(query);
                    LoadPhongBan();
                    LoadComboBox();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetPhongBan();
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MPB.Text) || string.IsNullOrEmpty(txt_TPB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng ban");
            }
            else if (CheckPhongBan(txt_MPB.Text) == 0)
            {
                MessageBox.Show("Không tồn tại phòng ban này !");
            }
            else
            {
                try
                {
                    string query = "update  set tenphongban = N'" + txt_TPB.Text + "' where maphongban ='" + txt_MPB.Text + "'";
                    data.command(query);
                    LoadPhongBan();
                    LoadComboBox();
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetPhongBan();
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MPB.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban");
            }
            else if (CheckPhongBan(txt_MPB.Text) == 0)
            {
                MessageBox.Show("Không tồn tại phòng ban này");
            }
            else
            {
                try
                {
                    string query = "delete from PhongBan where maphongban = '" + txt_MPB.Text + "'";
                    data.command(query);
                    LoadPhongBan();
                    LoadComboBox();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }
            ResetPhongBan();
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
            else if (Check_NVPB(txt_MNV.Text, cbb_PB.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Thông tin đã tồn tại");
            }
            else
            {
                try
                {
                    string query = "insert into NhanVien_PhongBan values ('" + txt_MNV.Text + "','" + cbb_PB.SelectedValue.ToString() + "')";
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
                    string query = "delete from NhanVien_PhongBan where manv = '" + txt_MNV.Text + "' and maphongban = '" + cbb_PB.SelectedValue + "'";
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
        private void Phong_ban_Load(object sender, EventArgs e)
        {
            LoadPhongBan();
            LoadNhanVien();
            LoadComboBox();
        }

       
    }
}
