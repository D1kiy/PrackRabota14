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
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        public NextForm(int s) : this()
        {
            this.Text = Convert.ToString(s);
            this.CancelButton = Exit;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                DialogResult result = MessageBox.Show(
                    "Введите имя! ",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Здравствуйте, " + textBox1.Text,
                    "Приветствие!");
            }
        }
    }
}
