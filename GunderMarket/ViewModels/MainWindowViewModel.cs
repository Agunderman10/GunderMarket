using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace GunderMarket
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        
        #region Private Members

        private bool _isLoggedIn = false;
        private string _enteredUsername;
        private string _enteredPassword;
        
        #endregion

        #region Constructor
     
        /// <summary>
        /// Constructor calls ButtonCommands
        /// </summary>
        public MainWindowViewModel()
        {
            ButtonCommands = new ButtonCommands(this);
        }

        #endregion

        #region Username and Password Lists

        /// <summary>
        /// lists that contain all username and password login info, used to check if user login info matches
        /// </summary>
        internal List<string> usernameList = new List<string>
        {
            "admin",
        };
        internal List<string> passwordList = new List<string>
        {
            "12345",
        };

        #endregion

        #region Public Properties

        /// <summary>
        /// property that tells if user is logged in, raises property changed event
        /// </summary>
        public bool IsLoggedIn
        {
            get => this._isLoggedIn;
            set
            {
                if (this._isLoggedIn != value)
                {
                    this._isLoggedIn = value;
                    OnPropertyChanged("IsLoggedIn");
                }
            }
        }

        /// <summary>
        /// property sets EnteredUsername to value that user enters into the username textbox, raises propertychanged event
        /// </summary>
        public string EnteredUsername
        {
            get => this._enteredUsername;
            set
            {
                if (this._enteredUsername != value)
                {
                    this._enteredUsername = value;
                    OnPropertyChanged("EnteredUsername");
                }
            }
        }

        /// <summary>
        /// property sets EnteredPassword to value that user enters into the password textbox, raises propertychanged event
        /// </summary>
        public string EnteredPassword
        {
            get => this._enteredPassword;
            set
            {
                if(this._enteredPassword != value)
                {
                    this._enteredPassword = value;
                    OnPropertyChanged("EnteredPassword");
                }
            }
        }

        /// <summary>
        /// action that is called when the user's login info is correct, closes LoginPage window
        /// </summary>
        public Action CloseAction { get; set; }
        #endregion

        #region Public Methods

        /// <summary>
        /// checks that user login info matches login info in the username and password lists, if it matches, it calls CloseAction()
        /// </summary>
        public void LoginChecks()
        {
            LoginPage loginPage = new LoginPage();
            if ((usernameList.Contains(EnteredUsername) &&
               passwordList.Contains(EnteredPassword)) &&
               (usernameList.IndexOf(EnteredUsername) ==
               (passwordList.IndexOf(EnteredPassword))))
            {
                IsLoggedIn = true;
                CloseAction();
            }
        }
        #endregion

        #region Get ButtonCommands

        /// <summary>
        /// gets ButtonCommands
        /// </summary>
        public ICommand ButtonCommands { get; }

        #endregion

        #region INotifyPropertyChanged Necessary Parts Definitions

        /// <summary>
        /// if property is changed, invoke new propertychanged event
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// default PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
