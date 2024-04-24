using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinollapeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int click1 = 0;
        int turn = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)    // Tarkistaa, kumman pelaajan vuoro on
                {
                    button1.Text = "X";
                    button1.Enabled = false;
                }
                else
                {
                    button1.Text = "O";
                    button1.Enabled = false;
                }
                turn++;
                click1++;
            }
            else
            {
                button1.Text = button1.Text;
            }
            Check();
        }

        int click2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                    button2.Enabled = false;
                }
                else
                {
                    button2.Text = "O";
                    button2.Enabled = false;
                }
                turn++;
                click2++;
            }
            else
            {
                button2.Text = button2.Text;
            }
            Check();
        }

        int click3 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                    button3.Enabled = false;
                }
                else
                {
                    button3.Text = "O";
                    button3.Enabled = false;
                }
                turn++;
                click3++;
            }
            else
            {
                button3.Text = button3.Text;
            }
            Check();
        }

        int click4 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                    button4.Enabled = false;
                }
                else
                {
                    button4.Text = "O";
                    button4.Enabled = false;
                }
                turn++;
                click4++;
            }
            else
            {
                button4.Text = button4.Text;
            }
            Check();
        }

        int click5 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                    button5.Enabled = false;
                }
                else
                {
                    button5.Text = "O";
                    button5.Enabled = false;
                }
                turn++;
                click5++;   
            }
            else
            {
                button5.Text = button5.Text;
            }
            Check();
        }

        int click6 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                    button6.Enabled = false;
                }
                else
                {
                    button6.Text = "O";
                    button6.Enabled = false;
                }
                turn++;
                click6++;
                
            }
            else
            {
                button6.Text = button6.Text;
            }
            Check();
        }

        int click7 = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                    button7.Enabled = false;
                }
                else
                {
                    button7.Text = "O";
                    button7.Enabled = false;
                }
                turn++;
                click7++;
            }
            else
            {
                button7.Text = button7.Text;
            }
            Check();
        }

        int click8 = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {

                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                    button8.Enabled = false;
                }
                else
                {
                    button8.Text = "O";
                    button8.Enabled = false;
                }
                turn++;
                click8++;
            }
            else
            {
                button8.Text = button8.Text;
            }
            Check();
        }

        int click9 = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                    button9.Enabled = false;
                }
                else
                {
                    button9.Text = "O";
                    button9.Enabled = false;
                }
                turn++;
                click9++;
            }
            else
            {
                button9.Text = button9.Text;
            }
            Check();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ResetGame();    // Kutsuu metodia, joka nollaa pelin
        }

        private void Check()
        {
            if (
                button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||        // Tarkistaa kaikki mahdolliset kolmen suorat
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                    )
            {
                MessageBox.Show("Pelaaja 1 voittaa!", "Huomio");
                player1Wins++;
                UpdateScoreboard();     // Päivittää pistetaulukon
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;       // Poistaa napit käytöstä, kunnes peli nollataan
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (
                button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                MessageBox.Show("Pelaaja 2 voittaa!", "Huomio");
                player2Wins++;
                UpdateScoreboard();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
            else if (
                button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                button7.Enabled == false && button8.Enabled == false && button9.Enabled == false
                )
            {
                MessageBox.Show("Tasapeli!", "Huomio");
            }
        }

        

        private void ResetGame()
        {
            turn = 1;
            click1 = 0;
            click2 = 0;
            click3 = 0;
            click4 = 0;
            click5 = 0;
            click6 = 0;
            click7 = 0;
            click8 = 0;
            click9 = 0;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;     // Ottaa pelilaudan napit takaisin käyttöön
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";      // Poistaa napeista merkit
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        

        private void UpdateScoreboard()
        {
            player1Score.Text = player1Wins.ToString();
            player2Score.Text = player2Wins.ToString();
        }

        int player1Wins = 0;
        private void player1Score_Click(object sender, EventArgs e)
        {
            
        }

        int player2Wins = 0;
        private void player2Score_Click(object sender, EventArgs e)
        {
            
        }
    }
}
