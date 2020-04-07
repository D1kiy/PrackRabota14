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
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelloForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите закрыть форму?",
                "Закрыть",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Form form = new Calc();
            form.Show();
        }
        int Count = 0;
        private void DialogButton_Click(object sender, EventArgs e)
        {
            Count++;
            Form form = new NextForm(Count);
            form.ShowDialog();
        }

        private void NoDialogButton_Click(object sender, EventArgs e)
        {
            Count++;
            Form form = new NextForm(Count);
            form.Show();
        }
    }
}
