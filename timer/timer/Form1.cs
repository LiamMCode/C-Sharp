using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            lbl4.Text = "" + (Convert.ToInt16(lbl4.Text) + 1); 

            if (lbl4.Text == "10")
            {
                lbl4.Text = "0";
                lbl3.Text = "" + (Convert.ToInt16(lbl3.Text) + 1);
            }
            if (lbl3.Text == "10")
            {
                lbl3.Text = "0";
                lbl2.Text = "" + (Convert.ToInt16(lbl2.Text) + 1); 
            }
            if (lbl2.Text == "10")
            {
                lbl2.Text = "0";
                lbl1.Text = "" + (Convert.ToInt16(lbl1.Text) + 1);
            }
            if (lbl4.Text == "0")
            {
                img22.Visible = true;
                img23.Visible = true;
                img24.Visible = true;
                img25.Visible = true;
                img26.Visible = true;
                img27.Visible = true;
                img28.Visible = true;
            }
            if (lbl4.Text == "1")
            {
                img22.Visible = false;
                img23.Visible = false;
                img24.Visible = false;
                img25.Visible = true;
                img26.Visible = true;
                img27.Visible = false;
                img28.Visible = false;
            }
            if (lbl4.Text == "2")
            {
                img22.Visible = true;
                img23.Visible = true;
                img24.Visible = true;
                img25.Visible = false;
                img26.Visible = true;
                img27.Visible = false;
                img28.Visible = true;
            }
            if (lbl4.Text == "3")
            {
                img22.Visible = true;
                img23.Visible = true;
                img24.Visible = true;
                img25.Visible = true;
                img26.Visible = true;
                img27.Visible = false;
                img28.Visible = false;
            }
            if (lbl4.Text == "4")
            {
                img22.Visible = false;
                img23.Visible = true;
                img24.Visible = false;
                img25.Visible = true;
                img26.Visible = true;
                img27.Visible = true;
                img28.Visible = false;
            }
            if (lbl4.Text == "5")
            {
                img22.Visible = true;
                img23.Visible = true;
                img24.Visible = true;
                img25.Visible = true;
                img26.Visible = false;
                img27.Visible = true;
                img28.Visible = false;
            }
        }
    }
}
