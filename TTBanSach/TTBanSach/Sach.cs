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
using TTBanSach.App_Code.Sach;
using TTBanSach;
namespace TTBanSach
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
            FillComboCD();
            FillComboNXB();
        }
        private int kt;
        public int a;
        void Enable(bool e)
        {

            txtGiaBan.Enabled = e;
            txtMaSach.Enabled = e;
            txtMoTa.Enabled = e;
            txtSoLuong.Enabled = e;
            txtTenSach.Enabled = e;
            cmbNXB.Enabled = e;
            cmbChuDe.Enabled = e;
            dtNgayCN.Enabled = e;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            grSach.DataSource = SQLData.Sach_Search(txtTimKiem.Text);
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            grSach.DataSource = SQLData.Sach_GetByAll();
            this.Location = new Point(250, 1);
        }
        void FillComboCD()
        {
            string Sql = "select TenChuDe from ChuDe";
            SqlConnection con = Data.GetConnection();
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmbChuDe.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }
        void FillComboNXB()
        {
            string Sql = "select TenNXB from NhaXuatBan";
            SqlConnection con = Data.GetConnection();
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmbNXB.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            Enable(true);
            txtMaSach.Enabled = false;

            txtGiaBan.Text = "";
            txtMaSach.Text = "";
            txtMoTa.Text = "";
            txtSoLuong.Text = "";
            txtTenSach.Text = "";
            cmbChuDe.Text = "";
            cmbNXB.Text = "";
            dtNgayCN.Text = "";
            dtNgayCN.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void grSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                txtMaSach.Text = grSach.Rows[rowIndex].Cells[0].Value.ToString();
                txtTenSach.Text = grSach.Rows[rowIndex].Cells[1].Value.ToString();
                txtGiaBan.Text = grSach.Rows[rowIndex].Cells[2].Value.ToString();
                txtMoTa.Text = grSach.Rows[rowIndex].Cells[3].Value.ToString();
                dtNgayCN.Text = grSach.Rows[rowIndex].Cells[4].Value.ToString();

                txtSoLuong.Text = grSach.Rows[rowIndex].Cells[5].Value.ToString();
                cmbChuDe.Text = grSach.Rows[rowIndex].Cells[6].Value.ToString();
                cmbNXB.Text = grSach.Rows[rowIndex].Cells[7].Value.ToString();
            }
            catch { }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kt == 1)
                {
                    Info sv = new Info();
                    sv.TenSach = txtTenSach.Text;
                    sv.GiaBan = decimal.Parse(txtGiaBan.Text);
                    sv.MoTa = txtMoTa.Text;
                    sv.NgayCapNhat = dtNgayCN.Value;

                    sv.SoLuongTon = int.Parse(txtSoLuong.Text);
                    sv.TenChuDe = cmbChuDe.Text;
                    sv.TenNXB = cmbNXB.Text;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnHuy.Enabled = false;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    try
                    {
                        SQLData.Sach_Insert(sv);
                        MessageBox.Show("Thêm thành công");
                        Enable(false);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi");
                    }
                    frmSach_Load(sender, e);
                }
                else
                {
                    Info sv = new Info();
                    sv.MaSach = int.Parse(txtMaSach.Text);
                    sv.TenSach = txtTenSach.Text;
                    sv.GiaBan = decimal.Parse(txtGiaBan.Text);
                    sv.MoTa = txtMoTa.Text;
                    sv.NgayCapNhat = dtNgayCN.Value;
                    sv.SoLuongTon = int.Parse(txtSoLuong.Text);
                    sv.TenChuDe = cmbChuDe.Text;
                    sv.TenNXB = cmbNXB.Text;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    try
                    {
                        SQLData.Sach_Update(sv);
                        Enable(false);
                        MessageBox.Show("Sửa Thành Công !");

                        frmSach_Load(sender, e);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Sửa Thất Bại !");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi !");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";

            txtSoLuong.Text = "";
            txtMoTa.Text = "";
            cmbChuDe.Text = "";
            dtNgayCN.Text = "";
            cmbNXB.Text = "";
            txtGiaBan.Text = "";
            Enable(false);
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 0;
            Enable(true);
            btnLuu.Enabled = true;
            txtMaSach.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SQLData.Sach_Delete(txtMaSach.Text);
                frmSach_Load(sender, e);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang newForm = new frmKhachHang();
            newForm.Show();
            this.Hide();
        }

        private void quảnLýTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia newForm = new frmTacGia();
            newForm.Show();
            this.Hide();
        }

        private void quảnLýNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan newForm = new frmNhaXuatBan();
            newForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            frmKhachHang kh = new frmKhachHang();
            kh.Show();
            //textBox1.Text = dtNgayCN.Text;
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon n = new frmHoaDon();
            n.Show();
            this.Hide();
        }

        private void chủĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuDe n = new frmChuDe();
            n.Show();
            this.Hide();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach n = new frmSach();
            n.Show();
            this.Hide();
        }

        private void sáchMớiNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBook n = new NewBook();
            n.Show();
            this.Hide();
        }

        private void sáchBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopBook n = new TopBook();
            n.Show();
            this.Hide();
        }


    }
}
