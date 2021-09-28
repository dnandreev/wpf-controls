using System.Windows;
using System.Windows.Input;

namespace MouseEvent{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void MouseMoved(object sender, MouseEventArgs e){
			Point pt = e.GetPosition((UIElement)this);
			lblInfo.Text = string.Format("({0}; {1}) в оконных кординатах.", pt.X, pt.Y);
		}
	}
}