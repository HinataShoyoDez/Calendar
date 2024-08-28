using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    public class Reminder
        
    {
        public DateTime date { get; set; }
        public string  message { get; set; }

        public Reminder(DateTime date, string message)
        {
            this.date = date;
            this.message = message;
        }
    }
}
