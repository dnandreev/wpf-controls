using System.Windows;

namespace TextBox{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();
		void txt_SelectionChanged(object sender, RoutedEventArgs e){
			if(txtSelection == null)
				return;
			txtSelection.Text = string.Format("Выбрано с позиции {0}; количество символов == {1}; текст == \"{2}\"", txt.SelectionStart, txt.SelectionLength, txt.SelectedText);
		}
	}
}