namespace EnglishLearningApp
{
    partial class frmDienTu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnShowAnswers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;

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
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnShowAnswers = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.richTextBoxContent.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(600, 200);

            this.btnOK.Location = new System.Drawing.Point(50, 300);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            this.btnShowAnswers.Location = new System.Drawing.Point(150, 300);
            this.btnShowAnswers.Name = "btnShowAnswers";
            this.btnShowAnswers.Size = new System.Drawing.Size(75, 23);
            this.btnShowAnswers.Text = "Đáp án";
            this.btnShowAnswers.Click += new System.EventHandler(this.btnShowAnswers_Click);

            this.btnReset.Location = new System.Drawing.Point(250, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Text = "Làm lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.btnExit.Location = new System.Drawing.Point(350, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.ClientSize = new System.Drawing.Size(640, 350);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnShowAnswers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Text = "Bài tập điền từ";
        }
    }
}
