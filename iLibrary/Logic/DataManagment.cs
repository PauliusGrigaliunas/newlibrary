using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLibrary.Logic
{
    public class DataManagment
    {


        public void GetAllBooks(List<Book> books)
        {
            IQueryable<Knygos> knygos;
            using (var contex = new LibraryDataEntities())
            {
                knygos = contex.Knygos.Where(r => r.Isbn > 0);
                foreach (var knyga in knygos)
                {
                    Book book = new Book();
                    book.Isbn = knyga.Isbn;
                    book.Pavadinimas = knyga.Pavadinimas;
                    book.Autorius = knyga.Autorius;
                    book.Leidykla = knyga.Leidykla;
                    book.Metai = knyga.Metai;
                    books.Add(book);
                }
            }
        }
        public void GetAllCopies(List<Copy> copies)
        {
            IQueryable<Egzemplioriu> egzemplioriai;
            using (var contex = new LibraryDataEntities())
            {
                egzemplioriai = contex.Egzempliorius.Where(r => r.Id > 0);
                foreach (var egz in egzemplioriai)
                {
                    Copy c = new Copy();
                    c.Isbn = egz.Isbn;
                    c.Id = egz.Id;
                    c.Skaitytojas = egz.Skaitytojas;
                    c.GrazinimoLaikas = egz.Gražinimo_laikas;
                    copies.Add(c);
                }
            }
        }
        public List<BooksWithCopies> GetBooksWithCopies(List<Copy> copies, List<Book> books)
        {
            List<BooksWithCopies> bwc = new List<BooksWithCopies>();
            var q =
                    from c in copies
                    join b in books on c.Isbn equals b.Isbn into ps
                    from b in ps.DefaultIfEmpty()
                    select new { Isbn = c.Isbn, Id = c.Id, Pavadinimas = b.Pavadinimas, Autorius = b.Autorius, Skaitytojas = c.Skaitytojas, GrazinimoLaikas = c.GrazinimoLaikas };
            foreach (var element in q)
            {
                BooksWithCopies temp = new BooksWithCopies();
                temp.Isbn = element.Isbn;
                temp.Id = element.Id;
                temp.Pavadinimas = element.Pavadinimas;
                temp.Autorius = element.Autorius;
                temp.Skaitytojas = element.Skaitytojas;
                temp.GrazinimoLaikas = element.GrazinimoLaikas;
                bwc.Add(temp);
            }
            return bwc;
        }
    }
}
