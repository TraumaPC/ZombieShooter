using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZombieShooter
{
    public partial class menuFrm : Form
    {
        public menuFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if (hardRB.Checked)
            {
                Form1 new_game = new Form1();
                new_game.Show();
                new_game.zombieSpeed = 6;
                new_game.speed = 5;
                new_game.ammo = 5;
            }
            else
            {
                Form1 new_game = new Form1();
                new_game.Show();
            }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            aboutFrm about_form = new aboutFrm();
            about_form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hardRB_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
