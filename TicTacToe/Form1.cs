using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Created by Speros Misirlakis
 * Last updated on 1/8/2014
 */
namespace TicTacToe
{
    
    public partial class Form1 : Form
    {
        
        
        public static TextBox PlayerName1 = new TextBox();

        public Form1()
        {
            InitializeComponent();
            
        }

        
        
        private Player Player1;
        private Player Player2;
        private int WhosTurn;
        //public string NamePlayer1();
        //public string NamePlayer2();
        public int TurnCount; //To end game when total available turns are reached (stalemate)
        
        public class Player 
        {
            public string PlayerName;
            public string PlayerCharacter; // X, O 
            public Color PlayerColor;
            public System.Drawing.Image PlayerImage;
            public int WinCount;
            
                        
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
                        
            WhosTurn = 1;

            Player1 = new Player();
            Player1.PlayerColor = Color.Blue;
            
            label3.Text = Player1.PlayerName;
            //Player1.PlayerName = ;
            //labelFirstPlayerWinCount.Text = Player1.WinCount;
            Player1.PlayerCharacter = "X";
            Player1.PlayerImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\XButton.jpg");

            Player2 = new Player();
            Player2.PlayerColor = Color.Red;
            label4.Text = Player2.PlayerName;
            Player2.PlayerCharacter = "O";
            BackColor = Color.White;
            Player2.PlayerImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\OButton.jpg");


            NewGame();
            //PopupForm2(); //work in progress

                        
        }

        public void CloseForm2()
        {
            
        }

        private void NewGame()
        {
            RestartGame();    
        }



        /*public void PopupForm2()
        {

            Form2 frm = new Form2();
            frm.Show();
            frm.TopMost = true;
            
        }*/




        private void button1_Click(object sender, EventArgs e) // ( TOP LEFT) 
        {
            if (btnTopLeft.BackgroundImage != Player1.PlayerImage && btnTopLeft.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

                if (WhosTurn == 1)
                {

                    btnTopLeft.BackgroundImage = Player1.PlayerImage;
                    WhosTurn = 2;
                    labelWhosTurn.Text = "Currently Second player's turn (O)";
                }
                else if (WhosTurn == 2)
                {

                    btnTopLeft.BackgroundImage = Player2.PlayerImage;
                    WhosTurn = 1;
                    labelWhosTurn.Text = "Currently First player's turn (X)";
                }
                else
                {
                    MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                    this.Close();
                }

                CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }
        }// btnTopLeft

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnTopMiddle.BackgroundImage != Player1.PlayerImage && btnTopMiddle.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

                if (WhosTurn == 1)
                {
                    btnTopMiddle.BackgroundImage = Player1.PlayerImage;
                    WhosTurn = 2;
                    labelWhosTurn.Text = "Currently Second player's turn (O)";
                }
                else if (WhosTurn == 2)
                {
                    btnTopMiddle.BackgroundImage = Player2.PlayerImage;
                    WhosTurn = 1;
                    labelWhosTurn.Text = "Currently First player's turn (X)";
                }
                else
                {
                    MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                    this.Close();
                }

                CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }// btnTopMiddle
        }
        private void btnTopRight_Click(object sender, EventArgs e)
        {
            if (btnTopRight.BackgroundImage != Player1.PlayerImage && btnTopRight.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;
                if (WhosTurn == 1)
                {
                    btnTopRight.BackgroundImage = Player1.PlayerImage;
                    WhosTurn = 2;
                    labelWhosTurn.Text = "Currently Second player's turn (O)";
                }
                else if (WhosTurn == 2)
                {
                    btnTopRight.BackgroundImage = Player2.PlayerImage;
                    WhosTurn = 1;
                    labelWhosTurn.Text = "Currently First player's turn (X)"; 
                }
                else
                {
                    MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                    this.Close();
                }

                CalculateWinner();
            }
                else
            {
                MessageBox.Show("You can't choose that again!");
            }

        }

        private void btnMiddleLeft_Click(object sender, EventArgs e)
        {

            if (btnMiddleLeft.BackgroundImage != Player1.PlayerImage && btnMiddleLeft.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

            if (WhosTurn == 1)
            {
                btnMiddleLeft.BackgroundImage = Player1.PlayerImage;
                WhosTurn = 2;
                labelWhosTurn.Text = "Currently Second player's turn (O)";
            }
            else if (WhosTurn == 2)
            {
                btnMiddleLeft.BackgroundImage = Player2.PlayerImage;
                WhosTurn = 1;
                labelWhosTurn.Text = "Currently First player's turn (X)"; 
            }
            else
            {
                MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                this.Close();
            }

            CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }
        }

        private void btnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (btnMiddleMiddle.BackgroundImage != Player1.PlayerImage && btnMiddleMiddle.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

            if (WhosTurn == 1)
            {
                btnMiddleMiddle.BackgroundImage = Player1.PlayerImage;
                WhosTurn = 2;
                labelWhosTurn.Text = "Currently Second player's turn (O)";
            }
            else if (WhosTurn == 2)
            {
                btnMiddleMiddle.BackgroundImage = Player2.PlayerImage;
                WhosTurn = 1;
                labelWhosTurn.Text = "Currently First player's turn (X)"; 
            }
            else
            {
                MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                this.Close();
            }

            CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }
        }

        private void btnMiddleRight_Click(object sender, EventArgs e)
        {
            if (btnMiddleRight.BackgroundImage != Player1.PlayerImage && btnMiddleRight.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

            if (WhosTurn == 1)
            {
                btnMiddleRight.BackgroundImage = Player1.PlayerImage;
                WhosTurn = 2;
                labelWhosTurn.Text = "Currently Second player's turn (O)";
            }
            else if (WhosTurn == 2)
            {
                btnMiddleRight.BackgroundImage = Player2.PlayerImage;
                WhosTurn = 1;
                labelWhosTurn.Text = "Currently First player's turn (X)"; 
            }
            else
            {
                MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                this.Close();
            }

            CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }
        }

        private void btnBottomLeft_Click(object sender, EventArgs e)
        {
            if (btnBottomLeft.BackgroundImage != Player1.PlayerImage && btnBottomLeft.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

            if (WhosTurn == 1)
            {
                btnBottomLeft.BackgroundImage = Player1.PlayerImage;
                WhosTurn = 2;
                labelWhosTurn.Text = "Currently Second player's turn (O)";
            }
            else if (WhosTurn == 2)
            {
                btnBottomLeft.BackgroundImage = Player2.PlayerImage;
                WhosTurn = 1;
                labelWhosTurn.Text = "Currently First player's turn (X)"; 
            }
            else
            {
                MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                this.Close();
            }

            CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }
        }

        private void btnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (btnBottomMiddle.BackgroundImage != Player1.PlayerImage && btnBottomMiddle.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

            if (WhosTurn == 1)
            {
                btnBottomMiddle.BackgroundImage = Player1.PlayerImage;
                WhosTurn = 2;
                labelWhosTurn.Text = "Currently Second player's turn (O)";
            }
            else if (WhosTurn == 2)
            {
                btnBottomMiddle.BackgroundImage = Player2.PlayerImage;
                WhosTurn = 1;
                labelWhosTurn.Text = "Currently First player's turn (X)"; 
            }
            else
            {
                MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                this.Close();
            }

            CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }
        }

        private void btnBottomRight_Click(object sender, EventArgs e)
        {
            if (btnBottomRight.BackgroundImage != Player1.PlayerImage && btnBottomRight.BackgroundImage != Player2.PlayerImage)
            {
                TurnCount++;

            if (WhosTurn == 1)
            {
                btnBottomRight.BackgroundImage = Player1.PlayerImage;
                WhosTurn = 2;
                labelWhosTurn.Text = "Currently Second player's turn (O)";
            }
            else if (WhosTurn == 2)
            {
                btnBottomRight.BackgroundImage = Player2.PlayerImage;
                WhosTurn = 1;
                labelWhosTurn.Text = "Currently First player's turn (X)"; 
            }
            else
            {
                MessageBox.Show("Error btnTopLeft ; WhosTurn != 1 or 2");
                this.Close();
            }

            CalculateWinner();
            }
            else
            {
                MessageBox.Show("You can't choose that again!");
            }
        }

        private void RestartGame()
        {
            btnTopLeft.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnTopMiddle.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnTopRight.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnMiddleLeft.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnMiddleMiddle.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnMiddleRight.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnBottomLeft.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnBottomMiddle.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            btnBottomRight.BackgroundImage = Image.FromFile(@"C:\Users\Saturn\Documents\Visual Studio 2012\Projects\TicTacToeV1\EmptyButton.jpg");
            TurnCount = 0;
        }

        private void CalculateWinner()
        {
            if ((btnTopLeft.BackgroundImage == Player1.PlayerImage && btnTopMiddle.BackgroundImage == Player1.PlayerImage && btnTopRight.BackgroundImage == Player1.PlayerImage) // top row
                || (btnMiddleLeft.BackgroundImage == Player1.PlayerImage && btnMiddleMiddle.BackgroundImage == Player1.PlayerImage && btnMiddleRight.BackgroundImage == Player1.PlayerImage) // middle row
                || (btnBottomLeft.BackgroundImage == Player1.PlayerImage && btnBottomMiddle.BackgroundImage == Player1.PlayerImage && btnBottomRight.BackgroundImage == Player1.PlayerImage) // bottom row
                || (btnTopLeft.BackgroundImage == Player1.PlayerImage && btnMiddleLeft.BackgroundImage == Player1.PlayerImage && btnBottomLeft.BackgroundImage == Player1.PlayerImage) // left column
                || (btnTopMiddle.BackgroundImage == Player1.PlayerImage && btnMiddleMiddle.BackgroundImage == Player1.PlayerImage && btnBottomMiddle.BackgroundImage == Player1.PlayerImage) // middle clumn
                || (btnTopRight.BackgroundImage == Player1.PlayerImage && btnMiddleRight.BackgroundImage == Player1.PlayerImage && btnBottomRight.BackgroundImage == Player1.PlayerImage) // right clumn
                || (btnTopLeft.BackgroundImage == Player1.PlayerImage && btnMiddleMiddle.BackgroundImage == Player1.PlayerImage && btnBottomRight.BackgroundImage == Player1.PlayerImage) // Diagonal down-slope
                || (btnBottomLeft.BackgroundImage == Player1.PlayerImage && btnMiddleMiddle.BackgroundImage == Player1.PlayerImage && btnTopRight.BackgroundImage == Player1.PlayerImage) // Diagonal up-slope
               )
            {
                MessageBox.Show("Player 1 WINs");
                RestartGame();
                Player1.WinCount++;
                labelFirstPlayerWinCount.Text = Convert.ToString(Player1.WinCount); 
                
            }
            else if ((btnTopLeft.BackgroundImage == Player2.PlayerImage && btnTopMiddle.BackgroundImage == Player2.PlayerImage && btnTopRight.BackgroundImage == Player2.PlayerImage) // top row
                || (btnMiddleLeft.BackgroundImage == Player2.PlayerImage && btnMiddleMiddle.BackgroundImage == Player2.PlayerImage && btnMiddleRight.BackgroundImage == Player2.PlayerImage) // middle row
                || (btnBottomLeft.BackgroundImage == Player2.PlayerImage && btnBottomMiddle.BackgroundImage == Player2.PlayerImage && btnBottomRight.BackgroundImage == Player2.PlayerImage) // bottom row
                || (btnTopLeft.BackgroundImage == Player2.PlayerImage && btnMiddleLeft.BackgroundImage == Player2.PlayerImage && btnBottomLeft.BackgroundImage == Player2.PlayerImage) // left column
                || (btnTopMiddle.BackgroundImage == Player2.PlayerImage && btnMiddleMiddle.BackgroundImage == Player2.PlayerImage && btnBottomMiddle.BackgroundImage == Player2.PlayerImage) // middle clumn
                || (btnTopRight.BackgroundImage == Player2.PlayerImage && btnMiddleRight.BackgroundImage == Player2.PlayerImage && btnBottomRight.BackgroundImage == Player2.PlayerImage) // right clumn
                || (btnTopLeft.BackgroundImage == Player2.PlayerImage && btnMiddleMiddle.BackgroundImage == Player2.PlayerImage && btnBottomRight.BackgroundImage == Player2.PlayerImage) // Diagonal down-slope
                || (btnBottomLeft.BackgroundImage == Player2.PlayerImage && btnMiddleMiddle.BackgroundImage == Player2.PlayerImage && btnTopRight.BackgroundImage == Player2.PlayerImage) // Diagonal up-slope
               )
            {
                MessageBox.Show("Player 2 WINs");
                RestartGame();
                Player2.WinCount++;
                labelSecondPlayerWinCount.Text = Convert.ToString(Player2.WinCount); 
                
            }
            else if (TurnCount == 9) //find a way to not show this message if the last move wins. (if you win on move # 9, it will show this message)
            {
                MessageBox.Show("Stalemate! Nobody Wins, or... you both win! \nIs the cup half empty...or half full? \nIts actually full... \nbe they liquid... \nbe they air... \nbe they dark matter... \nits never empty!");
                RestartGame();
                Player1.WinCount++;
                Player2.WinCount++;
                labelSecondPlayerWinCount.Text = Convert.ToString(Player2.WinCount);
                labelFirstPlayerWinCount.Text = Convert.ToString(Player1.WinCount); 
            }
        }


        private void btnNewGame_Click(object sender, EventArgs e) 
        {
            RestartGame();
            
        }

        private void button1_Click_1(object sender, EventArgs e) //btnEndGame
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //first player name link
        {
            //Player1.PlayerName();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //if btnTopLeft.MouseClick()
            {
                
            }

        }

        private void button2_Click_2(object sender, EventArgs e) //(Reset game)
        {
             
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            labelFirstPlayerWinCount.Text = "0";
            labelSecondPlayerWinCount.Text = "0";
        }

        private void labelFirstPlayerWinCount_Click(object sender, EventArgs e)
        {
            
            
        }

        }


    
}
