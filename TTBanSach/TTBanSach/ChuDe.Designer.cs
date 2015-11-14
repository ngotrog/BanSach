namespace TTBanSach
{
    partial class frmChuDe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grChuDe = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaChuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoaCD = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnThemCD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            ((System.ComponentModel.ISupportInitialize)(this.grChuDe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grChuDe);
            this.groupBox3.Location = new System.Drawing.Point(23, 261);
            this.groupBox3.MaximumSize = new System.Drawing.Size(384, 209);
            this.groupBox3.MinimumSize = new System.Drawing.Size(384, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 209);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Chủ đề";
            // 
            // grChuDe
            // 
            this.grChuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grChuDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grChuDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grChuDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuDe,
            this.TenChuDe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grChuDe.DefaultCellStyle = dataGridViewCellStyle2;
            this.grChuDe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grChuDe.Location = new System.Drawing.Point(6, 19);
            this.grChuDe.Name = "grChuDe";
            this.grChuDe.Size = new System.Drawing.Size(372, 159);
            this.grChuDe.TabIndex = 0;
            this.grChuDe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grChuDe_CellMouseClick);
            // 
            // MaChuDe
            // 
            this.MaChuDe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaChuDe.DataPropertyName = "MaChuDe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MaChuDe.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaChuDe.HeaderText = "Mã Chủ Đề";
            this.MaChuDe.Name = "MaChuDe";
            this.MaChuDe.Width = 70;
            // 
            // TenChuDe
            // 
            this.TenChuDe.DataPropertyName = "TenChuDe";
            this.TenChuDe.HeaderText = "Tên Chủ Đề";
            this.TenChuDe.Name = "TenChuDe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnXoaCD);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.btnThemCD);
            this.groupBox2.Location = new System.Drawing.Point(230, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 144);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử Lý thông tin Chủ Đề";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Lime;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Location = new System.Drawing.Point(30, 79);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 37);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoaCD
            // 
            this.btnXoaCD.BackgroundImage = global::TTBanSach.Properties.Resources.delete;
            this.btnXoaCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaCD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCD.Location = new System.Drawing.Point(152, 79);
            this.btnXoaCD.Name = "btnXoaCD";
            this.btnXoaCD.Size = new System.Drawing.Size(111, 39);
            this.btnXoaCD.TabIndex = 3;
            this.btnXoaCD.Text = "    Xóa";
            this.btnXoaCD.UseVisualStyleBackColor = true;
            this.btnXoaCD.Click += new System.EventHandler(this.btnXoaCD_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Blue;
            this.btnAddNew.Location = new System.Drawing.Point(30, 27);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 37);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnThemCD
            // 
            this.btnThemCD.BackgroundImage = global::TTBanSach.Properties.Resources.save;
            this.btnThemCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemCD.Enabled = false;
            this.btnThemCD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemCD.Location = new System.Drawing.Point(152, 20);
            this.btnThemCD.Name = "btnThemCD";
            this.btnThemCD.Size = new System.Drawing.Size(111, 41);
            this.btnThemCD.TabIndex = 0;
            this.btnThemCD.Text = "        Lưu";
            this.btnThemCD.UseVisualStyleBackColor = true;
            this.btnThemCD.Click += new System.EventHandler(this.btnThemCD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenCD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaCD);
            this.groupBox1.Location = new System.Drawing.Point(23, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Chủ Đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Chủ Đề";
            // 
            // txtTenCD
            // 
            this.txtTenCD.Enabled = false;
            this.txtTenCD.Location = new System.Drawing.Point(85, 74);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(100, 20);
            this.txtTenCD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Chủ Đề";
            // 
            // txtMaCD
            // 
            this.txtMaCD.Enabled = false;
            this.txtMaCD.Location = new System.Drawing.Point(85, 32);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(100, 20);
            this.txtMaCD.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(101, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 40);
            this.label7.TabIndex = 12;
            this.label7.Text = "QUẢN LÝ CHỦ ĐỀ";
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
            this.menuStrip1.MaximumSize = new System.Drawing.Size(860, 24);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(860, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 13;
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
            this.nhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.nhàXuấtBảnToolStripMenuItem_Click);
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
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // frmChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 544);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChuDe";
            this.Text = "ChuDe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChuDe_FormClosed);
            this.Load += new System.EventHandler(this.frmChuDe_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grChuDe)).EndInit();
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
        private DevComponents.DotNetBar.Controls.DataGridViewX grChuDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaCD;
        private System.Windows.Forms.Button btnThemCD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuDe;
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