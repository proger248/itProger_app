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
	/// Логика взаимодействия для base_cs_view.xaml
	/// </summary>
	public partial class base_cs_view : Page
	{
		public base_cs_view()
		{
			InitializeComponent();
		}

		private void Button_to_back_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new python_view());
		}

		private void Button_to_first_lesson_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://youtu.be/Uf4htNNwHDk");
			MessageBox.Show("Ожидание открытия браузера...");
		}
	}
}
