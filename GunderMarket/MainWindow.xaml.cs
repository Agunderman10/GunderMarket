using System.Windows;
using System.Collections;
using System.Windows.Controls;

namespace GunderMarket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //holds all needed variables
        #region Private Members

        LoginPage loginPage = new LoginPage();

        //tells if the user is logged into their account
        public bool isLoggedIn;

        //user's balance
        private double userBalance;

        #endregion

        #region Initial Constructor

        public MainWindow()
        {

            InitializeComponent();

            LoggedInChecker();

        }

        #endregion

        #region ButtonClicks

        /// <summary>
        /// tells what happens when buttons are clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Clicks(object sender, RoutedEventArgs e)
        {

            //casts sender to a button
            Button button = (Button)sender;

            //switches through button.Content to learn which button is clicked and decides which actions shall occur
            switch (button.Content)
            {

                case "Login":
                    
                    loginPage.Show();

                    break;

                case "Finish Login":

                    NewLogin();

                    break;

                case "Create an Account":

                    CreateAccountPage createAccountPage = new CreateAccountPage();
                    createAccountPage.Show();

                    break;

                case "Create Account":

                    break;

                case "Deposit":

                    DepositPage depositPage = new DepositPage();
                    depositPage.Show();

                    break;

                case "Finish Deposit":

                    break;

                case "Withdraw":

                    WithdrawPage withdrawPage = new WithdrawPage();
                    withdrawPage.Show();

                    break;

                case "Finish Withdraw":

                    break;

                case "Clear Order":

                    break;

                case "Logout":

                    isLoggedIn = false;

                    break;

            }

        }

        #endregion

        #region NewLogin

        /// <summary>
        /// called when login button is clicked, holds the usernames and passwords for login
        /// </summary>
        public void NewLogin()
        {
            //user creates account and is now logged in
            isLoggedIn = true;
        }

        #endregion

        #region LoggedInChecker

        /// <summary>
        /// checks if user is logged in, then it sets certain items to be unusable
        /// </summary>
        public void LoggedInChecker()
        {
            if (isLoggedIn == false)
            {

                Panel.IsEnabled = false;
                LoginButton.IsEnabled = true;
                CreateAnAccountButton.IsEnabled = true;
                DepositButton.IsEnabled = false;
                WithdrawButton.IsEnabled = false;
                ClearOrderButton.IsEnabled = false;
                LogoutButton.IsEnabled = false;
                LoginTextBox.Visibility = Visibility.Visible;

            }
        }

        #endregion

    }
}
