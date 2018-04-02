using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data;


namespace FormUI
{
    class DataAccess
    {

        public List<Person> GetPeople(string lastnamein)
        {
            //this is where we actually connect to SQL server
            //create a new connection to SQL server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //var output =  connection.Query<Person>($"SELECT * FROM dbo.tblPeople WHERE LastName = '{lastnamein}';").ToList();
                //new { XXXXX has to be the name of the paramter defined in the stored procedure
                //commandType is optional
                // the connection.Query<list> takes the data returned from the DB, opens up the person class, creates a new person instance and populates the properties in the order that they have been declared in the class??? << might be factually incorrect, 
                //adds them to a list of type Person, << 1hour in  - revisit again
                //advice from Tim, create a class for each table, and set up the properties in the exact order they exist in the table
                var output = connection.Query<Person>("dbo.tblPeople_GetByLastName", new { lastnamepa = lastnamein }, commandType: CommandType.StoredProcedure).ToList();

                //another way to do it (below)
                //var output = connection.Query<Person>($"tblPeople_GetByLastName '{lastnamein}'").ToList();

                //cannot get the video version to work though - with a parameter made reference to explicitly
                //var output = connection.Query<Person>("dbo.tblPeople_GetByLastName @lastnamepa", new {lastnamepa = lastnamein}, commandType: CommandType.StoredProcedure).ToList();
                //new creates a new class instance, a class that doesn;t exist, a dynamic class



                return output;


            }
        }
            //my attempt at calling using multi arguments, THEY ARE CALLED LITERALLY, not passed in through TextBox
            //doesn't work
            public void InsertPeople()
            {
                using (IDbConnection connectionAgain = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
                {
                    connectionAgain.Execute("dbo.tblPeople_Insert", new { firstname = "Bob", lastname = "Boberson", emailaddress = "bob@bob.com", phonenumber = "01111999288" });
                    MessageBox.Show("Person Inserted");
                }
            }

            public void InsertPerson(string firstnamein, string lastnamein, string emailin, string phonenumin)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
                {
                 //Person personToAdd = new Person { FirstName = firstnamein, LastName = lastnamein, EmailAddress = emailin, Phonenumber = phonenumin };
                 // the .Execute procedure expects multiple objects / instances of the model, so a list has to be passed in, even if it is populated with just one 'person' for example
                List<Person> peopleIn = new List<Person>();
                peopleIn.Add(new Person { FirstName = firstnamein, LastName = lastnamein, EmailAddress = emailin, Phonenumber = phonenumin });

             

                //this works also, but the tutorial version does not, as I am running SQL server 2005, SQL Server 2016 it will work with
                //it wasn't the newer version of Dapper anyway (tried older version, did not work)
                connection.Execute($"dbo.tblPeople_Insert @firstname='{firstnamein}', @lastname = '{lastnamein}', @emailaddress='{emailin}', @phonenumber='{phonenumin}'");


                MessageBox.Show("Your record has been successfully inserted");

                // this is the version that shoudl work with the newer version of sql / from the video     
                //connection.Execute("dbo.tblPeople_Insert @firstname, @lastname, @emailaddress, @phonenumber", peopleIn);




                //other stuff I tried
                //connection.Execute("dbo.tblPeople_Insert @firstname, @lastname, @emailaddress, @phonenumber", peopleIn);

                //passing in literally - works below
                //connection.Execute("dbo.tblPeople_Insert @firstname='test', @lastname = 'tester', @emailaddress='test@test.com', @phonenumber='supertest'");

            }
        }
        

    }
}
