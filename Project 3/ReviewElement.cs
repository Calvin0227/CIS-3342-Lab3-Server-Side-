using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_3
{
    public class ReviewElement

    {
        public String id;
        public String ID
        {
            get { return id; }
            set { id = value; }
        }
        public String name;


        public String NAME
        {
            get { return name; }
            set { name = value; }
        }

        public String type;
        public String TYPE
        {
            get { return type; }
            set { type = value; }
        }
        public String review;

        public String REVIEW 
        {
            get { return review; }
            set { review = value; }
        }

        public String quality;

        public String QUALITY 
        {
            get {return quality; }
            set {quality = value; }
        }

        public String service;

        public String SERVICE 
        {
            get { return service; }
            set { service = value; }
        }

        public String atmosphere;
        
        public String ATMOSPHERE 
        {
            get { return atmosphere; }
            set { atmosphere = value; }
        }

        public String price;

        public String PRICE 
        {
            get { return price; }
            set { price = value; }
        }

    }
}