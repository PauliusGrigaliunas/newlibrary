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

namespace iLibrary.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) textBox2.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) textBox3.Focus();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) textBox4.Focus();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) textBox5.Focus();
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) textBox6.Focus();
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) textBox7.Focus();
        }
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) RegistrationBtn.PerformClick();
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();

                user.DarbSkait = ((employeeButton.Checked) ? 1 : 0);
                user.Username = (!(textBox1.Text == "") ? textBox1.Text : null);
                user.Password = ((!(textBox2.Text == "") && textBox2.Text == textBox3.Text) ? textBox2.Text : null);

                if (user.Username == null) MessageBox.Show("neįvestas 'Prisijungimo vardas'");
                else if (user.Password == null) MessageBox.Show("Blogai įvestas 'Slaptažodis'");
                else
                {
                    user.Name =  (!(textBox4.Text == "") ? textBox4.Text : null);
                    user.Phone = (!(textBox5.Text == "") ? Int32.Parse(textBox5.Text) : (int?)null);
                    user.Address = (!(textBox6.Text == "") ? textBox6.Text : null);
                    user.Code =  (!(textBox7.Text == "") ? Int32.Parse(textBox7.Text) : (int?)null);

                    user.FillData();
                    Form form = FormManager.ClientOrEmployee(user.DarbSkait);
                    form.ShowDialog();
                }

            }
            catch (ArgumentException)
            {
                MessageBox.Show("blogi duomenys!");
            }
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
