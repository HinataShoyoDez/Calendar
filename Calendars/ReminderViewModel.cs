using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    public class ReminderViewModel
    {
        public ObservableCollection<Reminder> Reminders { get; set; }

        public ReminderViewModel()
        {
            Reminders = new ObservableCollection<Reminder>();
        }
    }
}
