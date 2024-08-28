using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendars
{
    public partial class Calendar : Page
    {
        public ReminderViewModel viewModel;
        public ObservableCollection<Reminder> reminders = new ObservableCollection<Reminder>();
        public Calendar()
        {
            InitializeComponent();
            CultureInfo turkishCulture = new CultureInfo("tr-TR");
            System.Threading.Thread.CurrentThread.CurrentCulture = turkishCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = turkishCulture;
            viewModel = new ReminderViewModel { Reminders = reminders };
            this.DataContext = viewModel;
        }

        private void BtnReminder_Click(object sender, RoutedEventArgs e)
        {

            string message = txtInput.Text;

            if (calendar.SelectedDate.HasValue && !string.IsNullOrEmpty(message))
            {
                DateTime selectedDate = calendar.SelectedDate.Value;
                txtInput.Clear();
                txtInput.Focus();
                calendar.SelectedDate = null;
                reminders.Add(new Reminder(selectedDate, message));
                MessageBox.Show("Başarıyla Eklendi");


            }
            else
            {
                MessageBox.Show("Bütün seçimleri yapın");
            }



        }
        private void BtnZamanlar_Click(object sender, RoutedEventArgs e) 
        {
            NavigationService.Navigate(new ShowDate(viewModel.Reminders));
        }
        
    }
}
