using System;
using System.Windows;
using System.Windows.Controls;

namespace Focus{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		protected override void OnActivated(EventArgs e){
			base.OnActivated(e);
			cmdFocus.Focus();
		}
	}
}