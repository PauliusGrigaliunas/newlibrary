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
                Vartotojai vartotojas = new Vartotojai()
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
                contex.Vartotojais.Add(vartotojas);
                contex.SaveChanges();
            }
        }
        private int NewIdForVartotojai()
        {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                List<int> idList = contex.Vartotojais.Select(x => x.Id).ToList();

                return idList.Last() + 1;
            }
        }
    }
}
