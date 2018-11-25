using System;
using System.Windows;
using System.Windows.Input;

namespace GunderMarket
{
    internal sealed class ButtonCommands : ICommand
    {
        
        private readonly MainWindowViewModel viewModel;

        public ButtonCommands(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        private void WarningBoxes()
        {
            //hack to just see if user has chosen a new quantity other than zero for any items. this assumes balance always starts at 1000. needs changed
            if (viewModel.AfterOrderBalance == 1000)
            {
                MessageBox.Show("You have not chosen any items to purchase.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to purchase these items?", "Purchase Verification", MessageBoxButton.YesNo)
                    == MessageBoxResult.Yes)
                {
                    viewModel.ResetPurchase();
                    MessageBox.Show("You will now be logged out. Thank you for shopping at GunderMarket!");
                    viewModel.IsLoggedIn = false;
                    viewModel.OnPropertyChanged("IsLoggedIn");
                }

            }
        }
        /// <summary>
        /// switches through command parameters of MainWindow buttons to find which button was clicked
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {

            switch (parameter)
            {
                case "LoginPageButton":

                    if (viewModel.IsLoggedIn == false)
                        MainWindow.loginPage.Show();
                    else if (viewModel.IsLoggedIn == true)
                        MainWindow.loginPage.Close();
                    break;

                case "CreateAccountPageButton":

                    MainWindow.createAccountPage.Show();

                    break;
                case "DepositPageButton":

                    MainWindow.depositPage.Show();

                    break;

                case "WithdrawPageButton":

                    MainWindow.withdrawPage.Show();

                    break;

                case "ClearOrderButton":

                    viewModel.ResetPurchase();

                    break;

                case "LogoutButton":

                    viewModel.IsLoggedIn = false;

                    break;

                case "FinishLoginButton":

                    viewModel.LoginChecks();

                    break;

                case "PurchaseButton":

                   WarningBoxes();
                    
                    break;
            }
        }
    }
}
