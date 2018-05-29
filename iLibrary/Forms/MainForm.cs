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
            Logic.Login login = new Logic.Login();
            int typeOfUser = rb_skaitytojas.Checked ? 0 : 1;
            var exists = login.LogMeIn(textBox1.Text, textBox2.Text, typeOfUser);
            //Ideally in this place we would like to load a new form :)
            if (exists)
            {
                // successful login
                MessageBox.Show(exists.ToString() + " " + typeOfUser);
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

        private void rb_skaitytojas_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_skaitytojas.Checked == true) rb_darbuotojas.Checked = false;
            else rb_darbuotojas.Checked = true;
        }

        private void rb_darbuotojas_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_darbuotojas.Checked == true) rb_skaitytojas.Checked = false;
            else rb_skaitytojas.Checked = true;

        }
    }
}
