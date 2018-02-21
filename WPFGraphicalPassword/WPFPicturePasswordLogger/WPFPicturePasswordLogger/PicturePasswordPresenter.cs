using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows;
using System.IO;

namespace WPFPicturePasswordLogger
{
	public class PicturePasswordPresenter
	{

		public const int PASSWORD_LENGTH = 6;
		public const string PASSWORD_FILENAME = "PasswordFile02.txt";
		//public const string IMAGE_FILENAME = "SamplePicture02.jpg";
		public const string OUTPUT_FILENAME = "output.txt";
		public const double THRESHOLD = 30.0;

		private string _imageName;
		public string ImageName
		{
			get
			{
				return _imageName;
			}
		}

		public ObservableCollection<BitmapImage> Images { get; set; }
		public string Username { get; set; }
		private List<Point> m_PasswordFileClicks;

		/// <summary>
		/// Used to return the a list of ints that holds the clicks.
		/// </summary>
		public List<Point> PasswordFileClicks
		{
			get
			{
				return new List<Point>(m_PasswordFileClicks);
			}
		}

		/// <summary>
		/// Used to put click points into the list.
		/// </summary>
		/// <param name="setPoint"></param>
		public void SetPasswordClicksList(Point setPoint)
		{
			if (m_PasswordFileClicks == null)
			{
				m_PasswordFileClicks.Add(setPoint);
			}
			else if (m_PasswordFileClicks.Count() < PASSWORD_LENGTH)
			{
				m_PasswordFileClicks.Add(setPoint);
			}
		}

		public PicturePasswordPresenter()
		{
			_imageName = @"Content\SamplePicture02.jpg";

			//var newUriSource = new Uri(@"C:\Users\Jared\Documents\InterviewQuestions\WPFGraphicalPassword\WPFPicturePasswordLogger\WPFPicturePasswordLogger\Content\SamplePicture01.jpg");
			//var newBitmapImage = new BitmapImage(newUriSource);

			//Images.Add(newBitmapImage);

			//newUriSource = new Uri(@"Content\SamplePicture02.jpg", UriKind.Relative);
			//newBitmapImage = new BitmapImage(newUriSource);
			//Images.Add(newBitmapImage);
		}

		public void SubmitButtonPush()
		{

			//Checking the username to see if it is correct.
			//if (m_EnteredUserName == "")
			//{
			//	UsernameErrorLabel.Text = "No Username entered. Please enter a Username.";
			//	UsernameErrorLabel.Show();
			//}
			//else if (UserNameChecker(m_EnteredUserName))
			//{
			//	UsernameErrorLabel.Text = "The UserName is valid.";
			//	UsernameErrorLabel.Show();
			//}
			//else
			//{
			//	UsernameErrorLabel.Text = "The UserName is INVALID!";
			//	UsernameErrorLabel.Show();
			//}

			//Checking the password to see if it is correct.
			//if (m_EnteredMouseClicks == null)
			//{
			//	PasswordErrorLabel.Text = "No Password entered. Please Enter a Password";
			//	PasswordErrorLabel.Show();
			//}
			//else if (m_EnteredMouseClicks.Count() < PASSWORD_LENGTH)
			//{
			//	PasswordErrorLabel.Text = "Password is invalid. Please Enter a Password";
			//}
			//else if (CompareInputInfo())
			//{

			if(CompareInputInfo())
			{ 
				StreamWriter sw = new StreamWriter(@OUTPUT_FILENAME, true);
				using (sw)
				{
					sw.WriteLine("I am logging in");
				}

				//staticForm = this;

				//this.Hide();

				//Login newLoginForm = new Login();


				//newLoginForm.Show();
			}

			m_EnteredMouseClicks.Clear();
		}
	}
}
