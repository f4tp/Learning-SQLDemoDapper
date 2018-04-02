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
            UpdateBinding();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {            
            DataAccess db = new DataAccess();
            people =  db.GetPeople(lastNameText.Text);
            UpdateBinding();
            //db.InsertPeople();
            //UpdateBinding();
        }


        private void btnInsertPerson_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddInsText.Text, phoneNumInsText.Text);
            //db.InsertPeople();
        }

        private void UpdateBinding()
        {
            //connect the listbox to the people List object
            peopleFoundListbox.DataSource = people;
            //a string variable created in the People class
            //will include firstname lastname (email address)
            //Question - why is it passed as string and not a variable?
            peopleFoundListbox.DisplayMember = "FullInfo";
        }
    }
}
