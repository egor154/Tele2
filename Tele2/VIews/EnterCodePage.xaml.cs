using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Tele2.VIews
{
    /// <summary>
    /// Логика взаимодействия для EnterCodePage.xaml
    /// </summary>
    public partial class EnterCodePage : Page
    {
        public EnterCodePage()
        {
            InitializeComponent();
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Page2());
        }
    }
}
