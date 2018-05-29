using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLibrary.Logic
{
    public class Copy
    {
        public int Id { get; set; }
        public int Isbn { get; set; }
        public int? Skaitytojas { get; set; }
        public DateTime? GrazinimoLaikas { get; set; }


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