using System;
using System.Windows.Forms;

namespace EnglishLearningApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Event handler for "Bài điền từ 1"
        private void baiDienTu1_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu
            {
                Debai = "My grandfather was born in China. He came from a very poor family and was (1) _____ of seven children. His parents lived " +
                       "(2)_____ a small farm. He didn't have a very good education. At the age of 17 he (3)_____ home. First he went to Shanghai and " +
                       "(4)_____ he went to Hong Kong. He worked (5)_____ as a waiter and then as a cook. When he was 21, he (6)_____ my grandmother and " +
                       "had four children.\n" +
                       "My mother was (7)_____ oldest. My grandmother died recently, and my grandfather lives alone now. He is almost 80, (8)_____ he " +
                       "is still very active and interested in everything (9)_____ is going on.\n" +
                       "He reads the papers and (10)_____ television even though his eyesight is fairly poor.",
                Dapan = "My grandfather was born in China. He came from a very poor family and was (1) one of seven children. His parents lived " +
                       "(2) on a small farm. He didn't have a very good education. At the age of 17 he (3) left home. First he went to Shanghai and " +
                       "(4) then he went to Hong Kong. He worked (5) as a waiter and then as a cook. When he was 21, he (6) married my grandmother and " +
                       "had four children.\n" +
                       "My mother was (7) the oldest. My grandmother died recently, and my grandfather lives alone now. He is almost 80, (8) but he " +
                       "is still very active and interested in everything (9) that is going on.\n" +
                       "He reads the papers and (10) watches television even though his eyesight is fairly poor.",
                Dapantungcau = new System.Collections.Generic.List<string> { "one", "on", "left", "then", "as", "married", "the", "but", "that", "watches" }
            };

            frmDienTu frm = new frmDienTu(bt);
            frm.ShowDialog(); // Open as a modal dialog
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
