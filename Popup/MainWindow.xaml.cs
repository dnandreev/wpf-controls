using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Popup{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void run_MouseEnter(object sender, MouseEventArgs e) => popLink.IsOpen = true;

		void lnk_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(((Hyperlink)sender).NavigateUri.ToString());
	}
}