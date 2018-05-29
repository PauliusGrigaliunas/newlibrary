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
    }
}
