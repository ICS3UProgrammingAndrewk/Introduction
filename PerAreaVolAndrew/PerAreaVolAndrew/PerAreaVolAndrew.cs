/*
 * Created by: Andew kuekam
 * Created on: 2020-02-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - PerAreaVolAndrew
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolAndrew
{
    public partial class PerAreaVolAndrew : Form
    {
        public PerAreaVolAndrew()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) 
        {
            // This calculate the perimeter of a trangle
            this.lblPer.Text = Convert.ToString(8 * 2 + 8 * 2) + "cm";
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            // This calculate the Area of a Circle
            this.lblArea.Text = Convert.ToString(3.14 * Math.Pow(6, 2)) + "cm";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // This calculate the Volume of a shere
            this.lblVol.Text = Convert.ToString((double)4.0/(double)3.0 * Math.PI * Math.Pow (20, 3)) + "m";
        }

        private void PerAreaVolAndrew_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this close
            this.Close();
        }
    }
}
