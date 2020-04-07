using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticheskayaRabota14
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            double a, b;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "Введите 1-е число";
                }
                else if (textBox2.Text == "")
                {
                    label2.Text = "Введите 2-е число";
                }
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                label1.Text = "1 число";
                label2.Text = "2 число";
                textBox3.Text = Convert.ToString(a + b);
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double a, b;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "Введите 1-е число";
                }
                else if (textBox2.Text == "")
                {
                    label2.Text = "Введите 2-е число";
                }
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                label1.Text = "1 число";
                label2.Text = "2 число";
                textBox3.Text = Convert.ToString(a - b);
            }
        }

        private void Umnohenie_Click(object sender, EventArgs e)
        {
            double a, b;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "Введите 1-е число";
                }
                else if (textBox2.Text == "")
                {
                    label2.Text = "Введите 2-е число";
                }
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                label1.Text = "1 число";
                label2.Text = "2 число";
                textBox3.Text = Convert.ToString(a * b);
            }
        }

        private void Deienie_Click(object sender, EventArgs e)
        {
            double a, b;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "Введите 1-е число";
                }
                else if (textBox2.Text == "")
                {
                    label2.Text = "Введите 2-е число";
                }
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                label1.Text = "1 число";
                label2.Text = "2 число";
                textBox3.Text = Convert.ToString(a / b);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
