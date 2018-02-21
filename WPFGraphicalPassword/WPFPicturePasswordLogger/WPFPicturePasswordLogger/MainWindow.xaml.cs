using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFPicturePasswordLogger
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			_presenter = new PicturePasswordPresenter();
		}

		private PicturePasswordPresenter _presenter;

		private void _chooseNewImageBtn_Click(object sender, RoutedEventArgs e)
		{
			//Open Choose Picture window
			ChoosePicture newWindow = new ChoosePicture();
			newWindow.Show();

		}

		private void _createNewLogin_Click(object sender, RoutedEventArgs e)
		{

		}

		private void _submitBtn_Click(object sender, RoutedEventArgs e)
		{
			_presenter.SubmitButtonPush();
		}

		private void _cancelBtn_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
