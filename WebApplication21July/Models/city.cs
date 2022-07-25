using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication21July.Models
{
    public class city
    {
        public string cityID { get; set; }
        public string cityName { get; set; }
        public string stateID { get; set; }
    }

    public class Cities : List<city>
    {
        public Cities ()
        {
            Add(new city() { cityID = "PB13", cityName = "Sangrur", stateID = "PB"});
            Add(new city() { cityID = "PB15", cityName = "Patiala", stateID = "PB" });
            Add(new city() { cityID = "HR10", cityName = "Dabawali", stateID = "HR" });
            Add(new city() { cityID = "HR19", cityName = "Ambala", stateID = "HR" });
            Add(new city() { cityID = "DL40", cityName = "New Delhi", stateID = "DL" });
            Add(new city() { cityID = "AP56", cityName = "AP City", stateID = "AP" });
            Add(new city() { cityID = "AP66", cityName = "AP City2", stateID = "AP" });
            Add(new city() { cityID = "MH01", cityName = "Mumbai", stateID = "MH" });
            Add(new city() { cityID = "MH07", cityName = "Pune", stateID = "MH" });


        }
    }
}