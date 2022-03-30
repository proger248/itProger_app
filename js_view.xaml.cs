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
    /// Логика взаимодействия для js_view.xaml
    /// </summary>
    public partial class js_view : Page
    {
        public js_view()
        {
            InitializeComponent();
        }

		private void Button_to_back_page_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new OnlineLessons());
		}

		private void Cocos_creator_button_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new CocosCreator_lessons());
		}
	}
}
