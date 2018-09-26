using System.Windows;
using System;

namespace GunderMarket
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        MainWindowViewModel viewModel = new MainWindowViewModel();

        public LoginPage()
        {
            InitializeComponent();
            this.DataContext = viewModel;
            if(viewModel.CloseAction == null)
                viewModel.CloseAction = new Action(this.Close);
        }
    }
}
