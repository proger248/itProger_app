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

namespace itproger
{
    /// <summary>
    /// Логика взаимодействия для OnlineLessons.xaml
    /// </summary>
    public partial class OnlineLessons : Page
    {
        public OnlineLessons()
        {
            InitializeComponent();
        }

		private void Button_to_home_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new HomePage());
		}

		private void Js_button_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new js_view());
		}
	}
}
