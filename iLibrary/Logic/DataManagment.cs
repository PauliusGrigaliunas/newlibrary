using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLibrary.Logic
{
    class DataManagment
    {

        public void FillData(User user)
        {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                Vartotojas vartotojas = new Vartotojas()
                {
                    Id = NewIdForVartotojai(),
                    Prisijungimo_vardas = user.Username,
                    Slaptazodis = user.Password,
                    DarbSkait = user.DarbSkait,
                    Vardas = user.Name,
                    Telefono_numeris = user.Phone,
                    Adresas = user.Address,
                    Pasto_Kodas = user.Code
                };
                contex.Vartotojas.Add(vartotojas);
                contex.SaveChanges();
            }
        }
        private int NewIdForVartotojai()
        {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                List<int> idList = contex.Vartotojas.Select(x => x.Id).ToList();

                return idList.Last() + 1;
            }
        }
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
    }
}
