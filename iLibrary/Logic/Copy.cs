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
    }
}
