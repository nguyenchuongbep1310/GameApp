using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApp
{
    public partial class FruitTopic : Form
    {
        private string[] arrFruit = {
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\apple.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\strawberry.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\walnut.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\banana.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\guava.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\durian.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\grapes.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\orange.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\pear.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\watermelon.jpg"
        };
        int questNo = 0;
        int score = 0;
        public FruitTopic()
        {
            InitializeComponent();
            questionPic.ImageLocation = string.Format(arrFruit[0]);
            lbScore.Text = "Score: " + questNo.ToString();
        }

        private void LoadNextQuestion()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (questNo == 0 && (tbAnswer.Text.Equals(Path.GetFileNameWithoutExtension(arrFruit[questNo]).ToLower())))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text += score;
            }
            else if (questNo == 1 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 2 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 3 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 4 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 5 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 6 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 7 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 8 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(arrFruit[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 9 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(arrFruit[questNo])))
            {
                questNo++;
                score += 2;
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else
            {
                if (questNo == 9)
                {
                    MessageBox.Show("You tried so hard and your score: " + score);
                }
                else
                {
                    MessageBox.Show("Wrong answer!!! But you tried so hard and your score: " + score);
                }
                Home form = new Home();
                form.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Hide();
        }
    }
}
