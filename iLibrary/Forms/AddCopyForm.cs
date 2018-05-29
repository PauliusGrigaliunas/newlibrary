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
    public partial class AddCopyForm : Form
    {
        public AddCopyForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Copy c = new Copy();
            try
            {
                c.Id = int.Parse(idBox.Text);
                c.Isbn = int.Parse(isbnBox.Text);
                DataManagment dm = new DataManagment();
                c.Skaitytojas = null;
                c.GrazinimoLaikas = null;
                if (dm.CheckIfExistIsbn(c.Isbn) == true) { dm.FillData(c); MessageBox.Show("Sekmingai prideta"); }
                else MessageBox.Show("Tokios knygos nera");
            }
            catch (Exception)
            {
                MessageBox.Show("Neteisingai ivesti duomenys arba toks id jau egzistuoja");
            }
            Close();
        }
    }
}
