using System;
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
    }
}
