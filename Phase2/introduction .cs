using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class introduction : Form
    {
        private colorView colorView = new colorView(); 
        //ディスプレイの高さ
        private int displayHeight = Screen.PrimaryScreen.Bounds.Height;
        //ディスプレイの幅
        private int displayWidh = Screen.PrimaryScreen.Bounds.Width;
        public introduction()
        {
            InitializeComponent();
            LengthBar.Maximum = displayWidh;
            heightBar.Maximum = displayHeight;
        }
        private void movebar_Scroll(object sender, EventArgs e)
        {
            lblmoveValue.Text = movebar.Value.ToString();
        }

        private void LengthBar_Scroll(object sender, EventArgs e)
        {
            lblLength.Text = LengthBar.Value.ToString();
            colorView.Width = LengthBar.Value;
        }

        private void heightBar_Scroll(object sender, EventArgs e)
        {
            lbllheight.Text = heightBar .Value.ToString();
            colorView.Height  = heightBar.Value;
        }

        private void colorBar_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = rBar.Value.ToString();
            lblGreen.Text = gBar.Value.ToString();
            lblGreen.Text = bBar.Value.ToString();
            colorView.BackColor = Color.FromArgb(rBar.Value, gBar.Value, bBar.Value);
        }

        private void VisibleWindow_CheckedChanged(object sender, EventArgs e)
        {
            colorView.Visible = VisibleWindow.Checked;
            //if (VisibleWindow.Checked)
            //{
                
            //    colorView.Show(); 

            //}
            //else
            //{
            //    colorView.Hide();

            //}
        }

        private void buttonRigtt_Click(object sender, EventArgs e)
        {
            colorView.Left += movebar.Value;
            colorView.Location = new Point(colorView.Left+ movebar.Value, colorView.Top); 
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            colorView.Top -= movebar.Value;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            colorView.Left -= movebar.Value;
        }

        private void buttonDownn_Click(object sender, EventArgs e)
        {
            colorView.Top += movebar.Value;
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            colorView.Top = (displayHeight / 2) - (colorView.Height / 2);
            colorView.Left = (displayWidh / 2) - (colorView.Width /   2); 
        }

    }
}
