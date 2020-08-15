using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieGuessGame_WindowsForms_
{
    public partial class GameForm : Form
    {

        /// <summary>
        /// int number that the user entered for guessing
        /// </summary>
        int iUserGuess;
        /// <summary>
        /// int number which stores a rolled value
        /// </summary>
        int iRollResult;
        /// <summary>
        /// int number of how mamny times the user played rolling
        /// </summary>
        int iNumPlayed = 0;
        /// <summary>
        /// int number of how many times the user won
        /// </summary>
        int iNumWon = 0;
        /// <summary>
        /// int number of how many times the user lost
        /// </summary>
        int iNumLost = 0;

        int iFrequency1 = 0; //count of face 1 is rolled
        int iFrequency2 = 0; //count of face 2 is rolled
        int iFrequency3 = 0; //count of face 3 is rolled
        int iFrequency4 = 0; //count of face 4 is rolled
        int iFrequency5 = 0; //count of face 5 is rolled
        int iFrequency6 = 0; //count of face 6 is rolled

        float fPercent1 = 0; //percent of face 1 is rolled
        float fPercent2 = 0; //percent of face 2 is rolled
        float fPercent3 = 0; //percent of face 3 is rolled
        float fPercent4 = 0; //percent of face 4 is rolled
        float fPercent5 = 0; //percent of face 5 is rolled
        float fPercent6 = 0; //percent of face 6 is rolled

        int iNumGuess1 = 0; //number of times that the user guessed 1
        int iNumGuess2 = 0; //number of times that the user guessed 2
        int iNumGuess3 = 0; //number of times that the user guessed 3
        int iNumGuess4 = 0; //number of times that the user guessed 4
        int iNumGuess5 = 0; //number of times that the user guessed 5
        int iNumGuess6 = 0; //number of times that the user guessed 6


        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event is for validating user's guessing input to see if it is a number or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserGuessNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userInput = e.KeyChar;

            if( !char.IsDigit(userInput) && userInput != 8)
            {                
                MessageBox.Show("Only integer is allowed to enter.");
                e.Handled = true;
            }
            else
            {
                btnRoll.Enabled = true;
            }
        }

        /// <summary>
        /// This event is fired when the user clicks a Roll button. It rolls a die and present a statistic result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRoll_Click(object sender, EventArgs e)
        {
            //bool isParsable = Int32.TryParse(txtUserGuessNumber.Text, out iUserGuess);
            iUserGuess = Int32.Parse(txtUserGuessNumber.Text);

            if( (iUserGuess != 1) && (iUserGuess != 2) && (iUserGuess != 3) &&
                (iUserGuess != 4) && (iUserGuess != 5) && (iUserGuess != 6) )
            {
                MessageBox.Show("Invalid input. Please enter an integer 1 - 6.");
            }
            else
            {
                pbDieImage.SizeMode = PictureBoxSizeMode.StretchImage;
                Random randomNumbers = new Random();

                for (int i = 1; i < 7; i++)
                {
                    iRollResult = randomNumbers.Next(1, 7);

                    //load the image
                    pbDieImage.Image = Image.FromFile("die" + iRollResult.ToString() + ".gif");
                    //refresh the image
                    pbDieImage.Refresh();
                    //put a sleep to the code to slow it down. Lock the UI. Higher number, slower UI.
                    Thread.Sleep(300);
                }

                iNumPlayed++;
                lblPlayedCount.Text = iNumPlayed.ToString();

                if (iRollResult == iUserGuess)
                {
                    iNumWon++;
                    lblWonCount.Text = iNumWon.ToString();
                }
                else
                {
                    iNumLost++;
                    lblLostCount.Text = iNumLost.ToString();
                }

                switch(iUserGuess)
                {
                    case 1:
                        ++iNumGuess1;
                        break;
                    case 2:
                        ++iNumGuess2;
                        break;
                    case 3:
                        ++iNumGuess3;
                        break;
                    case 4:
                        ++iNumGuess4;
                        break;
                    case 5:
                        ++iNumGuess5;
                        break;
                    case 6:
                        ++iNumGuess6;
                        break;
                }

                switch(iRollResult)
                {
                    case 1:
                        ++iFrequency1;
                        break;
                    case 2:
                        ++iFrequency2;
                        break;
                    case 3:
                        ++iFrequency3;
                        break;
                    case 4:
                        ++iFrequency4;
                        break;
                    case 5:
                        ++iFrequency5;
                        break;
                    case 6:
                        ++iFrequency6;
                        break;
                }

                fPercent1 = (float)(iFrequency1) / iNumPlayed * 100;
                fPercent2 = (float)(iFrequency2) / iNumPlayed * 100;
                fPercent3 = (float)(iFrequency3) / iNumPlayed * 100;
                fPercent4 = (float)(iFrequency4) / iNumPlayed * 100;
                fPercent5 = (float)(iFrequency5) / iNumPlayed * 100;
                fPercent6 = (float)(iFrequency6) / iNumPlayed * 100;

                rtxtStat.AppendText("FACE\t FREQUENCY\t PERCENT\t NUMBER OF TIMES GUESSED");
                rtxtStat.Text = Environment.NewLine;
                rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 1, iFrequency1, fPercent1, iNumGuess1));
                rtxtStat.Text = Environment.NewLine;
                rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 2, iFrequency2, fPercent2, iNumGuess2));
                rtxtStat.Text = Environment.NewLine;
                rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 3, iFrequency3, fPercent3, iNumGuess3));
                rtxtStat.Text = Environment.NewLine;
                rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 4, iFrequency4, fPercent4, iNumGuess4));
                rtxtStat.Text = Environment.NewLine;
                rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 5, iFrequency5, fPercent5, iNumGuess5));
                rtxtStat.Text = Environment.NewLine;
                rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 6, iFrequency6, fPercent6, iNumGuess6));
                rtxtStat.Text = Environment.NewLine;

                btnReset.Enabled = true;
            }
        }

        /// <summary>
        /// This event is fired after second rolling when stat textbox content is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtxtStat_TextChanged(object sender, EventArgs e)
        {
            if (iNumPlayed == 0)
            {
                fPercent1 = 0;
                fPercent2 = 0;
                fPercent3 = 0;
                fPercent4 = 0;
                fPercent5 = 0;
                fPercent6 = 0;
            }
            fPercent1 = (float)(iFrequency1) / iNumPlayed * 100;
            fPercent2 = (float)(iFrequency2) / iNumPlayed * 100;
            fPercent3 = (float)(iFrequency3) / iNumPlayed * 100;
            fPercent4 = (float)(iFrequency4) / iNumPlayed * 100;
            fPercent5 = (float)(iFrequency5) / iNumPlayed * 100;
            fPercent6 = (float)(iFrequency6) / iNumPlayed * 100;

            rtxtStat.AppendText("FACE\t FREQUENCY\t PERCENT\t NUMBER OF TIMES GUESSED");
            rtxtStat.Text += Environment.NewLine;
            rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 1, iFrequency1, fPercent1, iNumGuess1));
            rtxtStat.Text += Environment.NewLine;
            rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 2, iFrequency2, fPercent2, iNumGuess2));
            rtxtStat.Text += Environment.NewLine;
            rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 3, iFrequency3, fPercent3, iNumGuess3));
            rtxtStat.Text += Environment.NewLine;
            rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 4, iFrequency4, fPercent4, iNumGuess4));
            rtxtStat.Text += Environment.NewLine;
            rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 5, iFrequency5, fPercent5, iNumGuess5));
            rtxtStat.Text += Environment.NewLine;
            rtxtStat.AppendText(String.Format("{0}\t{1}\t\t{2:f2}%\t\t\t{3}", 6, iFrequency6, fPercent6, iNumGuess6));
        }

        /// <summary>
        /// This event is fired when the user clicks a Reset button. It resets the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReset_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();

            iUserGuess = 0;
            iRollResult = 0;
            iNumPlayed = 0;
            iNumWon = 0;
            iNumLost = 0;
            iFrequency1 = 0; //count of face 1 is rolled
            iFrequency2 = 0; //count of face 2 is rolled
            iFrequency3 = 0; //count of face 3 is rolled
            iFrequency4 = 0; //count of face 4 is rolled
            iFrequency5 = 0; //count of face 5 is rolled
            iFrequency6 = 0; //count of face 6 is rolled

            fPercent1 = 0; //percent of face 1 is rolled
            fPercent2 = 0; //percent of face 2 is rolled
            fPercent3 = 0; //percent of face 3 is rolled
            fPercent4 = 0; //percent of face 4 is rolled
            fPercent5 = 0; //percent of face 5 is rolled
            fPercent6 = 0; //percent of face 6 is rolled

            iNumGuess1 = 0; //number of times that the user guessed 1
            iNumGuess2 = 0; //number of times that the user guessed 2
            iNumGuess3 = 0; //number of times that the user guessed 3
            iNumGuess4 = 0; //number of times that the user guessed 4
            iNumGuess5 = 0; //number of times that the user guessed 5
            iNumGuess6 = 0; //number of times that the user guessed 6
        }
       
    }
}
