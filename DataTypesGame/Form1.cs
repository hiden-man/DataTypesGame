using System;
using System.Windows.Forms;

namespace DataTypesGame
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        byte r;
        byte type1 = 200;
        short type2 = 19439;
        int type3 = 293494220, numberRightAnswer = 0;
        long type4 = 6060633343533333333;
        double type5 = 3443000533.54344304050545;
        float type6 = 6.2f;
        string type7 = "I`m Superman";
        char type8 = 'S';
        public MainForm()
        {
            InitializeComponent();
        }
        private void RandomQuestion()
        {
            r = Convert.ToByte(random.Next(1, 9));
            if (r == 1)
                textBox1.Text = type1.ToString();
            if (r == 2)
                textBox1.Text = type2.ToString();
            if (r == 3)
                textBox1.Text = type3.ToString();
            if (r == 4)
                textBox1.Text = type4.ToString();
            if (r == 5)
                textBox1.Text = type5.ToString();
            if (r == 6)
                textBox1.Text = type6.ToString();
            if (r == 7)
                textBox1.Text = type7.ToString();
            if (r == 8)
                textBox1.Text = type8.ToString();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RandomQuestion();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && r == 1)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            if (radioButton2.Checked && r == 2)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            if (radioButton3.Checked && r == 3)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            if (radioButton4.Checked && r == 4)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            if (radioButton5.Checked && r == 5)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            if (radioButton6.Checked && r == 6)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            if (radioButton7.Checked && r == 7)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            if (radioButton8.Checked && r == 8)
            {
                numberRightAnswer += 1;
                numberRightAnswerLabel.Text = $"Right answer\n{numberRightAnswer}";
            }
            RandomQuestion();
        }
    }
}
