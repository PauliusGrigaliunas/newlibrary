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
        User user;
        DataManagment dm;
        public EmployeeForm(User user)
        {
            InitializeComponent();
            this.user = user;
            bwcListView.View = View.Details;
            JoinTables();
            ShowInfo();
        }

        private void knygosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knygosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataDataSet);

        }

        public void JoinTables()
        {
            copies = new List<Copy>();
            books = new List<Book>();
            dm = new DataManagment();
            dm.GetAllCopies(copies);                       //Visi egzemplioriai surasomi y List copies is duombazes
            dm.GetAllBooks(books);                         //Visos knygos surasomos y List books is duombazes
            bwc = dm.GetBooksWithCopies(copies, books);     //Left outer joinas, sujungia tuos du listus ir gaunamas listas, kurio tipas auksciau ivardinta structura   
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

    }
}
