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
    public struct BooksWithCopies
    {
        public int Isbn { get; set; }
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int? Skaitytojas { get; set; }
        public DateTime? GrazinimoLaikas { get; set; }
    };
    public partial class EmployeeForm : Form
    {
        List<Copy> copies;
        List<Book> books;
        List<BooksWithCopies> bwc;
        DataManagment dm;

        public EmployeeForm(MainForm mf)
        {
            mf.Hide();
            InitializeComponent();
            bwcListView.View = View.Details;
            JoinTables();
            ShowInfo();
        }
        public void JoinTables()
        {
            copies = new List<Copy>();
            books = new List<Book>();
            dm = new DataManagment();
            dm.GetAllCopies(copies);                       //Visi egzemplioriai surasomi y List copies is duombazes
            dm.GetAllBooks(books);                         //Visos knygos surasomos y List books is duombazes
            bwc = dm.GetBooksWithCopies(copies, books);      //Left outer joinas, sujungia tuos du listus ir gaunamas listas, kurio tipas auksciau ivardinta structura   
        }
        public void ShowInfo()
        {
            bwcListView.Items.Clear();
            foreach (var elem in bwc)
            {
                ListViewItem item = new ListViewItem(elem.Isbn.ToString());
                item.SubItems.Add(elem.Id.ToString());
                item.SubItems.Add(elem.Pavadinimas.ToString());
                item.SubItems.Add(elem.Autorius.ToString());
                item.SubItems.Add(elem.Skaitytojas.ToString());
                item.SubItems.Add(elem.GrazinimoLaikas.ToString());

                bwcListView.Items.Add(item);
            }
        }
        private void addBook_Click(object sender, EventArgs e)
        {
            AddBookForm abf = new AddBookForm();
            abf.ShowDialog();
            JoinTables();
            ShowInfo();
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            DeleteBookForm dbf = new DeleteBookForm();
            dbf.ShowDialog();
            JoinTables();
            ShowInfo();
        }

        private void addUnitButton_Click(object sender, EventArgs e)
        {
            AddCopyForm acf = new AddCopyForm();
            acf.ShowDialog();
            JoinTables();
            ShowInfo();
        }

        private void deleteUnitButton_Click(object sender, EventArgs e)
        {
            string idString;
            if (bwcListView.SelectedItems.Count > 0)
            {
                idString = bwcListView.SelectedItems[0].SubItems[1].Text;
            }
            else idString = null;

            if (idString == null)
            {
                MessageBox.Show("Pasirinkite egzemplioriu is zemiau esanciu");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ar tikrai norite pašalinti egzempliorių, kurio ID: " + idString + "?", "Šalinimo įspėjimas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(idString);
                    DataManagment dm = new DataManagment();
                    dm.DeleteCopy(id);
                    MessageBox.Show("Sekmingai pašalinta!");
                    JoinTables();
                    ShowInfo();
                }
            }
            
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            string isbnString;
            string idString;
            if (bwcListView.SelectedItems.Count > 0)
            {
                isbnString = bwcListView.SelectedItems[0].Text;
                idString = bwcListView.SelectedItems[0].SubItems[1].Text; ;
            }
            else { isbnString = null; idString = null; }

            if (idString == null)
            {
                MessageBox.Show("Pasirinkite knygą iš žemiau esančiu");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ar tikrai norite atlaisvinti knygą, kurios ID: " + idString + "?", "Tikslinimas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(idString);
                    int isbn = Convert.ToInt32(isbnString);
                    dm.ReturnBook(isbn, id);
                    MessageBox.Show("Sėkmingai gražinta!");
                    JoinTables();
                    ShowInfo();
                }
            }

        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
