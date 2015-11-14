using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTBanSach.App_Code.KhachHang;
namespace TTBanSach
{
    public partial class frmKhachHang : Form
    {
        private int kt;
        public string ma { get; set; }
        private frmSach s;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            grKhachHang.DataSource = SQLData.KhachHang_GetByAll();
            this.Location = new Point(250, 1);
        }
        #region Them

        #endregion
        #region Enable
        public void Enable(bool e)
        {
            txtDiaChiKH.Enabled = e;
            txtDienthoaiKH.Enabled = e;
            txtEmailKH.Enabled = e;
            txtHoTenKH.Enabled = e;
            txtMaKH.Enabled = e;
            cmbGioiTinh.Enabled = e;
            dtNgaySinh.Enabled = e;
        }
        #endregion
        #region AddNew
        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Gridview
        private void grKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                txtMaKH.Text = grKhachHang.Rows[rowIndex].Cells[0].Value.ToString();
                txtHoTenKH.Text = grKhachHang.Rows[rowIndex].Cells[1].Value.ToString();
                dtNgaySinh.Text = grKhachHang.Rows[rowIndex].Cells[2].Value.ToString();
                cmbGioiTinh.Text = grKhachHang.Rows[rowIndex].Cells[3].Value.ToString();
                txtDiaChiKH.Text = grKhachHang.Rows[rowIndex].Cells[4].Value.ToString();
                txtEmailKH.Text = grKhachHang.Rows[rowIndex].Cells[5].Value.ToString();
                txtDienthoaiKH.Text = grKhachHang.Rows[rowIndex].Cells[6].Value.ToString();
            }
            catch { }
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }
        #endregion
        #region  Menu
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }
        #endregion
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach newForm = new frmSach();
            newForm.Show();
            this.Hide();
        }
        #region  Tiem Kiem
        private void buttonX1_Click(object sender, EventArgs e)
        {
            grKhachHang.DataSource = SQLData.KhachHang_Search(txtTimKiem.Text);
        }
        #endregion
        #region THEM
        private void btn_Them_Click(object sender, EventArgs e)
        {
            kt = 1;
            Enable(true);
            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            txtMaKH.Enabled = false;
            txtDiaChiKH.Text = "";
            txtDienthoaiKH.Text = "";
            txtEmailKH.Text = "";
            txtHoTenKH.Text = "";
            txtMaKH.Text = "";
            cmbGioiTinh.Text = "";
            dtNgaySinh.Text = "";
            btn_Huy.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }
        #endregion
        #region HUY
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txtDiaChiKH.Text = "";
            txtDienthoaiKH.Text = "";
            txtEmailKH.Text = "";
            txtHoTenKH.Text = "";
            txtMaKH.Text = "";
            cmbGioiTinh.Text = "";
            dtNgaySinh.Text = "";
            Enable(false);
            btn_Them.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true; ;

        }
        #endregion
        #region LUU
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kt == 1)
                {
                    Info sv = new Info();
                    sv.HoTen = txtHoTenKH.Text;
                    sv.GioiTinh = cmbGioiTinh.Text;
                    sv.NgaySinh = dtNgaySinh.Value;
                    sv.DienThoai = txtDienthoaiKH.Text;
                    sv.Email = txtEmailKH.Text;
                    sv.DiaChi = txtDiaChiKH.Text;
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Huy.Enabled = false;
                    btn_Luu.Enabled = false;
                    btn_Them.Enabled = true;
                    try
                    {
                        SQLData.KhachHang_Insert(sv);
                        MessageBox.Show("Thêm thành công");
                        Enable(false);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi");
                        btn_Luu.Enabled = false;
                        btn_Them.Enabled = true;
                        btn_Huy.Enabled = false;
                        Enable(false);
                    }
                    frmKhachHang_Load(sender, e);
                }
                else
                    if (kt == 0)
                    {
                        Info sv = new Info();
                        sv.MaKH = int.Parse(txtMaKH.Text);
                        sv.HoTen = txtHoTenKH.Text.Trim();
                        sv.GioiTinh = cmbGioiTinh.Text;
                        sv.NgaySinh = dtNgaySinh.Value;
                        sv.DienThoai = txtDienthoaiKH.Text;
                        sv.Email = txtEmailKH.Text;
                        sv.DiaChi = txtDiaChiKH.Text;
                        btn_Them.Enabled = true;
                        btn_Xoa.Enabled = true;
                        btn_Huy.Enabled = false;
                        btn_Luu.Enabled = false;
                        btn_Sua.Enabled = true;
                        try
                        {
                            SQLData.KhachHang_Update(sv);
                            Enable(false);
                            MessageBox.Show("Sửa Thành Công !");

                            frmKhachHang_Load(sender, e);
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
        #endregion
        #region SUA
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            kt = 0;
            Enable(true);
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            txtMaKH.Enabled = false;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }
        #endregion
        #region XOA
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SQLData.KhachHang_Delete(txtMaKH.Text);
                frmKhachHang_Load(sender, e);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại!");
            }
        }
        #endregion
        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            s = new frmSach();
            txtMaKH.Text = s.txtMaSach.Text;
        }
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

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
    }
}
