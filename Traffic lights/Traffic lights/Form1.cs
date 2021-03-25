using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traffic_lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greenlight_Click(object sender, EventArgs e)
        {

        }

        private void tmrTraffic_Tick(object sender, EventArgs e)
        {
            lbl1.Text = "" + (Convert.ToInt16(lbl1.Text) + 1);
            
            if (lbl1.Text == "13")
            {
                lbl1.Text = "1";
            }

            if (lbl1.Text == "1")
            {
                redlight.Visible = true;
                amberlight.Visible = false;
                greenlight.Visible = false; 
            }

            if (lbl1.Text == "6")
            {
                redlight.Visible = true;
                amberlight.Visible = true;
                greenlight.Visible = false;
            }

            if (lbl1.Text == "7")
            {
                redlight.Visible = false;
                amberlight.Visible = false;
                greenlight.Visible = true;
            }

            if (lbl1.Text == "12")
            {
                redlight.Visible = false;
                amberlight.Visible = true;
                greenlight.Visible = false;
            }
        }

        private void tmrcar_Tick(object sender, EventArgs e)
        {
            if (redlight.Visible == false)
            {
                imgcar.Left = imgcar.Left + 2;
            }    
            
            if (imgcar.Left > 800)
            {
                imgcar.Left = -150;
            }

        }
    }
}
