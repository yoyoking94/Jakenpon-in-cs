using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jakenpon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            resField.Text = rockButton.Text;
            verif();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            resField.Text = paperButton.Text;
            verif();
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            resField.Text = scissorsButton.Text;
            verif();
        }

        private void lizardButton_Click(object sender, EventArgs e)
        {
            resField.Text = lizardButton.Text;
            verif();
        }

        private void spokeButton_Click(object sender, EventArgs e)
        {
            resField.Text = spokeButton.Text;
            verif();
        }



        private void verif()
        {
            var random = new Random();
            var list = new List<string> { "Rock", "Paper", "Scissors", "Lezard", "Spoke" };
            int index = random.Next(list.Count);
            String listIndex = list[index];

            if (resField.Text == list[index])
            {
                resField.Text = "égalité ! we both choose : " + resField.Text;
            } else if((resField.Text == "Spoke") && (listIndex == "Scissors") || (resField.Text == "Scissors") && (listIndex == "Paper") 
                    || (resField.Text == "Paper") && (listIndex == "Rock") || (resField.Text == "Rock") && (listIndex == "Lezard")
                    || (resField.Text == "Lezard") && (listIndex == "Spoke") || (resField.Text == "Spoke") && (listIndex == "Rock")
                    || (resField.Text == "Rock") && (listIndex == "Scissors") || (resField.Text == "Scissors") && (listIndex == "Rock")
                    || (resField.Text == "Lezard") && (listIndex == "Paper") || (resField.Text == "Paper") && (listIndex == "Spoke"))
            {
                resField.Text = "You win ! you choose : " + resField.Text + "and i choose : " + listIndex;
            }
            else
            {
                resField.Text = "You loose ! you choose : " + resField.Text + "and i choose : " + listIndex;
            }
        }

        //Menu strip

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();         // exit program
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2021 © Yovish MOONESAMY\n" + "Developped in 2021\n" + "Why ? because i'm bored\n");
            // print message through a box
        }
    }
}
