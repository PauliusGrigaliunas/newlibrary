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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string isbnString;
            if (deleteBox.Text == null)
            {
                MessageBox.Show("Neįvestas ISBN");
            }
            else
            {
                isbnString = deleteBox.Text;
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Ar tikrai norite pašalinti egzempliorių, kurio ISBN: " + isbnString + "?", "Šalinimo įspėjimas", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int isbn = Convert.ToInt32(isbnString);
                        DataManagment dm = new DataManagment();
                        //dm.DeleteCopy(id);
                        MessageBox.Show("Sekmingai pašalinta!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ISBN turi buti skaičiaus pavidalo");
                }
            }
        }
    }
}
