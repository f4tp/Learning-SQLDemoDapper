using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FormUI
{
    public static class Helper
    {
        //looks up which connection string to get out of
        //app.config, and returns that one
        public static string CnnVal(string name)
        {
            //[name] is the argument passed in from the name defined in 
            //the connection strings definition (in App.config)
            //question - why square brackets??
            //is it because it is XAML??
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
