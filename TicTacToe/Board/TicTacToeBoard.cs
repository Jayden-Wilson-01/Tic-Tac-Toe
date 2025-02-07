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
        byte currentPlayer = 0;

        //A digital board of the game
        string[] boardArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

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
            bool won = CheckWin();

            //If a player wins, reset, else continue to play and play as the next player
            if (won)
            {
                MessageBox.Show($"Winning player is player {currentPlayer + 1}");

                ResetGame();
            }
            else
            {
                SetCurrentPlayer();
            }
        }

        /// <summary>
        /// Reset the game to its original state
        /// </summary>
        private void ResetGame()
        {
            //Set player to 0
            currentPlayer = 0;

            //Reset digital board
            for (int i = 1; i < boardArray.Length; i++)
            {
                //Reset digital board values
                boardArray[i] = i.ToString();

                //Reset board button values
                flowLayoutPanelButtons.Controls[i].Text = "";
            }
        }

        /// <summary>
        /// Set the current player to the opposite that it already is
        /// </summary>
        private void SetCurrentPlayer()
        {
            if (currentPlayer == 0)
            {
                currentPlayer++;
            }
            else if (currentPlayer == 1)
            {
                currentPlayer--;
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
                    if(currentPlayer == 0)
                    {
                        //Set button text to X
                        button.Text = "X";
                        boardArray[buttonIndex] = "X";
                    }
                    else if(currentPlayer == 1)
                    {
                        //Set button text to O
                        button.Text = "O";
                        boardArray[buttonIndex] = "O";
                    }
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
        private bool CheckWin()
        {
            try
            {
                #region Rows
                //First row
                if (boardArray[0] == boardArray[1] && boardArray[1] == boardArray[2])
                {
                    return true;
                }

                //Second row
                else if (boardArray[3] == boardArray[4] && boardArray[4] == boardArray[5])
                {
                    return true;
                }

                //Third row
                else if (boardArray[6] == boardArray[7] && boardArray[7] == boardArray[8])
                {
                    return true;
                }
                #endregion

                #region Columns
                //First column
                else if (boardArray[0] == boardArray[3] && boardArray[3] == boardArray[6])
                {
                    return true;
                }

                //Second column
                else if (boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7])
                {
                    return true;
                }

                //Third column
                else if (boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8])
                {
                    return true;
                }
                #endregion

                #region Diagonal
                //First diagonal
                else if (boardArray[0] == boardArray[4] && boardArray[4] == boardArray[8])
                {
                    return true;
                }

                //Second diagonal
                else if (boardArray[2] == boardArray[4] && boardArray[4] == boardArray[6])
                {
                    return true;
                }
                #endregion

                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
