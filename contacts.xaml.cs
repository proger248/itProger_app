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
    /// Логика взаимодействия для contacts.xaml
    /// </summary>
    public partial class contacts : Page
    {
        public contacts()
        {
            InitializeComponent();
        }

		private void Button_to_home_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new HomePage());
		}

		private void Button_to_youtube_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCytDRVLeQB3ZuKnk5pqzHOw");
			MessageBox.Show("Ожидание открытия браузера...");
		}

		private void Button_to_telegram_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://t.me/s/sovetyprogramustu");
			MessageBox.Show("Ожидание открытия браузера...");
		}
	}
}
