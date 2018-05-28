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

namespace iLibrary.Forms
{
    public partial class UserSettingsForm : Form
    {
        public User user;
        public UserSettingsForm(User user)
        {
            InitializeComponent();
            this.user = user;
     
        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            using (LibraryDataEntities dataEntities = new LibraryDataEntities())
            {

                var knygos = (from c in dataEntities.Knygos
                              from a in dataEntities.Egzempliorius
                              where c.Isbn == a.Isbn && !a.Skaitytojas.HasValue
                              select c).Distinct().ToArray();


                knygosDataGridView.DataSource = knygos;
                /*
                var knygos2 = (from c in dataEntities.Knygos
                               from a in dataEntities.Egzempliorius
                               where c.Isbn == a.Isbn && a.Skaitytojas == user.ID
                               select c).ToArray();


                knygosDataGridView.DataSource = knygos2;*/

            }
        }
    }
}
