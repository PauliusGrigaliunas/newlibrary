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
        public void FillData(Book book)
        {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                Knygos knyga = new Knygos()
                {
                    Pavadinimas = book.Pavadinimas,
                    Autorius = book.Autorius,
                    Isbn = book.Isbn,
                    Leidykla = book.Leidykla,
                    Metai = book.Metai                   
                };
                Egzemplioriu egz = new Egzemplioriu()
                {
                    Isbn = book.Isbn,
                    Id = NewIdForEgzemplioriai(),
                    Skaitytojas = null,
                    Gražinimo_laikas = null
                };
                contex.Knygos.Add(knyga);
                contex.Egzempliorius.Add(egz);
                contex.SaveChanges();
            }
        }
        public void FillData(Copy copy)
        {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                Egzemplioriu egz = new Egzemplioriu()
                {
                    Id = copy.Id,
                    Skaitytojas = copy.Skaitytojas,
                    Isbn = copy.Isbn,
                    Gražinimo_laikas = copy.GrazinimoLaikas
                };
                contex.Egzempliorius.Add(egz);
                contex.SaveChanges();
            }
        }
        private int NewIdForEgzemplioriai()
        {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                List<int> idList = contex.Egzempliorius.Select(x => x.Id).ToList();

                return idList.Max() + 1;
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
        public List<BooksWithCopies> GetBooksWithCopies(List<Copy> copies, List<Book> books)
        {
            List<BooksWithCopies> bwc = new List<BooksWithCopies>();
            var q =
                    from c in copies
                    join b in books on c.Isbn equals b.Isbn into ps
                    from b in ps.DefaultIfEmpty()
                    select new { Isbn = c.Isbn, Id = c.Id, Pavadinimas = b.Pavadinimas, Autorius = b.Autorius, Skaitytojas = c.Skaitytojas, GrazinimoLaikas = c.GrazinimoLaikas};
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
        public bool CheckIfExistIsbn(int isbn)
        {
            bool isExist = false;
            IQueryable<Egzemplioriu> egzemplioriai;
            using (var contex = new LibraryDataEntities())
            {
                egzemplioriai = contex.Egzempliorius.Where(r => r.Id > 0);
                foreach (var egz in egzemplioriai)
                {
                    if (egz.Isbn == isbn)
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }
        public void DeleteCopy(int Id)
        {
            IQueryable<Egzemplioriu> egzemplioriai;
            Egzemplioriu delete = null;
            using (var contex = new LibraryDataEntities())
            {
                egzemplioriai = contex.Egzempliorius.Where(r => r.Id > 0);
                foreach (var egz in egzemplioriai)
                {
                    if (egz.Id == Id)
                    {
                        delete = egz;
                    }
                }
                if (delete != null)
                {
                    contex.Egzempliorius.Remove(delete);
                    contex.SaveChanges();
                    egzemplioriai = contex.Egzempliorius.Where(i => i.Isbn == delete.Isbn);
                    if (egzemplioriai.Count() == 0)
                    {
                        DeleteBook(delete.Isbn);
                    }
                }               
            }
        }
        public void DeleteBook(int isbn)
        {
            IQueryable<Egzemplioriu> egzemplioriai;
            Egzemplioriu delete = null;
            Knygos knygaDelete = null;
            using (var contex = new LibraryDataEntities())
            {
                egzemplioriai = contex.Egzempliorius.Where(r => r.Id > 0);
                foreach (var egz in egzemplioriai)
                {
                    if (egz.Isbn == isbn)
                    {
                        delete = egz;
                        if (delete != null)
                        {
                            contex.Egzempliorius.Remove(delete);
                        }
                    }
                }
                knygaDelete = contex.Knygos.Where(k => k.Isbn == isbn).SingleOrDefault();
                if (knygaDelete != null )
                {
                    contex.Knygos.Remove(knygaDelete);
                }
                contex.SaveChanges();
            }
        }
        public void DeleteAllCopies(int isbn)
        {
            IQueryable<Egzemplioriu> egzemplioriai;
            Egzemplioriu delete = null;
            using (var contex = new LibraryDataEntities())
            {
                egzemplioriai = contex.Egzempliorius.Where(r => r.Id > 0);
                foreach (var egz in egzemplioriai)
                {
                    if (egz.Isbn == isbn)
                    {
                        delete = egz;
                        contex.Egzempliorius.Remove(delete);
                    }
                }
                contex.SaveChanges();
            }
        }
        public void TakeBook(int isbn, int id, int skaitytojas)
        {
            using (var contex = new LibraryDataEntities())
            {
                var egzemplioriai = contex.Egzempliorius.
                    SingleOrDefault(r => r.Id == id && r.Isbn == isbn);
                if (egzemplioriai != null)
                {
                    egzemplioriai.Skaitytojas = skaitytojas;
                }
                contex.SaveChanges();
            }
        }
        public bool CheckIfNotTaken(int isbn, int id)
        {
            bool isTaken = false;
            IQueryable<Egzemplioriu> egzemplioriai;
            using (var contex = new LibraryDataEntities())
            {
                egzemplioriai = contex.Egzempliorius.Where(r => r.Id > 0);
                foreach (var egz in egzemplioriai)
                {
                    if (egz.Isbn == isbn && egz.Id == id && egz.Skaitytojas >= 1)
                    {
                        isTaken = true;
                    }
                }
            }
            return isTaken;
        }
        public void ReturnBook(int isbn, int id)
        {
            using (var contex = new LibraryDataEntities())
            {
                var egzemplioriai = contex.Egzempliorius.
                    SingleOrDefault(r => r.Id == id && r.Isbn == isbn);
                if (egzemplioriai != null)
                {
                    egzemplioriai.Skaitytojas = null;
                }
                contex.SaveChanges();
            }
        }
        public int GetID (string username, string password)
        {
            IQueryable<Vartotojas> vartotojai;
            using (var contex = new LibraryDataEntities())
            {
                vartotojai = contex.Vartotojas.Where(r => r.Id > 0);
                foreach (var item in vartotojai)
                {
                    if (item.Prisijungimo_vardas == username && item.Slaptazodis == password)
                    {
                        return item.Id;
                    }
                }
            }
            return 0;
        }
    }
}
