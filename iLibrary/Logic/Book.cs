using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLibrary.Logic
{
    public class Book
    {
        public int Isbn { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public string Leidykla { get; set; }
        public DateTime? Metai { get; set; }


        public void GetAllBooks(List<Book> books)
        {
            IQueryable<Knygos> knygos;
            using (var contex = new LibraryDataEntities())
            {
                knygos = contex.Knygos.Where(r => r.Isbn > 0);
                foreach (var knyga in knygos)
                {                    
                    Isbn = knyga.Isbn;
                    Pavadinimas = knyga.Pavadinimas;
                    Autorius = knyga.Autorius;
                    Leidykla = knyga.Leidykla;
                    Metai = knyga.Metai;
                    books.Add(this);
                }
            }
        }
    }
}
