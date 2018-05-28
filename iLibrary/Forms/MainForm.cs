using iLibrary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) textBox2.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) LoginBtn.PerformClick();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            MessageBox.Show(textBox2.Text);
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }
    }
}
