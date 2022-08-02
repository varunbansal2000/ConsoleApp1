using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Logger
    {
        public int LogID { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string LogDate { get; set; }
        public string ExceptionDetails { get; set; }
        
    }
}
