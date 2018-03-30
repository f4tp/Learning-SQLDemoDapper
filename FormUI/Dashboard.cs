using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            //connect the listbox to the people List object
            peopleFoundListbox.DataSource = people;
            //a string variable created in the People class
            //will include firstname lastname (email address)
            //Question - why is it passed as string and not a variable?
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (lastNameText.Text != "")
            {
                DataAccess db = new DataAccess();
              people =  db.GetPeople(lastNameText.Text);
              
            }
        }
    }
}
