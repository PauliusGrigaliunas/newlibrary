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


        public bool LogMeIn(User user)
        {
            using (var context = new LibraryDataEntities())
            {
                IQueryable<Vartotojas> query = from Vartotojas in context.Vartotojas
                                               where Vartotojas.Prisijungimo_vardas == user.Username
                                               where Vartotojas.Slaptazodis == user.Password
                                               where Vartotojas.DarbSkait == user.DarbSkait
                                               select Vartotojas;

                if (query.Any())
                    return true;
                else return false;
            }
        }
    }
}
