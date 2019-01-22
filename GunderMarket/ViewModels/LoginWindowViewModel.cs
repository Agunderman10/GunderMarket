using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GunderMarket
{
    public class LoginWindowViewModel
    {
        #region Private Fields
        private string _enteredUsername;
        private string _enteredPassword;
        #endregion
        #region Private Username and Password Lists
        private List<string> usernameList = new List<string>
        {
            "admin"
        };

        private List<string> passwordList = new List<string>
        {
            "12345"
        };
        #endregion
        #region Public Properties
        public string EnteredUsername
        {
            get { return this._enteredUsername; }
            set
            {
                if(this._enteredUsername != value)
                {
                    this._enteredUsername = value;
                }
            }
        }

        public string EnteredPassword
        {
            get { return this._enteredPassword; } 
            set
            {
                if(this._enteredPassword != value)
                {
                    this._enteredPassword = value;
                }
            }
        }

        public ICommand FinishLogin
        {
            get { return new ButtonCommands(FinishLoginChecks); }
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// checks that user login info matches login info in the username and password lists, if it matches user can login
        /// </summary>
        public void FinishLoginChecks()
        {
            if ((usernameList.Contains(EnteredUsername) &&
               passwordList.Contains(EnteredPassword)) &&
               (usernameList.IndexOf(EnteredUsername) ==
               (passwordList.IndexOf(EnteredPassword))))
            {
                MainWindow.mainWindowViewModel.CloseLoginWindow();
            }
        }
        #endregion
    }
}
