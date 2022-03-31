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
    /// Логика взаимодействия для python_view.xaml
    /// </summary>
    public partial class python_view : Page
    {
        public python_view()
        {
            InitializeComponent();
        }

		private void Button_to_back_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new OnlineLessons());
		}

		private void Base_python_button_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new base_python_view());
		}
	}
}
