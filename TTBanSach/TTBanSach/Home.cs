using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTBanSach
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        #region Menu
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
        #endregion

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 1);
        }

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

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon n = new frmHoaDon();
            n.Show();
            this.Hide();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chủĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuDe n = new frmChuDe();
            n.Show();
            this.Hide();
        }
    }
}
