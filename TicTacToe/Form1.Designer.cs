namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn
                = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.btnBottomMiddle = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnMiddleRight = new System.Windows.Forms.Button();
            this.btnMiddleMiddle = new System.Windows.Forms.Button();
            this.btnMiddleLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnTopMiddle = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFirstPlayerWinCount = new System.Windows.Forms.Label();
            this.labelSecondPlayerWinCount = new System.Windows.Forms.Label();
            this.labelWhosTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(651, 290);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(317, 53);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "New Game / Reset Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(651, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Quit Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnResetScore
            // 
            this.btnResetScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetScore.Location = new System.Drawing.Point(651, 349);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(317, 53);
            this.btnResetScore.TabIndex = 11;
            this.btnResetScore.Text = "Reset Score";
            this.btnResetScore.UseVisualStyleBackColor = true;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Player (X)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(821, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Second Player (O)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 14;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBottomRight.BackgroundImage")));
            this.btnBottomRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBottomRight.FlatAppearance.BorderSize = 0;
            this.btnBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomRight.Location = new System.Drawing.Point(434, 341);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(138, 120);
            this.btnBottomRight.TabIndex = 8;
            this.btnBottomRight.Text = " ";
            this.btnBottomRight.UseVisualStyleBackColor = true;
            this.btnBottomRight.Click += new System.EventHandler(this.btnBottomRight_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBottomMiddle.BackgroundImage")));
            this.btnBottomMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBottomMiddle.FlatAppearance.BorderSize = 0;
            this.btnBottomMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomMiddle.Location = new System.Drawing.Point(265, 341);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(138, 120);
            this.btnBottomMiddle.TabIndex = 7;
            this.btnBottomMiddle.Text = " ";
            this.btnBottomMiddle.UseVisualStyleBackColor = true;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btnBottomMiddle_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBottomLeft.BackgroundImage")));
            this.btnBottomLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBottomLeft.FlatAppearance.BorderSize = 0;
            this.btnBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomLeft.Location = new System.Drawing.Point(97, 341);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(138, 120);
            this.btnBottomLeft.TabIndex = 6;
            this.btnBottomLeft.Text = " ";
            this.btnBottomLeft.UseVisualStyleBackColor = true;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnBottomLeft_Click);
            // 
            // btnMiddleRight
            // 
            this.btnMiddleRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMiddleRight.BackgroundImage")));
            this.btnMiddleRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMiddleRight.FlatAppearance.BorderSize = 0;
            this.btnMiddleRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleRight.Location = new System.Drawing.Point(434, 197);
            this.btnMiddleRight.Name = "btnMiddleRight";
            this.btnMiddleRight.Size = new System.Drawing.Size(138, 120);
            this.btnMiddleRight.TabIndex = 5;
            this.btnMiddleRight.Text = " ";
            this.btnMiddleRight.UseVisualStyleBackColor = true;
            this.btnMiddleRight.Click += new System.EventHandler(this.btnMiddleRight_Click);
            // 
            // btnMiddleMiddle
            // 
            this.btnMiddleMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMiddleMiddle.BackgroundImage")));
            this.btnMiddleMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMiddleMiddle.FlatAppearance.BorderSize = 0;
            this.btnMiddleMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleMiddle.Location = new System.Drawing.Point(265, 197);
            this.btnMiddleMiddle.Name = "btnMiddleMiddle";
            this.btnMiddleMiddle.Size = new System.Drawing.Size(138, 120);
            this.btnMiddleMiddle.TabIndex = 4;
            this.btnMiddleMiddle.Text = " ";
            this.btnMiddleMiddle.UseVisualStyleBackColor = true;
            this.btnMiddleMiddle.Click += new System.EventHandler(this.btnMiddleMiddle_Click);
            // 
            // btnMiddleLeft
            // 
            this.btnMiddleLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMiddleLeft.BackgroundImage")));
            this.btnMiddleLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMiddleLeft.FlatAppearance.BorderSize = 0;
            this.btnMiddleLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleLeft.Location = new System.Drawing.Point(97, 197);
            this.btnMiddleLeft.Name = "btnMiddleLeft";
            this.btnMiddleLeft.Size = new System.Drawing.Size(138, 120);
            this.btnMiddleLeft.TabIndex = 3;
            this.btnMiddleLeft.Text = " ";
            this.btnMiddleLeft.UseVisualStyleBackColor = true;
            this.btnMiddleLeft.Click += new System.EventHandler(this.btnMiddleLeft_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTopRight.BackgroundImage")));
            this.btnTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTopRight.FlatAppearance.BorderSize = 0;
            this.btnTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopRight.Location = new System.Drawing.Point(434, 58);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(138, 120);
            this.btnTopRight.TabIndex = 2;
            this.btnTopRight.Text = " ";
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // btnTopMiddle
            // 
            this.btnTopMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTopMiddle.BackgroundImage")));
            this.btnTopMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTopMiddle.FlatAppearance.BorderSize = 0;
            this.btnTopMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopMiddle.Location = new System.Drawing.Point(265, 58);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(138, 120);
            this.btnTopMiddle.TabIndex = 1;
            this.btnTopMiddle.Text = " ";
            this.btnTopMiddle.UseVisualStyleBackColor = true;
            this.btnTopMiddle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTopLeft.BackgroundImage")));
            this.btnTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTopLeft.FlatAppearance.BorderSize = 0;
            this.btnTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopLeft.Location = new System.Drawing.Point(97, 58);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(138, 120);
            this.btnTopLeft.TabIndex = 0;
            this.btnTopLeft.Text = " ";
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(828, 86);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 15;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Player 1 win count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(841, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Player 2 win count:";
            // 
            // labelFirstPlayerWinCount
            // 
            this.labelFirstPlayerWinCount.AutoSize = true;
            this.labelFirstPlayerWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstPlayerWinCount.Location = new System.Drawing.Point(648, 135);
            this.labelFirstPlayerWinCount.Name = "labelFirstPlayerWinCount";
            this.labelFirstPlayerWinCount.Size = new System.Drawing.Size(23, 25);
            this.labelFirstPlayerWinCount.TabIndex = 19;
            this.labelFirstPlayerWinCount.Tag = "";
            this.labelFirstPlayerWinCount.Text = "0";
            this.labelFirstPlayerWinCount.Click += new System.EventHandler(this.labelFirstPlayerWinCount_Click);
            // 
            // labelSecondPlayerWinCount
            // 
            this.labelSecondPlayerWinCount.AutoSize = true;
            this.labelSecondPlayerWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondPlayerWinCount.Location = new System.Drawing.Point(945, 135);
            this.labelSecondPlayerWinCount.Name = "labelSecondPlayerWinCount";
            this.labelSecondPlayerWinCount.Size = new System.Drawing.Size(23, 25);
            this.labelSecondPlayerWinCount.TabIndex = 20;
            this.labelSecondPlayerWinCount.Text = "0";
            // 
            // labelWhosTurn
            // 
            this.labelWhosTurn.AutoSize = true;
            this.labelWhosTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhosTurn.Location = new System.Drawing.Point(646, 209);
            this.labelWhosTurn.Name = "labelWhosTurn";
            this.labelWhosTurn.Size = new System.Drawing.Size(335, 29);
            this.labelWhosTurn.TabIndex = 21;
            this.labelWhosTurn.Text = "Currently First player\'s turn (X)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1025, 506);
            this.Controls.Add(this.labelWhosTurn);
            this.Controls.Add(this.labelSecondPlayerWinCount);
            this.Controls.Add(this.labelFirstPlayerWinCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomMiddle);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnMiddleRight);
            this.Controls.Add(this.btnMiddleMiddle);
            this.Controls.Add(this.btnMiddleLeft);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopMiddle);
            this.Controls.Add(this.btnTopLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnTopMiddle;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnMiddleLeft;
        private System.Windows.Forms.Button btnMiddleMiddle;
        private System.Windows.Forms.Button btnMiddleRight;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnBottomMiddle;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResetScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFirstPlayerWinCount;
        private System.Windows.Forms.Label labelSecondPlayerWinCount;
        private System.Windows.Forms.Label labelWhosTurn;
    }
}

