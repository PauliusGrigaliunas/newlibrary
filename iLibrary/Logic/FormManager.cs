using iLibrary.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLibrary.Logic
{
    static class FormManager
    {
        public static Form ClientOrEmployee(int number)
        {
            if (number.Equals(0))  return new UserSettingsForm(); 
            else return new EmployeeForm();            
        }
    }
}
