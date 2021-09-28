using System.Windows;
using System.Windows.Controls;

namespace Variant4{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => dateSelected.Text = datePicker.SelectedDate.ToString();

		void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e) => dateSelected.Text = string.Format("{0} дней, начиная с {1}", calendar.SelectedDates.Count, calendar.SelectedDates[0]);
	}
}