﻿using System;
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
                if (playerVsPlayerMode)    // Tarkistaa, onko kahden pelaajan pelimuoto valittu
                {
                    if (turn % 2 != 0)    // Tarkistaa, kumman pelaajan vuoro on
                    {
                        button1.Text = "X";
                    }
                    else
                    {
                        button1.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button2.Text = "X";
                    }
                    else
                    {
                        button2.Text = "O";
                    }
                    turn++;
                    click2++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }   
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button3.Text = "X";
                    }
                    else
                    {
                        button3.Text = "O";
                    }
                    turn++;
                    click3++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button4.Text = "X";
                    }
                    else
                    {
                        button4.Text = "O";
                    }
                    turn++;
                    click4++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button5.Text = "X";
                    }
                    else
                    {
                        button5.Text = "O";
                    }
                    turn++;
                    click5++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button6.Text = "X";
                    }
                    else
                    {
                        button6.Text = "O";
                    }
                    turn++;
                    click6++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button7.Text = "X";
                    }
                    else
                    {
                        button7.Text = "O";
                    }
                    turn++;
                    click7++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button8.Text = "X";
                    }
                    else
                    {
                        button8.Text = "O";
                    }
                    turn++;
                    click8++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
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
                if (playerVsPlayerMode)
                {
                    if (turn % 2 != 0)
                    {
                        button9.Text = "X";
                    }
                    else
                    {
                        button9.Text = "O";
                    }
                    turn++;
                    click9++;
                }
                else
                {
                    MessageBox.Show("Valitse pelimuoto", "Huomio");
                }
            }
            else
            {
                button9.Text = button9.Text;
            }
            Check();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Restart();      // Käynnistää sovelluksen uudestaan
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
            }
        }

        bool playerVsPlayerMode;
        private void radioButtonPlayerVsPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlayerVsPlayer.Checked )
            {
                playerVsPlayerMode = true;
            }
            else
            {
                playerVsPlayerMode = false;
            }
        }
    }
}
