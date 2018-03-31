using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                var output =  connection.Query<Person>($"SELECT * FROM tblPeople WHERE LastName = '{lastname}'").ToList();

                return output;
            }
        
           
        }
    }
}
