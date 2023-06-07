using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace GameApp
{
    public partial class AnimalTopic : Form
    {
        private string[] arrFruit = {
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\bird.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\cat.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\chicken.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\dog.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\duck.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\elephant.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\frog.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\lion.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\monkey.jpg",
            "C:\\GameApp\\GameApp\\bin\\Debug\\Images\\animal\\tiger.jpg"
        };
        int questNo = 0;
        int score = 0;

        public AnimalTopic()
        {
            InitializeComponent();
            questionPic.ImageLocation = string.Format(arrFruit[0]);
            lbScore.Text = "Score: " + questNo.ToString();
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
