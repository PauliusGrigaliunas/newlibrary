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
        public User user;
        public EmployeeForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void knygosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knygosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataDataSet);

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {


            using (LibraryDataEntities dataEntities = new LibraryDataEntities())
            {

                var knygos = (from c in dataEntities.Knygos
                                 from a in dataEntities.Egzempliorius
                                 where c.Isbn == a.Isbn
                                 select c).ToArray();


                knygosDataGridView.DataSource = knygos;

            }
            
        }
    }
}
