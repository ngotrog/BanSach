using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTBanSach.App_Code.DonHang;
using TTBanSach.App_Code.ChiTietDonHang;

namespace TTBanSach
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private int kt;

        #region Endable
        void EndHD(bool e)
        {
            txtmaDH.Enabled = e;
            dtNgayDat.Enabled = e;
            dtNgayGiao.Enabled = e;
            txtTongTien.Enabled = e;
            cBTinhTrang.Enabled = e;
            txtMaKH.Enabled = e;
        }

        void EndCT(bool e)
        {
            txtMaDHC.Enabled = e;
            txtMaSach.Enabled = e;
            txtSoLuong.Enabled = e;

        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #region LoadForm
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 1);
            EndHD(false);
            EndCT(false);
            grThongTin.DataSource = SQLData.DonHang_GetByAll();
            //grChiTiet.DataSource = TTBanSach.App_Code.ChiTietDonHang.SQLDataCT.ListByMaDH(txtMaDHC.Text);
        }
        #endregion
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //grChiTiet.DataSource = TTBanSach.App_Code.ChiTietDonHang.SQLData.ChiTietDonHang_GetByAll();

        }
        #region NutChiTiet
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            grChiTietDH.Enabled = true;
            grChiTiet.DataSource = TTBanSach.App_Code.ChiTietDonHang.SQLDataCT.ListByMaDH(txtMaDHC.Text);
        }
        #endregion
        #region NutThemHD
        private void buttonX3_Click(object sender, EventArgs e)
        {
            EndHD(true);
            //txtTongTien.Enabled = false;
            txtmaDH.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            txtTongTien.Text = "0";
            txtTongTien.Enabled = false;
            btnXoa.Enabled = false;
            kt = 1;

        }
        #endregion
        #region NutLuuHD
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kt == 1)
                {
                    Info sv = new Info();
                    sv.MaKH = int.Parse(txtMaKH.Text);
                    sv.NgayDat = dtNgayDat.Value;
                    sv.NgayGiao = dtNgayGiao.Value;
                    sv.TinhTrangGiaoHang = cBTinhTrang.Text;
                    sv.TongTien = int.Parse(txtTongTien.Text);
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;

                    try
                    {
                        SQLData.DonHang_Insert(sv);
                        MessageBox.Show("Thêm thành công");
                        EndHD(false);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi");
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        btnHuy.Enabled = false;
                    }
                    frmHoaDon_Load(sender, e);
                }
                else
                    if (kt == 0)
                    {
                        Info sv = new Info();
                        sv.MaDonHang = int.Parse(txtmaDH.Text);
                        sv.MaKH = int.Parse(txtMaKH.Text);
                        sv.NgayDat = dtNgayDat.Value;
                        sv.NgayGiao = dtNgayGiao.Value;
                        sv.TinhTrangGiaoHang = cBTinhTrang.Text;
                        sv.TongTien = int.Parse(txtTongTien.Text);
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHuy.Enabled = false;
                        try
                        {
                            SQLData.DonHang_Update(sv);
                            EndHD(false);
                            MessageBox.Show("Sửa Thành Công !");

                            frmHoaDon_Load(sender, e);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Sửa Thất Bại !");
                            EndHD(true);
                        }
                    }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi!");
                EndHD(true);
                txtmaDH.Enabled = false;
            }
        }
        #endregion
        #region NutHuy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtmaDH.Text = "";
            dtNgayDat.Text = "";
            dtNgayGiao.Text = "";
            txtTongTien.Text = "";
            cBTinhTrang.Text = "";
            txtMaKH.Text = "";
            EndHD(false);
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        #endregion
        #region NutSua
        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 0;
            EndHD(true);
            btnLuu.Enabled = true;
            txtmaDH.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        #endregion
        #region CellMouseClick
        private void grThongTin_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                txtmaDH.Text = grThongTin.Rows[rowIndex].Cells[0].Value.ToString();
                txtMaDHC.Text = grThongTin.Rows[rowIndex].Cells[0].Value.ToString();
                dtNgayDat.Text = grThongTin.Rows[rowIndex].Cells[1].Value.ToString();
                dtNgayGiao.Text = grThongTin.Rows[rowIndex].Cells[2].Value.ToString();
                txtTongTien.Text = grThongTin.Rows[rowIndex].Cells[3].Value.ToString();
                cBTinhTrang.Text = grThongTin.Rows[rowIndex].Cells[4].Value.ToString();
                txtMaKH.Text = grThongTin.Rows[rowIndex].Cells[5].Value.ToString();
                grChiTiet.DataSource = TTBanSach.App_Code.ChiTietDonHang.SQLDataCT.ListByMaDH(txtMaDHC.Text);
            }
            catch { }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        #endregion
        #region NutXoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SQLData.DonHang_Delete(txtmaDH.Text);
                frmHoaDon_Load(sender, e);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại!");
            }
        }
        #endregion
        //--------------------------------------------------------//
        private int kt2;
        #region NutThemCT
        private void btnThemC_Click(object sender, EventArgs e)
        {
            EndCT(true);
            //txtTongTien.Enabled = false;
            txtMaDHC.Enabled = false;
            btnThemC.Enabled = false;
            btnLuuC.Enabled = true;
            btnHuyC.Enabled = true;
            btnSuaC.Enabled = false;
            btnXoaC.Enabled = false;
            kt2 = 1;
        }
        #endregion
        #region NutLuuCt
        private void btnLuuC_Click(object sender, EventArgs e)
        {
            try
            {
                if (kt2 == 1)
                {
                    InfoCT sv = new InfoCT();
                    sv.MaDonHang = int.Parse(txtMaDHC.Text);
                    sv.MaSach = int.Parse(txtMaSach.Text);
                    sv.SoLuong = int.Parse(txtSoLuong.Text);
                    btnLuuC.Enabled = false;
                    btnThemC.Enabled = true;
                    btnSuaC.Enabled = true;
                    btnXoaC.Enabled = true;
                    btnHuyC.Enabled = false;

                    try
                    {
                        SQLDataCT.ChiTietDonHang_Insert(sv);
                        MessageBox.Show("Thêm thành công");
                        EndCT(false);

                        grChiTiet.DataSource = TTBanSach.App_Code.ChiTietDonHang.SQLDataCT.ListByMaDH(txtMaDHC.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi");

                    }
                    frmHoaDon_Load(sender, e);
                }
                else
                    if (kt2 == 0)
                    {
                        InfoCT sv = new InfoCT();
                        sv.MaDonHang = int.Parse(txtMaDHC.Text);
                        sv.MaSach = int.Parse(txtMaSach.Text);
                        sv.SoLuong = int.Parse(txtSoLuong.Text);
                        sv.DonGia = int.Parse(txtDonGia.Text);
                        btnLuuC.Enabled = false;
                        btnThemC.Enabled = true;
                        btnSuaC.Enabled = true;
                        btnXoaC.Enabled = true;
                        btnHuyC.Enabled = false;
                        try
                        {
                            SQLDataCT.ChiTietChiTietDonHang_Update(sv);
                            EndCT(false);
                            MessageBox.Show("Sửa Thành Công !");

                            frmHoaDon_Load(sender, e);
                            grChiTiet.DataSource = TTBanSach.App_Code.ChiTietDonHang.SQLDataCT.ListByMaDH(txtMaDHC.Text);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Sửa Thất Bại !");
                            EndCT(true);
                        }
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
                EndCT(true);
                txtMaDHC.Enabled = false;
            }
        }
        #endregion
        #region NutHuyCT
        private void btnHuyC_Click(object sender, EventArgs e)
        {
            txtMaDHC.Text = "";
            txtMaSach.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            EndCT(false);
            btnHuyC.Enabled = false;
            btnLuuC.Enabled = false;
            btnThemC.Enabled = true;
            btnSuaC.Enabled = true;
            btnXoaC.Enabled = true;
        }
        #endregion
        #region NutSuaCT
        private void btnSuaC_Click(object sender, EventArgs e)
        {
            kt2 = 0;
            EndCT(true);
            btnLuuC.Enabled = true;
            txtMaDHC.Enabled = false;
            btnXoaC.Enabled = false;
            btnThemC.Enabled = false;
            btnHuyC.Enabled = false;
        }
        #endregion
        #region NutXoaCt
        private void btnXoaC_Click(object sender, EventArgs e)
        {
            try
            {
                SQLDataCT.ChiTietDonHang_Delete(txtMaDHC.Text, txtMaSach.Text);
                frmHoaDon_Load(sender, e);
                MessageBox.Show("Xóa thành công!");
                grChiTiet.DataSource = TTBanSach.App_Code.ChiTietDonHang.SQLDataCT.ListByMaDH(txtMaDHC.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại!");
            }
        }
        #endregion
        #region CellMouseClickChiTiet
        private void grChiTiet_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                txtMaDHC.Text = grChiTiet.Rows[rowIndex].Cells[0].Value.ToString();
                txtMaSach.Text = grChiTiet.Rows[rowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = grChiTiet.Rows[rowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = grChiTiet.Rows[rowIndex].Cells[3].Value.ToString();

            }
            catch { }
            btnSuaC.Enabled = true;
            btnXoaC.Enabled = true;
        }
        #endregion

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach newform = new frmSach();
            newform.Show();
            this.Hide();
        }

        private void frmHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Info sv = new Info();
            sv.MaDonHang = int.Parse(txtmaDH.Text);
            sv.MaKH = int.Parse(txtMaKH.Text);
            sv.NgayDat = dtNgayDat.Value;
            sv.NgayGiao = dtNgayGiao.Value;
            sv.TinhTrangGiaoHang = "Đã Thanh Toán";
            sv.TongTien = int.Parse(txtTongTien.Text);
            SQLData.DonHang_Update(sv);
            frmHoaDon_Load(sender, e);
            MessageBox.Show("Thanh Toán Thành Công \nCảm ơn ", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sáchMớiNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBook n = new NewBook();
            n.Show();
            this.Hide();
        }

        private void sáchBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopBook t = new TopBook();
            t.Show();
            this.Hide();
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
