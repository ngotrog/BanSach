namespace TTBanSach
{
    partial class frmTacGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grTacGia = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnXoaTG = new System.Windows.Forms.Button();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienthoaiTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChiTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNXBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchMớiNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchBánChạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chủĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTacGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grTacGia);
            this.groupBox3.Location = new System.Drawing.Point(93, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 334);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Tác Giả";
            // 
            // grTacGia
            // 
            this.grTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTG,
            this.TenTG,
            this.DiaChi,
            this.DienThoai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grTacGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.grTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTacGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grTacGia.Location = new System.Drawing.Point(3, 16);
            this.grTacGia.Name = "grTacGia";
            this.grTacGia.Size = new System.Drawing.Size(727, 315);
            this.grTacGia.TabIndex = 0;
            this.grTacGia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grTacGia_CellMouseClick);
            // 
            // MaTG
            // 
            this.MaTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaTG.DataPropertyName = "MaTacGia";
            this.MaTG.HeaderText = "Mã tác giả";
            this.MaTG.Name = "MaTG";
            // 
            // TenTG
            // 
            this.TenTG.DataPropertyName = "TenTacGia";
            this.TenTG.HeaderText = "Tên tác giả";
            this.TenTG.Name = "TenTG";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.btnXoaTG);
            this.groupBox2.Controls.Add(this.btnThemTG);
            this.groupBox2.Location = new System.Drawing.Point(530, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử Lý thông tin TG";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Lime;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Location = new System.Drawing.Point(37, 78);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 37);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Blue;
            this.btnAddNew.Location = new System.Drawing.Point(37, 26);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 37);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnXoaTG
            // 
            this.btnXoaTG.BackgroundImage = global::TTBanSach.Properties.Resources.delete;
            this.btnXoaTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaTG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTG.Location = new System.Drawing.Point(143, 81);
            this.btnXoaTG.Name = "btnXoaTG";
            this.btnXoaTG.Size = new System.Drawing.Size(111, 38);
            this.btnXoaTG.TabIndex = 3;
            this.btnXoaTG.Text = "    Xóa";
            this.btnXoaTG.UseVisualStyleBackColor = true;
            this.btnXoaTG.Click += new System.EventHandler(this.btnXoaTG_Click);
            // 
            // btnThemTG
            // 
            this.btnThemTG.BackgroundImage = global::TTBanSach.Properties.Resources.save;
            this.btnThemTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemTG.Enabled = false;
            this.btnThemTG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTG.Location = new System.Drawing.Point(143, 24);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(111, 41);
            this.btnThemTG.TabIndex = 0;
            this.btnThemTG.Text = "        Lưu";
            this.btnThemTG.UseVisualStyleBackColor = true;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDienthoaiTG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiaChiTG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaTG);
            this.groupBox1.Location = new System.Drawing.Point(93, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tác Giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Điện thoại";
            // 
            // txtDienthoaiTG
            // 
            this.txtDienthoaiTG.Enabled = false;
            this.txtDienthoaiTG.Location = new System.Drawing.Point(300, 77);
            this.txtDienthoaiTG.Name = "txtDienthoaiTG";
            this.txtDienthoaiTG.Size = new System.Drawing.Size(100, 20);
            this.txtDienthoaiTG.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtDiaChiTG
            // 
            this.txtDiaChiTG.Enabled = false;
            this.txtDiaChiTG.Location = new System.Drawing.Point(302, 35);
            this.txtDiaChiTG.Name = "txtDiaChiTG";
            this.txtDiaChiTG.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChiTG.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên TG";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Enabled = false;
            this.txtTenTG.Location = new System.Drawing.Point(77, 74);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(100, 20);
            this.txtTenTG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã TG";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Enabled = false;
            this.txtMaTG.Location = new System.Drawing.Point(77, 32);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(100, 20);
            this.txtMaTG.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(266, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.tácGiảToolStripMenuItem,
            this.nhàXuấtBảnToolStripMenuItem,
            this.tiềmKiếmToolStripMenuItem,
            this.chủĐềToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKháchHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTGToolStripMenuItem});
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            // 
            // quảnLýTGToolStripMenuItem
            // 
            this.quảnLýTGToolStripMenuItem.Name = "quảnLýTGToolStripMenuItem";
            this.quảnLýTGToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.quảnLýTGToolStripMenuItem.Text = "Quản lý TG";
            this.quảnLýTGToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTGToolStripMenuItem_Click);
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            this.nhàXuấtBảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNXBToolStripMenuItem});
            this.nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            this.nhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.nhàXuấtBảnToolStripMenuItem.Text = "Nhà Xuất Bản";
            // 
            // quảnLýNXBToolStripMenuItem
            // 
            this.quảnLýNXBToolStripMenuItem.Name = "quảnLýNXBToolStripMenuItem";
            this.quảnLýNXBToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.quảnLýNXBToolStripMenuItem.Text = "Quản Lý NXB";
            this.quảnLýNXBToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNXBToolStripMenuItem_Click);
            // 
            // tiềmKiếmToolStripMenuItem
            // 
            this.tiềmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.sáchMớiNhậpToolStripMenuItem,
            this.sáchBánChạyToolStripMenuItem});
            this.tiềmKiếmToolStripMenuItem.Name = "tiềmKiếmToolStripMenuItem";
            this.tiềmKiếmToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.tiềmKiếmToolStripMenuItem.Text = "Sách";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // sáchMớiNhậpToolStripMenuItem
            // 
            this.sáchMớiNhậpToolStripMenuItem.Name = "sáchMớiNhậpToolStripMenuItem";
            this.sáchMớiNhậpToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sáchMớiNhậpToolStripMenuItem.Text = "Sách mới nhập";
            this.sáchMớiNhậpToolStripMenuItem.Click += new System.EventHandler(this.sáchMớiNhậpToolStripMenuItem_Click);
            // 
            // sáchBánChạyToolStripMenuItem
            // 
            this.sáchBánChạyToolStripMenuItem.Name = "sáchBánChạyToolStripMenuItem";
            this.sáchBánChạyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sáchBánChạyToolStripMenuItem.Text = "Sách bán chạy";
            this.sáchBánChạyToolStripMenuItem.Click += new System.EventHandler(this.sáchBánChạyToolStripMenuItem_Click);
            // 
            // chủĐềToolStripMenuItem
            // 
            this.chủĐềToolStripMenuItem.Name = "chủĐềToolStripMenuItem";
            this.chủĐềToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.chủĐềToolStripMenuItem.Text = "Chủ Đề";
            this.chủĐềToolStripMenuItem.Click += new System.EventHandler(this.chủĐềToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 668);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTacGia";
            this.Text = "TacGia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTacGia_FormClosed);
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grTacGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.DataGridViewX grTacGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaTG;
        private System.Windows.Forms.Button btnThemTG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienthoaiTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChiTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNXBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchMớiNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchBánChạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chủĐềToolStripMenuItem;
    }
}