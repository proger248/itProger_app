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
    /// Логика взаимодействия для PO.xaml
    /// </summary>
    public partial class PO : Page
    {
        public PO()
        {
            InitializeComponent();
        }

		private void Button_to_home_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new HomePage());
		}

		private void Button_to_first_prog_MouseDown(object sender, MouseButtonEventArgs e)
		{
			MessageBox.Show("Наш \"Калькулятор\"пока не доступен для общего пользования");
		}

		private void Button_to_second_prog_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://github.com/proger248/ToDo");
			MessageBox.Show("Ожидание открытия браузера...");
		}
	}
}
