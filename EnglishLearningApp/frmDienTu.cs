using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishLearningApp
{
    public partial class frmDienTu : Form
    {
        private BaiTapDienTu _exercise;
        private TextBox[] answerBoxes;

        public frmDienTu(BaiTapDienTu exercise)
        {
            InitializeComponent();
            _exercise = exercise;
            InitializeAnswerBoxes();
            LoadExerciseContent();
        }

        private void InitializeAnswerBoxes()
        {
            answerBoxes = new TextBox[10];
            for (int i = 0; i < 10; i++)
            {
                TextBox txtBox = new TextBox
                {
                    Location = new Point(50 + (i % 5) * 100, 220 + (i / 5) * 30),
                    Size = new Size(90, 20),
                    Name = $"textBox{i + 1}"
                };
                answerBoxes[i] = txtBox;
                this.Controls.Add(txtBox);
            }
        }

        private void LoadExerciseContent()
        {
            richTextBoxContent.Text = _exercise.Debai;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int score = 0;
            for (int i = 0; i < answerBoxes.Length; i++)
            {
                if (answerBoxes[i].Text.Trim().Equals(_exercise.Dapantungcau[i], StringComparison.OrdinalIgnoreCase))
                {
                    answerBoxes[i].BackColor = Color.LightGreen;
                    score++;
                }
                else
                {
                    answerBoxes[i].BackColor = Color.LightPink;
                }
            }

            MessageBox.Show($"Bạn đã đạt được {score} điểm trong số 10!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowAnswers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < answerBoxes.Length; i++)
            {
                answerBoxes[i].Text = _exercise.Dapantungcau[i];
                answerBoxes[i].BackColor = Color.White;
                richTextBoxContent.Text = _exercise.Dapan;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var txtBox in answerBoxes)
            {
                txtBox.Clear();
                txtBox.BackColor = Color.White;
                richTextBoxContent.Text = _exercise.Debai;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
