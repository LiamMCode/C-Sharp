using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace objects_moving_across_screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void movement(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                picbox1.Left = picbox1.Left + 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                picbox2.Left = picbox2.Left + 5;
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "" + (Convert.ToInt16(lblTime) + 1);

            if (picbox1.Left >= 918)
            {
                tmr1.Stop();
                MessageBox.Show("It took you " + lblTime + " seconds");
            }
            else
            {
                if (picbox2.Left >= 918) //image 2
                {
                    tmr2.Stop();
                    MessageBox.Show("It took your opponet " + lblTime + " seconds");
                } 
            }
        }

        

    }
}
