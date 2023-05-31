using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WApp1
{
    public class Player
    {
        public int id { get; set; }
        public string firstName { get; set; }    
        public string lastName { get; set; }

        public string Country { get; set; }

        public string HTMLColor
        {
            get
            {
                if (Country == "POL")
                    return "red";

                if (Country == "GER")
                    return "green";

                if (Country == "ITA")
                    return "blue";

                return "yellow";

            }
        }
    }
}