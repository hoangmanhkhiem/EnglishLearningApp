namespace EnglishLearningApp
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDienTu;
        private System.Windows.Forms.ToolStripMenuItem baiDienTu1;
        private System.Windows.Forms.ToolStripMenuItem thoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuDienTu = new ToolStripMenuItem();
            baiDienTu1 = new ToolStripMenuItem();
            thoat = new ToolStripMenuItem();
            biendoicauToolStripMenuItem = new ToolStripMenuItem();
            tracNghiemNoiTuToolStripMenuItem = new ToolStripMenuItem();
            datCauToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDienTu, biendoicauToolStripMenuItem, tracNghiemNoiTuToolStripMenuItem, datCauToolStripMenuItem, thoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            // 
            // menuDienTu
            // 
            menuDienTu.DropDownItems.AddRange(new ToolStripItem[] { baiDienTu1 });
            menuDienTu.Name = "menuDienTu";
            menuDienTu.Size = new Size(57, 20);
            menuDienTu.Text = "Điền từ";
            // 
            // baiDienTu1
            // 
            baiDienTu1.Name = "baiDienTu1";
            baiDienTu1.Size = new Size(180, 22);
            baiDienTu1.Text = "Bài điền từ 1";
            baiDienTu1.Click += baiDienTu1_Click;
            // 
            // thoat
            // 
            thoat.Name = "thoat";
            thoat.Size = new Size(49, 20);
            thoat.Text = "Thoát";
            thoat.Click += thoat_Click;
            // 
            // biendoicauToolStripMenuItem
            // 
            biendoicauToolStripMenuItem.Name = "biendoicauToolStripMenuItem";
            biendoicauToolStripMenuItem.Size = new Size(78, 20);
            biendoicauToolStripMenuItem.Text = "Biendoicau";
            // 
            // tracNghiemNoiTuToolStripMenuItem
            // 
            tracNghiemNoiTuToolStripMenuItem.Name = "tracNghiemNoiTuToolStripMenuItem";
            tracNghiemNoiTuToolStripMenuItem.Size = new Size(118, 20);
            tracNghiemNoiTuToolStripMenuItem.Text = "Trac nghiem noi tu";
            // 
            // datCauToolStripMenuItem
            // 
            datCauToolStripMenuItem.Name = "datCauToolStripMenuItem";
            datCauToolStripMenuItem.Size = new Size(59, 20);
            datCauToolStripMenuItem.Text = "Dat cau";
            // 
            // frmMain
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Bài Tập Tiếng Anh";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolStripMenuItem biendoicauToolStripMenuItem;
        private ToolStripMenuItem tracNghiemNoiTuToolStripMenuItem;
        private ToolStripMenuItem datCauToolStripMenuItem;
    }
}
