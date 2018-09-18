using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace GunderMarket
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public string enteredUserName;
        public string enteredPassword;

        public LoginPage()
        {
            InitializeComponent();
        }

        public void Login_Click(object sender, RoutedEventArgs e)
        {
            //creates variable for user created username
            enteredUserName = UsernameTextBox.Text;

            //creates variable for user created password
            enteredPassword = PasswordTextBox.Text;

            //holds all usernames
            List<string> usernameList = new List<string>
            {
                "admin",
                //userUserName //adds user created username to ArrayList that contains usernames
            };

            //holds all passwords
            List<string> passwordList = new List<string>
            {
                "12345",
                //userPassword //adds user created password to ArrayList that contains passwords
            };

            //if entered password and username are found in the username and password lists and have matching indexes,
            //then user is able to login.
            if ((usernameList.Contains(enteredUserName) && passwordList.Contains(enteredPassword)) && 
                (usernameList.IndexOf(enteredUserName) == (passwordList.IndexOf(enteredPassword))))
            {
                Close();
                MainWindow mw = new MainWindow();
                mw.IsLoggedIn = true;
            }
        }
    }
}
