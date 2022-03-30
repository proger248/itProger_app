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
    /// Логика взаимодействия для first_html_view.xaml
    /// </summary>
    public partial class first_html_view : Page
    {
        public first_html_view()
        {
            InitializeComponent();
        }

		private void Button_to_back_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new html_view());
		}

		private void Button_to_first_lesson_MouseDown(object sender, RoutedEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=MpNreM-tl-A");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		private void Button_to_second_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=sws8xpq1Yv4&feature=youtu.be");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		private void Button_to_third_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=xcA_r0ZxTEQ&feature=youtu.be");
			MessageBox.Show("Ожидание открытия браузера...");
		}
	}
}
