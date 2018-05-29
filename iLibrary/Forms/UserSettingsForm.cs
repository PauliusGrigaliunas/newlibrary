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
        List<BooksWithCopies> allBooks;
        DataManagment dm;
        public UserSettingsForm()
        {
            InitializeComponent();
            AllBooksListView.View = View.Details;
            ownedBooksListView.View = View.Details;
            JoinTables();
            ShowInfoAllBooks();
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
                        dm.TakeBook(isbn, id, 9);
                        MessageBox.Show("Sėkmingai paimta!");
                        JoinTables();
                        ShowInfoAllBooks();
                    }
                }
            }
            else
                MessageBox.Show("Atsiprašome, bet ši knyga jau paimta");

        }
    }
}
