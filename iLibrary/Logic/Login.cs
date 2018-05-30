using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLibrary.Logic
{
    class Login
    {
        public bool LogMeIn(string username, string password, int typeOfUser, int ID)
        {
            using (var context = new LibraryDataEntities())
            {
                Vartotojas v = new Vartotojas();
                IQueryable<Vartotojas> query = from Vartotojas in context.Vartotojas
                                               where Vartotojas.Prisijungimo_vardas == username
                                               where Vartotojas.Slaptazodis == password
                                               where Vartotojas.DarbSkait == typeOfUser
                                               select Vartotojas;

                if (query.Any<Vartotojas>())
                { return true; v = query.First(); ID = v.Id; }
                else return false;
            }
        }
    }
}
