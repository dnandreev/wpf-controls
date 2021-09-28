using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CheckBoxList{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();
		void lst_SelectionChanged(object sender, RoutedEventArgs e){
			if(e.OriginalSource is CheckBox)
				lst.SelectedItem = e.OriginalSource;
			txtSelection.Text = string.Format("Позиция {0}.\r\nСостояние {1}.", lst.SelectedIndex, ((CheckBox)lst.SelectedItem).IsChecked);
		}
		void cmd_CheckAllItems(object sender, RoutedEventArgs e){
			StringBuilder sb = new StringBuilder();
			foreach(CheckBox item in lst.Items)
				if(item.IsChecked == true)
					sb.AppendLine(item.Content + " отмечен. ");
			txtSelection.Text = sb.ToString();
		}
	}
}