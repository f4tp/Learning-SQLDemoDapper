using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;


namespace FormUI
{
    class DataAccess
    {

        public List<Person> GetPeople(string lastname)
        {
            //this is where we actually connect to SQL server
            //create a new connection to SQL server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                // var output = connection.Query<Person>($"SELECT * FROM tblPeople").ToList();

                //if (connection.State == ConnectionState.Closed)
                //{
                   // connection.Open();
                //}

                var output =  connection.Query<Person>($"SELECT * FROM dbo.tblPeople WHERE LastName = '{lastname}';").ToList();
          

                //var output1 = connection.Query<Person>("SELECT name, database_id, create_date FROM sys.databases").ToList();

              

                return output;
            }
        
           
        }
    }
}
