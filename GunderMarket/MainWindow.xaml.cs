using System.Windows;

namespace GunderMarket
{
    public partial class MainWindow : Window
    {
        
        public static MainWindowViewModel mainViewModel = new MainWindowViewModel();
        public static LoginPage loginPage = new LoginPage();
        public static CreateAccountPage createAccountPage = new CreateAccountPage();
        public static DepositPage depositPage = new DepositPage();
        public static WithdrawPage withdrawPage = new WithdrawPage();

        public MainWindow()
        {
            loginPage.DataContext = mainViewModel;
            createAccountPage.DataContext = mainViewModel;
            depositPage.DataContext = mainViewModel;
            withdrawPage.DataContext = mainViewModel;
            InitializeComponent();
            this.DataContext = mainViewModel;
        } 
    }
}

