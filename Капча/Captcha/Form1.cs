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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get input from textBox1 and textBox2 
            string login = textBox1.Text;
            string password = textBox2.Text;
            // compare input to login and password
            if (login == "qwerty" && password == "qwerty")
            {
                // create new form
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Login or password are incorrect");
                //create a new window 
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
