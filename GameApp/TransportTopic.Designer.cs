﻿namespace GameApp
{
    partial class TransportTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportTopic));
            label3 = new Label();
            button2 = new Button();
            lbScore = new Label();
            tbAnswer = new TextBox();
            button1 = new Button();
            questionPic = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)questionPic).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(282, 668);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 45);
            label3.TabIndex = 13;
            label3.Text = "Your answer";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(967, 79);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(54, 48);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbScore.Location = new Point(948, 467);
            lbScore.Margin = new Padding(4, 0, 4, 0);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(115, 45);
            lbScore.TabIndex = 10;
            lbScore.Text = "Score:";
            // 
            // tbAnswer
            // 
            tbAnswer.Location = new Point(516, 668);
            tbAnswer.Margin = new Padding(4);
            tbAnswer.Multiline = true;
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Size = new Size(379, 44);
            tbAnswer.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(516, 738);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(255, 70);
            button1.TabIndex = 8;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // questionPic
            // 
            questionPic.BackColor = SystemColors.Window;
            questionPic.BorderStyle = BorderStyle.FixedSingle;
            questionPic.Image = (Image)resources.GetObject("questionPic.Image");
            questionPic.Location = new Point(282, 207);
            questionPic.Margin = new Padding(4);
            questionPic.Name = "questionPic";
            questionPic.Size = new Size(614, 420);
            questionPic.SizeMode = PictureBoxSizeMode.Zoom;
            questionPic.TabIndex = 7;
            questionPic.TabStop = false;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(13, 13);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(72, 74);
            button4.TabIndex = 14;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // TransportTopic
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(1110, 839);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(lbScore);
            Controls.Add(tbAnswer);
            Controls.Add(button1);
            Controls.Add(questionPic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransportTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MammalTopic";
            ((System.ComponentModel.ISupportInitialize)questionPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button2;
        private Label lbScore;
        private TextBox tbAnswer;
        private Button button1;
        private PictureBox questionPic;
        private Button button4;
    }
}