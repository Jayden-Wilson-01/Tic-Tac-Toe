using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Board
{
    public partial class TicTacToeBoard : UserControl
    {
        public TicTacToeBoard()
        {
            InitializeComponent();
        }

        //Current player playing the game
        byte currentPlayer = 1;

        //Points of the two players
        byte[] playerPoints = {0, 0};

        //Check status of winning, 1 = winner, 0 = still playing, -1 = draw
        int won = 0;

        //A digital board of the game
        string[] boardArray = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

        /// <summary>
        /// Method to allow for user to click on any button and make it X or O
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoardButtons_Click(object sender, EventArgs e)
        {
            //Set value of button
            SetValue((Button)sender);

            //Check if any player has won 
            won = CheckWin();

            //If a player wins, reset, else continue to play and play as the next player
            if (won == 1)
            {
                MessageBox.Show($"Winning player is player {currentPlayer}");
                GivePoint(currentPlayer - 1);
                ResetGame();
            }
            else if(won == -1)
            {
                MessageBox.Show($"Both players are a tie");
                ResetGame();
            }
            else
            {
                SetCurrentPlayer();
            }
        }

        /// <summary>
        /// Add a point for a player
        /// </summary>
        /// <param name="player">the player to give a point to</param>
        private void GivePoint(int player)
        {
            playerPoints[player]++;
            labelPlayer1Points.Text = playerPoints[0].ToString();
            labelPlayer2Points.Text = playerPoints[1].ToString();
        }

        /// <summary>
        /// Reset the game to its original state
        /// </summary>
        private void ResetGame()
        {
            //Set player to 1
            currentPlayer = 1;

            //Highlight what player is playing
            labelPlayer1.ForeColor = Color.Blue;
            labelPlayer2.ForeColor = Color.Black;

            //Reset digital board
            for (int i = 0; i < boardArray.Length; i++)
            {
                //Reset digital board values
                boardArray[i] = i.ToString();

                //Reset board button values
                flowLayoutPanelButtons.Controls[i].Text = "";

                //Reset board button enabled states
                flowLayoutPanelButtons.Controls[i].Enabled = true;
            }
        }

        /// <summary>
        /// Set the current player to the opposite that it already is
        /// </summary>
        private void SetCurrentPlayer()
        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
                labelPlayer2.ForeColor = Color.Blue;
                labelPlayer1.ForeColor = Color.Black;

            }
            else if (currentPlayer == 2)
            {
                currentPlayer = 1;
                labelPlayer1.ForeColor = Color.Blue;
                labelPlayer2.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Set values for the digital board and real board
        /// </summary>
        /// <param name="button">The button user just clicked</param>
        private void SetValue(Button button)
        {
            try
            {
                if(button != null && button.Tag != null)
                {
                    //Get index of button from its tag
                    int buttonIndex = int.Parse(button.Tag.ToString());

                    //Check which player is currently playing
                    if(currentPlayer == 1)
                    {
                        //Set button text to X
                        button.Text = "X";
                        boardArray[buttonIndex] = "X";
                    }
                    else if(currentPlayer == 2)
                    {
                        //Set button text to O
                        button.Text = "O";
                        boardArray[buttonIndex] = "O";
                    }

                    //Prevent buttob being clicked again
                    button.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        /// <summary>
        /// Method to check if player has won
        /// </summary>
        /// <returns>Returns if player has won</returns>
        private int CheckWin()
        {
            try
            {
                #region Rows
                //First row
                if (boardArray[0] == boardArray[1] && boardArray[1] == boardArray[2])
                {
                    return 1;
                }

                //Second row
                else if (boardArray[3] == boardArray[4] && boardArray[4] == boardArray[5])
                {
                    return 1;
                }

                //Third row
                else if (boardArray[6] == boardArray[7] && boardArray[7] == boardArray[8])
                {
                    return 1;
                }
                #endregion

                #region Columns
                //First column
                else if (boardArray[0] == boardArray[3] && boardArray[3] == boardArray[6])
                {
                    return 1;
                }

                //Second column
                else if (boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7])
                {
                    return 1;
                }

                //Third column
                else if (boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8])
                {
                    return 1;
                }
                #endregion

                #region Diagonal
                //First diagonal
                else if (boardArray[0] == boardArray[4] && boardArray[4] == boardArray[8])
                {
                    return 1;
                }

                //Second diagonal
                else if (boardArray[2] == boardArray[4] && boardArray[4] == boardArray[6])
                {
                    return 1;
                }
                #endregion

                #region Draw
                else if (boardArray[0] != "0" && boardArray[1] != "1" && boardArray[2] != "2" && boardArray[3] != "3" && boardArray[4] != "4" && boardArray[5] != "5" && boardArray[6] != "6" && boardArray[7] != "7" && boardArray[8] != "8")
                {
                    return -1;
                }
                #endregion

                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong");
                return 0;
            }
        }
    }
}
