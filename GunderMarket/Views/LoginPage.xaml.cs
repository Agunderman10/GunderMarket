using System.Windows;

namespace GunderMarket
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public static LoginWindowViewModel LoginPageViewModel = new LoginWindowViewModel();
        public LoginPage()
        {
            InitializeComponent();
            this.DataContext = LoginPageViewModel;
        }
    }
}
