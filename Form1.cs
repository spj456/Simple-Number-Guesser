using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGUI
{
    public partial class Form1 : Form
    {
        int userGuess = -1;
        int correctNumber = -1;

        public Form1()
        {
            InitializeComponent();
            setRandomNumber();
        }

        private void setRandomNumber()
        {
            Random random = new Random();
            correctNumber = random.Next(1, 11);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if(int.TryParse(textBox1.Text, out temp))
            {
                userGuess = Int32.Parse(textBox1.Text);
            }
        }

        private void runGuessBtn_Click(object sender, EventArgs e)
        {
            int temp;
            if(int.TryParse(textBox1.Text, out temp))
            {
                if(userGuess == correctNumber)
                {
                    DialogResult result = MessageBox.Show("Correct! Play again?", "Congratulations!" , MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        setRandomNumber();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if(1 > userGuess || userGuess > 10)
                {
                    MessageBox.Show("Please enter a number between 1 and 10.");
                }
                else
                {
                    MessageBox.Show("Wrong number, try again!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
