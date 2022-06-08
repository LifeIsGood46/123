using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] symbols = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "=", "~", "`", "|", "\\", ";", ":", "'", "\"", ",", ".", "/", "<", ">", "?", " " };
            string[] all = letters.Concat(numbers).Concat(symbols).ToArray();
            string captcha = "";
            for (int i = 0; i < 6; i++)
            {
                captcha += all[rnd.Next(0, all.Length)];
            }
            label3.Text = captcha;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if input is same as captcha
            if (textBox1.Text == label3.Text)
            {
                // close window
                this.Close();
            }
            else
            {
                //generate new captcha
                label3_Click(sender, e);
            }
        }
    }
}
