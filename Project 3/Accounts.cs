using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_3
{
    public class Accounts
    {
        string firstname;
        string lastname;
        string phonenumber;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        
        public string Lastname 
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Phonenumber 
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }



    }
}