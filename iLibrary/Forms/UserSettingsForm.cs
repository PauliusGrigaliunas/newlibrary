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
    public partial class UserSettingsForm : Form
    {
        List<Copy> copies;
        List<Book> books;
        List<BooksWithCopies> ownedBooks;
        List<BooksWithCopies> allBooks;
        DataManagment dm;
        int skaitytojas;
        public UserSettingsForm(int skaitytojas, MainForm mf)
        {
            mf.Hide();
            this.skaitytojas = skaitytojas;
            InitializeComponent();
            AllBooksListView.View = View.Details;
            ownedBooksListView.View = View.Details;
            JoinTables();
            ShowInfoAllBooks();
            ShowOwnedInfo();
        }
        public void JoinTables()
        {
            copies = new List<Copy>();
            books = new List<Book>();
            dm = new DataManagment();
            dm.GetAllCopies(copies);                       //Visi egzemplioriai surasomi y List copies is duombazes
            dm.GetAllBooks(books);                         //Visos knygos surasomos y List books is duombazes
            allBooks = dm.GetBooksWithCopies(copies, books);      //Left outer joinas, sujungia tuos du listus ir gaunamas listas, kurio tipas auksciau ivardinta structura   
        }
        public void ShowInfoAllBooks()
        {
            AllBooksListView.Items.Clear();
            foreach (var elem in allBooks)
            {
                ListViewItem item = new ListViewItem(elem.Isbn.ToString());
                item.SubItems.Add(elem.Id.ToString());
                item.SubItems.Add(elem.Pavadinimas.ToString());
                item.SubItems.Add(elem.Autorius.ToString());
                item.SubItems.Add(elem.Skaitytojas.ToString());
                item.SubItems.Add(elem.GrazinimoLaikas.ToString());

                AllBooksListView.Items.Add(item);
            }
        }
        public void ShowOwnedInfo()
        {
            ownedBooksListView.Items.Clear();
            ownedBooks = allBooks.Where(s => s.Skaitytojas == skaitytojas).ToList();
            foreach (var elem in ownedBooks)
            {
                ListViewItem item = new ListViewItem(elem.Isbn.ToString());
                item.SubItems.Add(elem.Id.ToString());
                item.SubItems.Add(elem.Pavadinimas.ToString());
                item.SubItems.Add(elem.Autorius.ToString());
                item.SubItems.Add(elem.Skaitytojas.ToString());
                item.SubItems.Add(elem.GrazinimoLaikas.ToString());

                ownedBooksListView.Items.Add(item);
            }
        }

        private void takeBookButton_Click(object sender, EventArgs e)
        {
            string idString;
            string isbnString;
            if (AllBooksListView.SelectedItems.Count > 0)
            {
                idString = AllBooksListView.SelectedItems[0].SubItems[1].Text;
                isbnString = AllBooksListView.SelectedItems[0].Text;
            }
            else { idString = null; isbnString = null; }

            DataManagment dm = new DataManagment();
            int id = Convert.ToInt32(idString);
            int isbn = Convert.ToInt32(isbnString);
            if (dm.CheckIfNotTaken(isbn, id) == false)
            {
                if (idString == null)
                {
                    MessageBox.Show("Pasirinkite knygą iš aukščiau esančiu");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ar tikrai norite pasiimti knygą, kurios ID: " + idString + "?", "Tikslinimas", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dm.TakeBook(isbn, id, skaitytojas);
                        MessageBox.Show("Sėkmingai paimta!");
                        JoinTables();
                        ShowInfoAllBooks();
                        ShowOwnedInfo();
                    }
                }
            }
            else
                MessageBox.Show("Atsiprašome, bet ši knyga jau paimta");

        }

        private void UserSettingsForm_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void UserSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /*       private void returnBookButton_Click(object sender, EventArgs e)
               {
                   string isbnString;
                   string idString;
                   if (ownedBooksListView.SelectedItems.Count > 0)
                   {
                       isbnString = ownedBooksListView.SelectedItems[0].Text;
                       idString = ownedBooksListView.SelectedItems[0].SubItems[1].Text; ;
                   }
                   else { isbnString = null; idString = null; }

                   if (idString == null)
                   {
                       MessageBox.Show("Pasirinkite knygą iš aukščiau esančiu");
                   }
                   else
                   {
                       DialogResult dialogResult = MessageBox.Show("Ar tikrai norite gražinti knygą, kurios ID: " + idString + "?", "Tikslinimas", MessageBoxButtons.YesNo);
                       if (dialogResult == DialogResult.Yes)
                       {
                           int id = Convert.ToInt32(idString);
                           int isbn = Convert.ToInt32(isbnString);
                           dm.ReturnBook(isbn, id);
                           MessageBox.Show("Sėkmingai gražinta!");
                           JoinTables();
                           ShowOwnedInfo();
                           ShowInfoAllBooks();
                       }
                   }

               }*/
    }
}
