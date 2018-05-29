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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void commentLabel_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Book knyga = new Book();
            try
            {
                knyga.Pavadinimas = nameBox.Text;
                knyga.Autorius = authorBox.Text;
                knyga.Isbn = int.Parse(unitBox.Text);
                knyga.Leidykla = publisherBox.Text;
                knyga.Metai = null;
                DataManagment dm = new DataManagment();
                dm.FillData(knyga);
                MessageBox.Show("Prideta sekmingai");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Neteisingai ivesti duomenys");
            }

        }
    }
}
