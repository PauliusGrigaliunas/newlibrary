using iLibrary.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLibrary.Logic
{

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }
        public int DarbSkait { get; set; }
        public string Name { get; set; }
        public int? Phone { get; set; }
        public string Address { get; set; }
        public int? Code { get; set; }



        public void FillData()
        {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                Vartotojas vartotojas = new Vartotojas()
                {
                    Id = ID = NewIdForVartotojai(),
                    Prisijungimo_vardas = Username,
                    Slaptazodis = Password,
                    DarbSkait = DarbSkait,
                    Vardas = Name,
                    Telefono_numeris = Phone,
                    Adresas = Address,
                    Pasto_Kodas = Code
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


        public bool LogMeIn()
        {
            using (var context = new LibraryDataEntities())
            {
                IQueryable<Vartotojas> query = from Vartotojas in context.Vartotojas
                                               where Vartotojas.Prisijungimo_vardas == Username
                                               where Vartotojas.Slaptazodis == Password
                                               where Vartotojas.DarbSkait == DarbSkait
                                               select Vartotojas;

                if (query.Any())
                    return true;
                else return false;
            }
        }

        public Form ClientOrEmployee()
        {
            if (DarbSkait.Equals(0)) return new UserSettingsForm(this);
            else return new EmployeeForm(this);
        }
    }
}
