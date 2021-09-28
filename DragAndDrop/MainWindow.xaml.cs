using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DragAndDrop{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void lblSource_MouseDown(object sender, MouseButtonEventArgs e) => DragDrop.DoDragDrop(sender as Label, (sender as Label).Content, DragDropEffects.Copy);

		void lblTarget_Drop(object sender, DragEventArgs e) => ((Label)sender).Content = e.Data.GetData(DataFormats.Text);
	}
}