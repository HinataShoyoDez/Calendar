using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calendars
{
    /// <summary>
    /// Interaction logic for EditReminder.xaml
    /// </summary>
    public partial class EditReminder : Window
    {
       private Reminder Reminder;

        public EditReminder(Reminder reminder)
        {
            InitializeComponent();
           
            Reminder = reminder;
            DataContext = Reminder;
            calendar.SelectedDate = Reminder.date;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {   
            Reminder.message = txtMessage.Text;
            DialogResult = true;
            Close();
        }

        private void Calendar_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calendar.SelectedDate.HasValue)
            {
                Reminder.date = calendar.SelectedDate.Value;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {   
            DialogResult = false;
            Close();
        }
    }
}
