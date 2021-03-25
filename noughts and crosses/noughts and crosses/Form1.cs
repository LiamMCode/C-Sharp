using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noughts_and_crosses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            (sender as Control).Enabled = false; 
            if (lbl1.Visible == true)
            {
                lbl1.Visible = false;
                lbl2.Visible = true;
                (sender as Control).Text = "X"; 
            }
            else
            {
                lbl1.Visible = true;
                lbl2.Visible = false;
                (sender as Control).Text = "O"; 
            }
            if ((btn1.Text == "X") && (btn2.Text == "X") && (btn3.Text == "X"))
            {
                btn1.BackColor = Color.LightGreen;
                btn2.BackColor = Color.LightGreen;
                btn3.BackColor = Color.LightGreen;
            }
            if ((btn1.Text == "O") && (btn2.Text == "O") && (btn3.Text == "O"))
            {
                btn1.BackColor = Color.LightPink;
                btn2.BackColor = Color.LightPink;
                btn3.BackColor = Color.LightPink;
            }
            if ((btn4.Text == "X") && (btn5.Text == "X") && (btn6.Text == "X"))
            {
                btn4.BackColor = Color.LightGreen;
                btn5.BackColor = Color.LightGreen;
                btn6.BackColor = Color.LightGreen;
            }
            if ((btn4.Text == "O") && (btn5.Text == "O") && (btn6.Text == "O"))
            {
                btn4.BackColor = Color.LightPink;
                btn5.BackColor = Color.LightPink;
                btn6.BackColor = Color.LightPink;
            }
            if ((btn7.Text == "X") && (btn8.Text == "X") && (btn9.Text == "X"))
            {
                btn7.BackColor = Color.LightGreen;
                btn8.BackColor = Color.LightGreen;
                btn9.BackColor = Color.LightGreen;
            }
            if ((btn7.Text == "O") && (btn8.Text == "O") && (btn9.Text == "O"))
            {
                btn7.BackColor = Color.LightPink;
                btn8.BackColor = Color.LightPink;
                btn9.BackColor = Color.LightPink;
            }
            if ((btn1.Text == "X") && (btn4.Text == "X") && (btn7.Text == "X"))
            {
                btn1.BackColor = Color.LightGreen;
                btn4.BackColor = Color.LightGreen;
                btn7.BackColor = Color.LightGreen;
            }
            if ((btn1.Text == "O") && (btn4.Text == "O") && (btn7.Text == "O"))
            {
                btn1.BackColor = Color.LightPink;
                btn4.BackColor = Color.LightPink;
                btn7.BackColor = Color.LightPink;
            }
            if ((btn2.Text == "X") && (btn5.Text == "X") && (btn8.Text == "X"))
            {
                btn2.BackColor = Color.LightGreen;
                btn5.BackColor = Color.LightGreen;
                btn8.BackColor = Color.LightGreen;
            }
            if ((btn2.Text == "O") && (btn5.Text == "O") && (btn8.Text == "O"))
            {
                btn2.BackColor = Color.LightPink;
                btn5.BackColor = Color.LightPink;
                btn8.BackColor = Color.LightPink;
            }
            if ((btn3.Text == "X") && (btn6.Text == "X") && (btn9.Text == "X"))
            {
                btn3.BackColor = Color.LightGreen;
                btn6.BackColor = Color.LightGreen;
                btn9.BackColor = Color.LightGreen;
            }
            if ((btn3.Text == "O") && (btn6.Text == "O") && (btn9.Text == "O"))
            {
                btn3.BackColor = Color.LightPink;
                btn6.BackColor = Color.LightPink;
                btn9.BackColor = Color.LightPink;
            }
            if ((btn1.Text == "X") && (btn5.Text == "X") && (btn9.Text == "X"))
            {
                btn3.BackColor = Color.LightGreen;
                btn6.BackColor = Color.LightGreen;
                btn9.BackColor = Color.LightGreen;
            }
            if ((btn1.Text == "O") && (btn5.Text == "O") && (btn9.Text == "O"))
            {
                btn3.BackColor = Color.LightPink;
                btn6.BackColor = Color.LightPink;
                btn9.BackColor = Color.LightPink;
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
        }
    }
}
