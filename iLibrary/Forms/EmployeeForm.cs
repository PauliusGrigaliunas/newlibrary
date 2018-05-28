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
        public EmployeeForm()
        {
            copies = new List<Copy>();
            books = new List<Book>();
            dm = new DataManagment();
            dm.GetAllCopies(copies);
            dm.GetAllBooks(books);
            bwc = dm.GetBooksWithCopies(copies, books);
            InitializeComponent();
            foreach (var element in bwc)
            {
                testLabel.Text += element.Isbn.ToString() + " " + element.Id.ToString() + " " + element.Pavadinimas.ToString() + " " + element.Autorius.ToString() + " " + element.Skaitytojas.ToString() + " " + element.GrazinimoLaikas.ToString() + "\n";
            }
        }
    }
}
