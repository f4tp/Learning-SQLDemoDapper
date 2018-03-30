using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phonenumber { get; set; }

        //propfull tab tab
        public string FullInfo
        {
            get {
                //format will be Paul Treadwell (p@p.com)
                //$ used to embed string variables within a string literal
                //as a format operator
                return $"{ FirstName} {LastName} ({EmailAddress})";
                }
           }



    }
}
