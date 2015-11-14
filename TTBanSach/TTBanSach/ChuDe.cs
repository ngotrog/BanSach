using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTBanSach.App_Code.ChuDe;
namespace TTBanSach
{
    public partial class frmChuDe : Form
    {
        public frmChuDe()
        {
            InitializeComponent();
        }
        public frmChuDe(string s)
        {
             txtMaCD.Text=s;
            InitializeComponent();
        }
        #region Grid
        private void grChuDe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                txtMaCD.Text = grChuDe.Rows[rowIndex].Cells[0].Value.ToString();
                txtTenCD.Text = grChuDe.Rows[rowIndex].Cells[1].Value.ToString();
            }
            catch { }


        }
        #endregion
        private void frmChuDe_Load(object sender, EventArgs e)
        {
            grChuDe.DataSource = SQLData.ChuDe_GetByAll();
            this.Location = new Point(250, 50);
        }
        #region Enable
        public void Enable(bool e)
        {
            txtMaCD.Enabled = e;
            txtTenCD.Enabled = e;

        }
        #endregion
        private void btnThemCD_Click(object sender, EventArgs e)
        {
            Info sv = new Info();
            sv.TenChuDe = txtTenCD.Text;
            try
            {
                SQLData.ChuDe_Insert(sv);
                MessageBox.Show("Thêm thành công");
                Enable(false);
                btnThemCD.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            frmChuDe_Load(sender, e);
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnThemCD.Enabled = true;
            txtMaCD.Enabled = false;
            txtMaCD.Text = "";
            txtTenCD.Text = "";
        }
        private void btnXoaCD_Click(object sender, EventArgs e)
        {
            try
            {
                SQLData.ChuDe_Delete(txtMaCD.Text);
                frmChuDe_Load(sender, e);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại!");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCD.Text = "";
            txtTenCD.Text = "";
            Enable(false);
            btnThemCD.Enabled = false;
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon n = new frmHoaDon();
            n.Show();
            this.Hide();
        }

        private void frmChuDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.Show();
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

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan n = new frmNhaXuatBan();
            n.Show();
            this.Hide();
        }

        private void quảnLýTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia n = new frmTacGia();
            n.Show();
            this.Hide();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang n = new frmKhachHang();
            n.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome n = new frmHome();
            n.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
