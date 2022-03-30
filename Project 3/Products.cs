using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_3
{
    public class Products
    {
        //String AddName, String AddState, String AddCity, String AddAdress, String AddReview
        private String addname;
        public String ADDNAME 
        {
            get { return addname; }
            set { addname = value; }
        }

        public String addstate;

        public String ADDSTATE 
        {
            get { return addstate; }
            set { addstate = value; }
        }

        public String addcity;

        public String ADDCITY 
        {
            get { return addcity; }
            set { addcity = value; }
        }

        public String addaddress;

        public String ADDADDRESS 
        {
            get { return addaddress; }
            set { addaddress = value; }
        }

        public string addreview;
        public String ADDREVIEW
        {
            get { return addreview; }
            set { addreview = value; }
        }

        public int addzip;
        
        public int ADDZIP 
        {
            get { return addzip; }
            set { addzip = value; }
        }


        public String addtype;
        public String ADDTYPE 
        {
            get { return addtype; }
            set { addtype = value; }
        }

        public String addlink;
        public String ADDLINK 
        {
            get { return addlink; }
            set { addlink = value; }
        }

    }
}