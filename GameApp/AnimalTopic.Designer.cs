namespace GameApp
{
    partial class AnimalTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalTopic));
            button4 = new Button();
            label3 = new Label();
            button2 = new Button();
            lbScore = new Label();
            tbAnswer = new TextBox();
            button1 = new Button();
            questionPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)questionPic).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(13, 13);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(72, 74);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(202, 617);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 45);
            label3.TabIndex = 20;
            label3.Text = "Your answer";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(887, 28);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(54, 48);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = true;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbScore.Location = new Point(868, 416);
            lbScore.Margin = new Padding(4, 0, 4, 0);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(115, 45);
            lbScore.TabIndex = 18;
            lbScore.Text = "Score:";
            // 
            // tbAnswer
            // 
            tbAnswer.Location = new Point(436, 617);
            tbAnswer.Margin = new Padding(4);
            tbAnswer.Multiline = true;
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Size = new Size(379, 44);
            tbAnswer.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(436, 687);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(255, 70);
            button1.TabIndex = 16;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // questionPic
            // 
            questionPic.BackColor = SystemColors.Window;
            questionPic.BorderStyle = BorderStyle.FixedSingle;
            questionPic.Image = (Image)resources.GetObject("questionPic.Image");
            questionPic.Location = new Point(202, 156);
            questionPic.Margin = new Padding(4);
            questionPic.Name = "questionPic";
            questionPic.Size = new Size(614, 420);
            questionPic.SizeMode = PictureBoxSizeMode.Zoom;
            questionPic.TabIndex = 15;
            questionPic.TabStop = false;
            // 
            // AnimalTopic
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5;
            ClientSize = new Size(1001, 801);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(lbScore);
            Controls.Add(tbAnswer);
            Controls.Add(button1);
            Controls.Add(questionPic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnimalTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnimalTopic";
            ((System.ComponentModel.ISupportInitialize)questionPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label3;
        private Button button2;
        private Label lbScore;
        private TextBox tbAnswer;
        private Button button1;
        private PictureBox questionPic;
    }
}