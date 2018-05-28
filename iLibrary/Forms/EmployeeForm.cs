using iLibrary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLibrary
{
    public partial class EmployeeForm : Form
    {
        List<Copy> copies;
        DataManagment dm;
        public EmployeeForm()
        {
            copies = new List<Copy>();
            dm = new DataManagment();
            dm.GetAllCopies(copies);
            InitializeComponent();
            foreach (var cp in copies)
            {
                testLabel.Text += cp.Id.ToString() + " " + cp.Isbn.ToString() + " " + cp.Skaitytojas.ToString() + "\n";
            }
        }
    }
}
