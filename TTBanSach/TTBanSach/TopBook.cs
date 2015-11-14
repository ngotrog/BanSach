using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTBanSach.App_Code.Sach;
namespace TTBanSach
{
    public partial class TopBook : Form
    {
        public TopBook()
        {
            InitializeComponent();
        }

        private void TopBook_Load(object sender, EventArgs e)
        {
            grSach.DataSource=SQLData.TopSach();
            this.Location = new Point(250, 1);
        }

        private void TopBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
