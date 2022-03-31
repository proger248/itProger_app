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
	/// Логика взаимодействия для base_python_view.xaml
	/// </summary>
	public partial class base_python_view : Page
	{
		public base_python_view()
		{
			InitializeComponent();
		}

		private void Button_to_back_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new python_view());
		}

		// 1
		private void Button_to_first_lesson_MouseDown(object sender, RoutedEventArgs e)
		{
			Process.Start("https://youtu.be/UxbIZqSa6z8");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 2
		private void Button_to_second_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://youtu.be/Tcku1QI0yYc");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 3
		private void Button_to_third_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://youtu.be/8Ng5Wn-C6tw");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 4
		private void Button_to_fourth_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://youtu.be/kprNKMqynZE");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 5
		private void Button_to_fifth_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://youtu.be/s0pU3JueS_o");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 6
		private void Button_to_sixth_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://youtu.be/J2LphDm5mRc");
			MessageBox.Show("Ожидание открытия браузера...");
		}
	}
}
