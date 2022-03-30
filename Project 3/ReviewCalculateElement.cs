using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_3
{
    public class ReviewCalculateElement
    {
        public int qualitycount;
        public int qualitysum;
        public int servicecount;
        public int servicesum;
        public int atmospherecount;
        public int atmospheresum;
        public int pricecount;
        public int pricesum;

        public int QUALITYCOUNT
        {
                get { return qualitycount; }
                set { qualitycount = value; }
        }

        public int QUALITYSUM 
        {
            get { return qualitysum; }
            set { qualitysum = value; }
        }

        public int SERVICECOUNT 
        {
            get { return servicecount; }
            set { servicecount = value; }
        }

        public int SERVICESUM 
        {
            get { return servicesum; }
            set { servicesum = value; }
        }

        public int ATMOSPHERECOUNT 
        {
            get { return atmospherecount; }
            set { atmospherecount = value; }
        }

        public int ATMOSPHERESUM 
        {
            get { return atmospheresum; }
            set { atmospheresum = value; }
        }

        public int PRICECOUNT 
        {
            get { return pricecount; }
            set { pricecount = value; }
        }

        public int PRICESUM 
        {
            get { return pricesum; }
            set { pricesum = value; }
        }
    }
}