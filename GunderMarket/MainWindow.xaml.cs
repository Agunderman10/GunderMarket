using System.Windows;
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

        //tells if the user is logged into their account
        private bool isLoggedIn = false;


        //tells if the user has intitiated a new purchase
        private bool isPurchaseEnded = true;

        #endregion

        #region Initial Constructor

        public MainWindow()
        {

            InitializeComponent();

            NewPurchase();

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

            //switches through button.Content to learn which button is clicked and the following events
            switch(button.Content)
            {

                case "Login":
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    break; 

                case "Create an Account":
                    CreateAccountPage createAccountPage = new CreateAccountPage();
                    createAccountPage.Show();
                    break;

                case "Deposit":
                    DepositPage depositPage = new DepositPage();
                    depositPage.Show();
                    break;

                case "Withdraw":
                    WithdrawPage withdrawPage = new WithdrawPage();
                    withdrawPage.Show();
                    break;

            }

        }

        #endregion

        #region NewLogin

        /// <summary>
        /// called when button is clicked
        /// </summary>
        public void NewLogin()
        {

        }

        #endregion

        #region NewPurchase

        /// <summary>
        /// runs if user starts new purchase
        /// </summary>
        public void NewPurchase()
        {

            //tells that a new purchase has been started
            isPurchaseEnded = false;

            //if user is not logged in, Panel cannot be accessed
            if (isLoggedIn == false)
            {
                Panel.IsEnabled = false;
            }

        }

        #endregion
    }
}
