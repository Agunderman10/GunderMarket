using System.Windows;

namespace GunderMarket
{
    public partial class MainWindow : Window
    {
        public static MainWindowViewModel mainViewModel = new MainWindowViewModel();
        public static LoginPage loginPage = new LoginPage();
        public MainWindow()
        {
            loginPage.DataContext = mainViewModel;
            //loginPage.Show();
            InitializeComponent();
            this.DataContext = mainViewModel;
        } 
    }
}

