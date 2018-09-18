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

        public bool IsLoggedIn { get; set; }

        //user's balance
        private double userBalance;

        #endregion

        #region Initial Constructor

        public MainWindow()
        {

            InitializeComponent();
            IsLoggedIn = false; //delete if we run into problems

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

                    if (IsLoggedIn == false) //if user is not logged in, open login page
                        loginPage.Show();
                    else if (IsLoggedIn == true)
                        NeedToLoginMessage();
                    break;

                case "Create an Account":

                    if (IsLoggedIn == false) { //if user is not logged in, open create account page
                    CreateAccountPage createAccountPage = new CreateAccountPage();
                    createAccountPage.Show();
                    }
                    else if (IsLoggedIn == true)
                        NeedToLoginMessage();

                    break;

                case "Deposit":

                    if (IsLoggedIn == true) { //if user is logged in, open deposit page
                    DepositPage depositPage = new DepositPage();
                    depositPage.Show();
                    }
                    else if (IsLoggedIn == false)
                        NeedToLoginMessage();

                    break;

                case "Withdraw":

                    if (IsLoggedIn == true) { //if user is logged in, open withdraw page
                    WithdrawPage withdrawPage = new WithdrawPage();
                    withdrawPage.Show();
                    }
                    else if (IsLoggedIn == false)
                        NeedToLoginMessage();

                    break;

                case "Clear Order":
                    break;

                case "Logout":

                    break;

            }

        }

        #endregion

        #region NeedToLoginMessage

        public void NeedToLoginMessage()
        {
            if (IsLoggedIn == false)
                MessageBox.Show("You are not logged in. Please login.");
            else if (IsLoggedIn == true)
                MessageBox.Show("You are already logged in!");
        }

        #endregion
    }
}
