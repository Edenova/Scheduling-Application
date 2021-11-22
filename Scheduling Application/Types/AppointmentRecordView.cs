using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Application.Types
{
    public class AppointmentRecordView
    {
        public int AppointmentID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Customer { get; set; }
        
    }
}
