using System.Windows;
using System.Windows.Input;

namespace MouseCapture{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void Rectangle_MouseMove(object sender, MouseEventArgs e){
			if(e.LeftButton == MouseButtonState.Pressed){
				Point currentMouse = e.GetPosition(Rect);
				TextBlock1.Text = string.Format("x:{0} y:{1}", currentMouse.X,
			   currentMouse.Y);
			}
		}
		void Rectangle_MouseDown(object sender, MouseButtonEventArgs e){
			if(IsCaptureMouse.IsChecked == true)
				Rect.CaptureMouse();
		}
		void Rectangle_MouseUp(object sender, MouseButtonEventArgs e){
			if(IsCaptureMouse.IsChecked == true)
				Rect.ReleaseMouseCapture();
		}
	}
}