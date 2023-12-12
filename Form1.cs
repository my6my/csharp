using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mygrading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double mark1, mark2, mark3, mark4, mark5, mark6, mark7, mark8, mark9, mark10, mark11, mark12, tot,pec;

            mark1 = int.Parse(textBox1.Text);
            mark2 = int.Parse(textBox2.Text);
            mark3 = int.Parse(textBox3.Text);
            mark4 = int.Parse(textBox4.Text);
            mark5 = int.Parse(textBox5.Text);
            mark6 = int.Parse(textBox6.Text);
            mark7 = int.Parse(textBox7.Text);
            mark8 = int.Parse(textBox8.Text);
            mark9 = int.Parse(textBox9.Text);
            mark10 = int.Parse(textBox10.Text);
            mark11 = int.Parse(textBox11.Text);
            mark12 = int.Parse(textBox12.Text);


            tot = mark1 + mark2 + mark8 + mark6 + mark9 + mark3 + mark4 + mark10 + mark11 + mark5 + mark7 + mark12;

            pec = tot / 12.0f;


            int someInt = (int)pec;


            if (someInt <= 35)
            {
                textBox13.Text = "Failed";
            }
            else if (someInt >= 34 && someInt <= 39)
            {
                textBox13.Text = "Failed";
            }
            else if (someInt >= 40 && someInt <= 59)
            {
                textBox13.Text = "Failed";
            }
            else if (someInt >= 60 && someInt <= 69)
            {
                textBox13.Text = "Failed";
            }
            else if (someInt >= 70 && someInt <= 79)
            {
                textBox13.Text = "Passed";
            }
            else if (someInt >= 80 && someInt <= 90)
            {
                textBox13.Text = "Passed";
            }
            else if (someInt >= 91)
            {
                textBox13.Text = "Passed";
            }


            //string str = Convert.ToString(someInt);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






