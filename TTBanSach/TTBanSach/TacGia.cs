using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTBanSach.App_Code.TacGia;
namespace TTBanSach
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        public void Enable(bool e)
        {
            txtDiaChiTG.Enabled = e;
            txtDienthoaiTG.Enabled = e;
            txtMaTG.Enabled = e;
            txtTenTG.Enabled = e;
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            grTacGia.DataSource=SQLData.TacGia_GetByAll();
            this.Location = new Point(250, 1);
        }
        private void grTacGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                txtMaTG.Text = grTacGia.Rows[rowIndex].Cells[0].Value.ToString();
                txtTenTG.Text = grTacGia.Rows[rowIndex].Cells[1].Value.ToString();
                txtDiaChiTG.Text = grTacGia.Rows[rowIndex].Cells[2].Value.ToString();
                txtDienthoaiTG.Text = grTacGia.Rows[rowIndex].Cells[3].Value.ToString();
            }
            catch { }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnThemTG.Enabled = true;
            txtMaTG.Enabled = false;
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtDienthoaiTG.Text = "";
            txtDiaChiTG.Text = "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtDienthoaiTG.Text = "";
            txtDiaChiTG.Text = "";
            Enable(false);
            btnThemTG.Enabled = false;
        }
        private void btnThemTG_Click(object sender, EventArgs e)
        {
            Info sv = new Info();
            sv.TenTacGia = txtTenTG.Text;
            sv.DiaChi = txtDiaChiTG.Text;
            sv.DienThoai = txtDienthoaiTG.Text;
            try
            {
                SQLData.TacGia_Insert(sv);
                MessageBox.Show("Thêm thành công");
                Enable(false);
                btnThemTG.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            frmTacGia_Load(sender, e);
        }
        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            try
            {
                SQLData.TacGia_Delete(txtMaTG.Text);
                frmTacGia_Load(sender, e);
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
            frmTacGia n = new frmTacGia();
            n.Show();
            this.Hide();
        }
        private void quảnLýNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan newForm = new frmNhaXuatBan();
            newForm.Show();
            this.Hide();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon n = new frmHoaDon();
            n.Show();
            this.Hide();
        }

        private void frmTacGia_FormClosed(object sender, FormClosedEventArgs e)
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
