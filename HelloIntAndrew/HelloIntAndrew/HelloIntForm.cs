/*
 * Created by: Andrew 
 * Created on: 2020-02-11
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Name of Program
 * This program displays 4 radio buttons and when the user click on each radion button 
 * the greeting change according to the language of the radio button
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

namespace HelloIntAndrew
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to French
            this.lblGreeting.Text = "Bonjour, le Monde!";
        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Spanish
            this.lblGreeting.Text = "Hola, Mundo!";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to English
            this.lblGreeting.Text = "Hello, World!";
        }

        private void RadGerman_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to German
            this.lblGreeting.Text = "Hallo, Welt!";
        }
    }
}
