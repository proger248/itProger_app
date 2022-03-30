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
    /// Логика взаимодействия для full_html_view.xaml
    /// </summary>
    public partial class full_html_view : Page
    {
        public full_html_view()
        {
            InitializeComponent();
        }

		private void Button_to_back_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new html_view());
		}

		// 1
		private void Button_to_first_lesson_MouseDown(object sender, RoutedEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=GFZAxNsgqaA&feature=youtu.be");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 2
		private void Button_to_second_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=k9WBYob6pV4&feature=youtu.be");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 3
		private void Button_to_third_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=uw4XOwoNSXs&feature=youtu.be");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 4
		private void Button_to_fourth_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=_7DkZp4mF-I");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		// 5
		private void Button_to_fifth_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=XrocyHv95aY&feature=youtu.be");
			MessageBox.Show("Ожидание открытия браузера...");
		}
	}
}
