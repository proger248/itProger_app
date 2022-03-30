using System;
using System.Diagnostics;
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

namespace itproger
{
	/// <summary>
	/// Логика взаимодействия для HomePage.xaml
	/// </summary>
	public partial class HomePage : Page
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private void Button_to_lessons_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new lessons());
		}

		private void Contacts_button_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new contacts());
		}

		private void Online_lessons_button_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new OnlineLessons());
		}
	}
}
