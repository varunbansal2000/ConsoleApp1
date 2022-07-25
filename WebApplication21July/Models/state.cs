using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication21July.Models
{
    public class state
    {
        public string stateId { get; set; }
        public string stateName { get; set; }
    }

    public class States : List<state>
    {
        public States ()
        {
            Add(new state (){stateId = "MH",stateName="Maharashtra" });
            Add(new state() { stateId = "PB", stateName = "Punjab" });
            Add(new state () { stateId = "HR", stateName = "Harayana" });
            Add(new state () { stateId = "DL", stateName = "Delhi" });
            Add(new state () { stateId = "AP", stateName = "Andhra Pradesh" });
        }
    }
}