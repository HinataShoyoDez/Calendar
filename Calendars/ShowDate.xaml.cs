using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Calendars
{
    public partial class ShowDate : Page
    {

        private ObservableCollection<Reminder> reminders;

        public ShowDate(ObservableCollection<Reminder> reminders)
        {
            InitializeComponent();
            this.reminders = reminders;
            RemindersListBox.ItemsSource = reminders;
        }
        private void BtnGoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }

        private void BtnChange(object sender, RoutedEventArgs e)
        {
            var selectedItem = RemindersListBox.SelectedItem as Reminder;
            if (selectedItem != null)
            {
                var editWindow = new EditReminder(selectedItem);
                if (editWindow.ShowDialog() == true)
                {
                   
                    RemindersListBox.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir değer seçin", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnDelete(object sender, RoutedEventArgs e)
        {
            var selectedItem = RemindersListBox.SelectedItem as Reminder;
            if (selectedItem != null)
            {
                reminders.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen Değer Seçin", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
