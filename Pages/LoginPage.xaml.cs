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

namespace LoginUI.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        //Show another page on login button click
        MainWindow mainWindow { get => Application.Current.MainWindow as MainWindow; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.mainFrame.Navigate(new Uri("/pages/dashboard.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
