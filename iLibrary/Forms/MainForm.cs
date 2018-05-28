using iLibrary.Forms;
using iLibrary.Logic;
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
        User user = new User();
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
            user.DarbSkait = rb_skaitytojas.Checked ? 0 : 1;
            user.Username = textBox1.Text;
            user.Password = textBox2.Text;
            var exists = user.LogMeIn();

            if (exists)
            {
                Form form = FormManager.ClientOrEmployee(user.DarbSkait);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nekorektiski prisijungimo duomenys, bandykite dar karta");
            }
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }
    }
}
