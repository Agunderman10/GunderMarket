using System;
using System.Windows;
using System.Windows.Controls;
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

        /// <summary>
        /// switches through command parameters of MainWindow buttons to find which button was clicked
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            LoginPage loginPage = new LoginPage();
            CreateAccountPage createAccountPage = new CreateAccountPage();
            DepositPage depositPage = new DepositPage();
            WithdrawPage withdrawPage = new WithdrawPage();

            switch (parameter)
            {
                case "LoginPageButton":
                    if (viewModel.IsLoggedIn == false)
                    loginPage.Show();
                    else if (viewModel.IsLoggedIn == true)
                            loginPage.Close();
                    break;
                case "CreateAccountPageButton":
                    createAccountPage.Show();
                    break;
                case "DepositPageButton":
                    depositPage.Show();
                    break;
                case "WithdrawPageButton":
                    withdrawPage.Show();
                    break;
                case "ClearOrderButton":
                    viewModel.ResetPurchase();
                    break;
                case "LogoutButton":
                    //code here
                    break;
                case "FinishLoginButton":
                    viewModel.LoginChecks();
                    break;
                case "PurchaseButton":
                    //hack to just see if user has chosen a new quantity other than zero for any items. this assumes balance always starts at 1000. needs changed
                    if (viewModel.AfterOrderBalance == 1000)
                    {
                        MessageBox.Show("You have not chosen any items to purchase");
                    }
                    else if(viewModel.AfterOrderBalance != 1000)
                    {
                        if(MessageBox.Show("Are you sure you want to purchase these items?", "Purchase Verification", MessageBoxButton.YesNo) 
                            == MessageBoxResult.Yes)
                        {
                            viewModel.ResetPurchase();
                        }
                        
                    }
                    
                    break;
            }
        }
    }
}
