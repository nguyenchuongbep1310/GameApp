using System.Media;

namespace GameApp
{
    public partial class Home : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\GameApp\GameApp\bin\Debug\Images\sound\nhacgame02.wav");
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode mode = new Mode();
            mode.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}