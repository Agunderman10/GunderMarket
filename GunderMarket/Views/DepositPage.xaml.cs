using System.Windows;

namespace GunderMarket
{
    /// <summary>
    /// Interaction logic for DepositPage.xaml
    /// </summary>
    public partial class DepositPage : Window
    {
        public static DepositWindowViewModel DepositWindowViewModel = new DepositWindowViewModel();
        public DepositPage()
        {
            InitializeComponent();
            this.DataContext = DepositWindowViewModel;
        }
    }
}
