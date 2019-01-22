using System.Windows;

namespace GunderMarket
{
    public partial class MainWindow : Window
    {
        
        public static MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();

        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = mainWindowViewModel;
        } 
    }
}

