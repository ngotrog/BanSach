using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTBanSach.App_Code.NhaXuatBan;
namespace TTBanSach
{
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }
        #region Enable
        public void Enable(bool e)
        {
            txtDiaChiNXB.Enabled = e;
            txtDienthoaiNXB.Enabled = e;
            txtMaNXB.Enabled = e;
            txtTenNXB.Enabled = e;

        }
        #endregion
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            grNXB.DataSource=SQLData.NhaXuatBan_GetByAll();
            this.Location = new Point(250, 1);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnThemNXB.Enabled = true;
            txtMaNXB.Enabled = false;
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDienthoaiNXB.Text = "";
            txtDiaChiNXB.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDienthoaiNXB.Text = "";
            txtDiaChiNXB.Text = "";

            Enable(false);
            btnThemNXB.Enabled = false;
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            Info sv = new Info();

            sv.TenNXB = txtTenNXB.Text;
            sv.DiaChi = txtDiaChiNXB.Text;
            sv.DienThoai = txtDienthoaiNXB.Text;

            try
            {
                SQLData.NhaXuatBan_Insert(sv);
                MessageBox.Show("Thêm thành công");
                Enable(false);
                btnThemNXB.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            frmNhaXuatBan_Load(sender, e);
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            try
            {
                SQLData.NhaXuatBan_Delete(txtMaNXB.Text);
                frmNhaXuatBan_Load(sender, e);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void grNXB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                txtMaNXB.Text = grNXB.Rows[rowIndex].Cells[0].Value.ToString();
                txtTenNXB.Text = grNXB.Rows[rowIndex].Cells[1].Value.ToString();
                txtDiaChiNXB.Text = grNXB.Rows[rowIndex].Cells[2].Value.ToString();
                txtDienthoaiNXB.Text = grNXB.Rows[rowIndex].Cells[3].Value.ToString();
            }
            catch { }
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

        private void quảnLýNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan newForm = new frmNhaXuatBan();
            newForm.Show();
            this.Hide();
        }

        private void quảnLýTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia newForm = new frmTacGia();
            newForm.Show();
            this.Hide();
        }

        private void frmNhaXuatBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon n = new frmHoaDon();
            n.Show();
            this.Hide();
        }

        private void frmNhaXuatBan_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
