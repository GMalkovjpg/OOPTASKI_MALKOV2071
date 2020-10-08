using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (label1.Text)
            {
                case "+" :
                    int ch1 = Convert.ToInt32(textBox1.Text);
                    int zn1 = Convert.ToInt32(textBox2.Text);
                    int ch2 = Convert.ToInt32(textBox3.Text);
                    int zn2 = Convert.ToInt32(textBox4.Text);
                    Rational c = new Rational(ch1, zn1);
                    Rational z = new Rational(ch2, zn2);
                    Rational itog = c + z;
                    textBox5.Text = Convert.ToString(itog.numer);
                    textBox6.Text = Convert.ToString(itog.denumer);


                    break;
                case "-":
                     ch1 = Convert.ToInt32(textBox1.Text);
                     zn1 = Convert.ToInt32(textBox2.Text);
                     ch2 = Convert.ToInt32(textBox3.Text);
                     zn2 = Convert.ToInt32(textBox4.Text);
                     c = new Rational(ch1, zn1);
                     z = new Rational(ch2, zn2);
                     itog = c - z;
                    textBox5.Text = Convert.ToString(itog.numer);
                    textBox6.Text = Convert.ToString(itog.denumer);

                    break;
                case "*":
                     ch1 = Convert.ToInt32(textBox1.Text);
                     zn1 = Convert.ToInt32(textBox2.Text);
                     ch2 = Convert.ToInt32(textBox3.Text);
                     zn2 = Convert.ToInt32(textBox4.Text);
                     c = new Rational(ch1, zn1);
                     z = new Rational(ch2, zn2);
                     itog = c * z;
                    textBox5.Text = Convert.ToString(itog.numer);
                    textBox6.Text = Convert.ToString(itog.denumer);

                    break;
                case "/":
                     ch1 = Convert.ToInt32(textBox1.Text);
                     zn1 = Convert.ToInt32(textBox2.Text);
                     ch2 = Convert.ToInt32(textBox3.Text);
                     zn2 = Convert.ToInt32(textBox4.Text);
                     c = new Rational(ch1, zn1);
                     z = new Rational(ch2, zn2);
                     itog = c / z;
                    textBox5.Text = Convert.ToString(itog.numer);
                    textBox6.Text = Convert.ToString(itog.denumer);

                    break;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
