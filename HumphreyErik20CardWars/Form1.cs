using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErik20CardWars
{
    public partial class frmCardWars : Form
    {
        // Global declarations
        Random rnd = new Random();
        int scoreCPU, scoreUser, cardIndex;
        int[] cardNumber = new int[52];
        Image[] picCards = new Image[52];

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font BNB;

        public frmCardWars()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.BNB;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.BNB.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.BNB.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            BNB = new Font(fonts.Families[0], 17.9999981F); // Declare bundled Bebas Neue Bold font
        }

        private void frmCardWars_Load(object sender, EventArgs e)
        {
            lblTitleUser.Font = lblTitleCPU.Font = BNB;

            picCards[0] = Properties.Resources.H2;
            picCards[1] = Properties.Resources.H3;
            picCards[2] = Properties.Resources.H4;
            picCards[3] = Properties.Resources.H5;
            picCards[4] = Properties.Resources.H6;
            picCards[5] = Properties.Resources.H7;
            picCards[6] = Properties.Resources.H8;
            picCards[7] = Properties.Resources.H9;
            picCards[8] = Properties.Resources.H10;
            picCards[9] = Properties.Resources.HJ;
            picCards[10] = Properties.Resources.HQ;
            picCards[11] = Properties.Resources.HK;
            picCards[12] = Properties.Resources.HA;
            picCards[13] = Properties.Resources.D2;
            picCards[14] = Properties.Resources.D3;
            picCards[15] = Properties.Resources.D4;
            picCards[16] = Properties.Resources.D5;
            picCards[17] = Properties.Resources.D6;
            picCards[18] = Properties.Resources.D7;
            picCards[19] = Properties.Resources.D8;
            picCards[20] = Properties.Resources.D9;
            picCards[21] = Properties.Resources.D10;
            picCards[22] = Properties.Resources.DJ;
            picCards[23] = Properties.Resources.DQ;
            picCards[24] = Properties.Resources.DK;
            picCards[25] = Properties.Resources.DA;
            picCards[26] = Properties.Resources.C2;
            picCards[27] = Properties.Resources.C3;
            picCards[28] = Properties.Resources.C4;
            picCards[29] = Properties.Resources.C5;
            picCards[30] = Properties.Resources.C6;
            picCards[31] = Properties.Resources.C7;
            picCards[32] = Properties.Resources.C8;
            picCards[33] = Properties.Resources.C9;
            picCards[34] = Properties.Resources.C10;
            picCards[35] = Properties.Resources.CJ;
            picCards[36] = Properties.Resources.CQ;
            picCards[37] = Properties.Resources.CK;
            picCards[38] = Properties.Resources.CA;
            picCards[39] = Properties.Resources.S2;
            picCards[40] = Properties.Resources.S3;
            picCards[41] = Properties.Resources.S4;
            picCards[42] = Properties.Resources.S5;
            picCards[43] = Properties.Resources.S6;
            picCards[44] = Properties.Resources.S7;
            picCards[45] = Properties.Resources.S8;
            picCards[46] = Properties.Resources.S9;
            picCards[47] = Properties.Resources.S10;
            picCards[48] = Properties.Resources.SJ;
            picCards[49] = Properties.Resources.SQ;
            picCards[50] = Properties.Resources.SK;
            picCards[51] = Properties.Resources.SA;
        }

        // User can start a game or get the next card by clicking a button or their card

        private void btnNewGameNextCard_Click(object sender, EventArgs e)
        {
            clickedButtonOrCard();
        }

        private void picCardUser_Click(object sender, EventArgs e)
        {
            clickedButtonOrCard();
        }

        void clickedButtonOrCard()
        {
            int numberUser, numberCPU;

            if (btnNewGameNextCard.Text == "New game")
            {
                btnNewGameNextCard.Text = "Next card";
                btnQuitStop.Text = "Stop game";
                scoreCPU = scoreUser = 0;
                lblScoreCPU.Text = lblScoreUser.Text = "0";

                // Assign cards appropriate numbers

                for (int i = 0; i < 52; i++)
                {
                    cardNumber[i] = i;
                }

                // Shuffle the deck / numbers in the array by swapping random cards with the bottom card

                for (int remaining = 52; remaining >= 1; remaining--)
                {
                    // Pick an item at random
                    int itemPicked = rnd.Next(remaining);
                    // Swap picked item with bottom item
                    int tempValue = cardNumber[itemPicked];
                    cardNumber[itemPicked] = cardNumber[remaining - 1];
                    cardNumber[remaining - 1] = tempValue;
                }

                cardIndex = 0;
            }

            // Assign a card to each player
            numberUser = cardNumber[cardIndex];
            numberCPU = cardNumber[cardIndex + 26]; // Computer uses second half of 52-card deck

            // Display image of assigned cards
            picCardUser.Image = picCards[numberUser];
            picCardCPU.Image = picCards[numberCPU];

            // Assign new numbers based on suit and rank (pips A-10 and face cards)
            if (cardNumber[cardIndex] >= 0 && cardNumber[cardIndex] <= 12)
                numberUser = cardNumber[cardIndex];
            else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 25)
                numberUser = cardNumber[cardIndex] - 13;
            else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 38)
                numberUser = cardNumber[cardIndex] - 26;
            else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 51)
                numberUser = cardNumber[cardIndex] - 39;

            if (cardNumber[cardIndex + 26] >= 0 && cardNumber[cardIndex + 26] <= 12)
                numberCPU = cardNumber[cardIndex + 26];
            else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 25)
                numberCPU = cardNumber[cardIndex + 26] - 13;
            else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 38)
                numberCPU = cardNumber[cardIndex + 26] - 26;
            else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 51)
                numberCPU = cardNumber[cardIndex + 26] - 39;

            // Win: User gets two points for having the higher card value
            if (numberUser > numberCPU)
            {
                scoreUser += 2;
                lblScoreUser.Text = scoreUser.ToString();
                lblStatusMessage.ForeColor = System.Drawing.Color.Green;
                lblStatusMessage.Text = "You won the round!";
            }
            // Lose: Computer gets two points for having the higher card value
            else if (numberUser < numberCPU)
            {
                scoreCPU += 2;
                lblScoreCPU.Text = scoreCPU.ToString();
                lblStatusMessage.ForeColor = System.Drawing.Color.Red;
                lblStatusMessage.Text = "You lost the round.";
            }
            // Tie: User and computer get a point for having equal card values
            else
            {
                scoreUser++;
                scoreCPU++;
                lblScoreUser.Text = scoreUser.ToString();
                lblScoreCPU.Text = scoreCPU.ToString();
                lblStatusMessage.ForeColor = System.Drawing.Color.Blue;
                lblStatusMessage.Text = "You tied this round.";
            }

            cardIndex++;
            // Check if all cards have been drawn
            if (cardIndex > 25)
            {
                // End the game: print results
                MessageBox.Show("There are no more cards to draw!", "Game over");
                MessageBox.Show("You scored " + scoreUser + " points.", "Game over");
                MessageBox.Show("Computer scored " + scoreCPU + " points.", "Game over");
                if (scoreUser > scoreCPU)
                {
                    MessageBox.Show("You win the game!", "Game over");
                    lblStatusMessage.ForeColor = System.Drawing.Color.Green;
                    lblStatusMessage.Text = "You won the game!";
                }
                else if (scoreUser < scoreCPU)
                {
                    MessageBox.Show("Computer wins the game!", "Game over");
                    lblStatusMessage.ForeColor = System.Drawing.Color.Red;
                    lblStatusMessage.Text = "Computer won the game.";
                }
                else
                {
                    MessageBox.Show("The game ends in a draw!", "Game over");
                    lblStatusMessage.ForeColor = System.Drawing.Color.Blue;
                    lblStatusMessage.Text = "The game ended in a draw.";
                }

                // Reset buttons
                btnNewGameNextCard.Text = "New game";
                btnQuitStop.Text = "Quit game";
            }
        }

        private void btnQuitStop_Click(object sender, EventArgs e)
        {
            if (btnQuitStop.Text == "Quit game")
                this.Close();
            else
            {
                btnNewGameNextCard.Text = "New game";
                btnQuitStop.Text = "Quit game";
            }
        }
    }
}
