namespace GameApp
{
    partial class FruitTopic
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitTopic));
            questionPic = new PictureBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            tbAnswer = new TextBox();
            lbScore = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)questionPic).BeginInit();
            SuspendLayout();
            // 
            // questionPic
            // 
            questionPic.BackColor = SystemColors.Window;
            questionPic.BorderStyle = BorderStyle.FixedSingle;
            questionPic.Image = (Image)resources.GetObject("questionPic.Image");
            questionPic.Location = new Point(118, 129);
            questionPic.Margin = new Padding(4);
            questionPic.Name = "questionPic";
            questionPic.Size = new Size(614, 420);
            questionPic.SizeMode = PictureBoxSizeMode.Zoom;
            questionPic.TabIndex = 0;
            questionPic.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(352, 660);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(255, 70);
            button1.TabIndex = 1;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // tbAnswer
            // 
            tbAnswer.Location = new Point(352, 590);
            tbAnswer.Margin = new Padding(4);
            tbAnswer.Multiline = true;
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Size = new Size(379, 44);
            tbAnswer.TabIndex = 2;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbScore.Location = new Point(109, 44);
            lbScore.Margin = new Padding(4, 0, 4, 0);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(115, 45);
            lbScore.TabIndex = 3;
            lbScore.Text = "Score:";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(870, 44);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(54, 48);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(302, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 45);
            label2.TabIndex = 5;
            label2.Text = "Level: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(118, 590);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 45);
            label3.TabIndex = 6;
            label3.Text = "Your answer";
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(-6, 3);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(72, 74);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FruitTopic
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(936, 776);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(lbScore);
            Controls.Add(tbAnswer);
            Controls.Add(button1);
            Controls.Add(questionPic);
            Margin = new Padding(4);
            Name = "FruitTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)questionPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox questionPic;
        private Button button1;
        private ImageList imageList1;
        private TextBox tbAnswer;
        private Label lbScore;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button button4;
    }
}