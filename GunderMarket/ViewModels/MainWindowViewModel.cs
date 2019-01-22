namespace GunderMarket
{
    using System.ComponentModel;
    using System.Windows.Input;

    public class MainWindowViewModel : INotifyPropertyChanged
    {

        #region Private Members

        private bool _isLoggedIn = false;
        private double _defaultBalance = 0;
        private int _appleQuantity;
        private int _chickenQuantity;
        private int _orangeQuantity;
        private int _carrotQuantity;
        private int _pringleQuantity;
        private int _cheeseQuantity;
        private int _pepperQuantity;
        private int _avocadoQuantity;
        private int _dietCokeQuantity;
        private int _pistachioQuantity;
        private int _paperTowelQuantity;
        private int _cheetoQuantity;
        private int _gatoradeQuantity;
        private int _snickersQuantity;
        private int _broccoliQuantity;
        private int _waterQuantity;
        private int _tomatoQuantity;
        private int _peanutButterQuantity;
        private int _cocaColaQuantity;
        private int _mnMQuantity;
        private int _sugarQuantity;

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
                    OnPropertyChanged("Balance");
                }
            }
        }

        public double Balance
        {
            get => _defaultBalance;
            set
            {
                Balance = BalanceCalculator() + _defaultBalance;
                OnPropertyChanged("Balance");
            }
        }

        public double AfterOrderBalance
        {
            get => AfterOrderBalanceCalculator();
            set
            {
                AfterOrderBalance = AfterOrderBalanceCalculator();
                OnPropertyChanged("AfterOrderBalance");
            }
        }

        public double OrderTotal
        {
            get => BalanceCalculator();
            set
            {
                OrderTotal = BalanceCalculator();
                OnPropertyChanged("OrderTotal");
            }
        }

        public ICommand OpenLogin
        {
            get { return new ButtonCommands(OpenLoginWindow); }
        }

        #region PriceAutoProperties

        /// <summary>
        /// all properties of the prices of each store item
        /// </summary>
        public double ApplePrice { get; set; } = .50;
        public double ChickenPrice { get; set; } = 5.50;
        public double OrangePrice { get; set; } = .50;
        public double CarrotPrice { get; set; } = .75;
        public double PringlePrice { get; set; } = 1.00;
        public double CheesePrice { get; set; } = .75;
        public double PepperPrice { get; set; } = .50;
        public double AvocadoPrice { get; set; } = .50;
        public double DietCokePrice { get; set; } = 3.00;
        public double PistachioPrice { get; set; } = 2.00;
        public double PaperTowelPrice { get; set; } = 1.00;
        public double CheetoPrice { get; set; } = .50;
        public double GatoradePrice { get; set; } = .50;
        public double SnickersPrice { get; set; } = 1.00;
        public double BroccoliPrice { get; set; } = .50;
        public double WaterPrice { get; set; } = 2.50;
        public double TomatoPrice { get; set; } = .75;
        public double PeanutButterPrice { get; set; } = 1.75 ;
        public double CocaColaPrice { get; set; } = 3.00;
        public double MnMPrice { get; set; } = 1.00;
        public double SugarPrice { get; set; } = 1.50;

        #endregion

        #region QuantityProperties

        /// <summary>
        /// all properties that store how many of each item a user wants to purchase
        /// </summary>
        public int AppleQuantity
        {
            get => _appleQuantity;
            set
            {

                if (_appleQuantity != value)
                {
                    _appleQuantity = value;
                    OnPropertyChanged("AppleQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int ChickenQuantity
        {
            get => _chickenQuantity;
            set
            {
                if (_chickenQuantity != value)
                {
                    _chickenQuantity = value;
                    OnPropertyChanged("ChickenQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int OrangeQuantity
        {
            get => _orangeQuantity;
            set
            {
                if (_orangeQuantity != value)
                {
                    _orangeQuantity = value;
                    OnPropertyChanged("OrangeQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int CarrotQuantity
        {
            get => _carrotQuantity;
            set
            {
                if (_carrotQuantity != value)
                {
                    _carrotQuantity = value;
                    OnPropertyChanged("CarrotQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int PringleQuantity
        {
            get => _pringleQuantity;
            set
            {
                if (_pringleQuantity != value)
                {
                    _pringleQuantity = value;
                    OnPropertyChanged("PringleQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int CheeseQuantity
        {
            get => _cheeseQuantity;
            set
            {
                if (_cheeseQuantity != value)
                {
                    _cheeseQuantity = value;
                    OnPropertyChanged("CheeseQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int PepperQuantity
        {
            get => _pepperQuantity;
            set
            {
                if (_pepperQuantity != value)
                {
                    _pepperQuantity = value;
                    OnPropertyChanged("PepperQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int AvocadoQuantity
        {
            get => _avocadoQuantity;
            set
            {
                if (_avocadoQuantity != value)
                {
                    _avocadoQuantity = value;
                    OnPropertyChanged("AvocadoQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int DietCokeQuantity
        {
            get => _dietCokeQuantity;
            set
            {
                if (_dietCokeQuantity != value)
                {
                    _dietCokeQuantity = value;
                    OnPropertyChanged("DietCokeQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int PistachioQuantity
        {
            get => _pistachioQuantity;
            set
            {
                if (_pistachioQuantity != value)
                {
                    _pistachioQuantity = value;
                    OnPropertyChanged("PistachioQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int PaperTowelQuantity
        {
            get => _paperTowelQuantity;
            set
            {
                if (_paperTowelQuantity != value)
                {
                    _paperTowelQuantity = value;
                    OnPropertyChanged("PaperTowelQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int CheetoQuantity
        {
            get => _cheetoQuantity;
            set
            {
                if (_cheetoQuantity != value)
                {
                    _cheetoQuantity = value;
                    OnPropertyChanged("CheetoQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int GatoradeQuantity
        {
            get => _gatoradeQuantity;
            set
            {
                if (_gatoradeQuantity != value)
                {
                    _gatoradeQuantity = value;
                    OnPropertyChanged("GatoradeQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int SnickersQuantity
        {
            get => _snickersQuantity;
            set
            {
                if (_snickersQuantity != value)
                {
                    _snickersQuantity = value;
                    OnPropertyChanged("SnickersQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int BroccoliQuantity
        {
            get => _broccoliQuantity;
            set
            {
                if (_broccoliQuantity != value)
                {
                    _broccoliQuantity = value;
                    OnPropertyChanged("BroccoliQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int WaterQuantity
        {
            get => _waterQuantity;
            set
            {
                if (_waterQuantity != value)
                {
                    _waterQuantity = value;
                    OnPropertyChanged("WaterQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int TomatoQuantity
        {
            get => _tomatoQuantity;
            set
            {
                if (_tomatoQuantity != value)
                {
                    _tomatoQuantity = value;
                    OnPropertyChanged("TomatoQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int PeanutButterQuantity
        {
            get => _peanutButterQuantity;
            set
            {
                if (_peanutButterQuantity != value)
                {
                    _peanutButterQuantity = value;
                    OnPropertyChanged("PeanutButterQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int CocaColaQuantity
        {
            get => _cocaColaQuantity;
            set
            {
                if (_cocaColaQuantity != value)
                {
                    _cocaColaQuantity = value;
                    OnPropertyChanged("CocaColaQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int MnMQuantity
        {
            get => _mnMQuantity;
            set
            {
                if (_mnMQuantity != value)
                {
                    _mnMQuantity = value;
                    OnPropertyChanged("MnMQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        public int SugarQuantity
        {
            get => _sugarQuantity;
            set
            {
                if (_sugarQuantity != value)
                {
                    _sugarQuantity = value;
                    OnPropertyChanged("SugarQuantity");
                    OnPropertyChanged("AfterOrderBalance");
                    OnPropertyChanged("OrderTotal");
                }
            }
        }

        #endregion
        #endregion
        #region Public Methods

        /// <summary>
        /// calculates the user's balance with the selected item quantities multiplied by their prices
        /// </summary>
        /// <returns></returns>
        public double BalanceCalculator()
        {
            double NotSubtractedBalance =
            ((AppleQuantity * ApplePrice) +
            (ChickenQuantity * ChickenPrice) +
            (OrangeQuantity * OrangePrice) +
            (CarrotQuantity * CarrotPrice) +
            (PringleQuantity * PringlePrice) +
            (CheeseQuantity * CheesePrice) +
            (PepperQuantity * PepperPrice) +
            (AvocadoQuantity * AvocadoPrice) +
            (DietCokeQuantity * DietCokePrice) +
            (PistachioQuantity * PistachioPrice) +
            (PaperTowelQuantity * PaperTowelPrice) +
            (CheetoQuantity * CheetoPrice) +
            (GatoradeQuantity * GatoradePrice) +
            (SnickersQuantity * SnickersPrice) +
            (BroccoliQuantity * BroccoliPrice) +
            (WaterQuantity * WaterPrice) +
            (TomatoQuantity * TomatoPrice) +
            (PeanutButterQuantity * PeanutButterPrice) +
            (CocaColaQuantity * CocaColaPrice) +
            (MnMQuantity * MnMPrice) +
            (SugarQuantity * SugarPrice));

            return NotSubtractedBalance;
        }
        
        /// <summary>
        /// calculates what the user's balance will be if they purchase the selected items
        /// </summary>
        public double AfterOrderBalanceCalculator()
        {
            return Balance - BalanceCalculator();
        }

        /// <summary>
        /// if user finishes purchase, we clear all quantity textboxes in preparation for new order
        /// </summary>
        public void ResetPurchase()
        {
            AppleQuantity = 0;
            ChickenQuantity = 0;
            OrangeQuantity = 0;
            CarrotQuantity = 0;
            PringleQuantity = 0;
            CheeseQuantity = 0;
            PepperQuantity = 0;
            AvocadoQuantity = 0;
            DietCokeQuantity = 0;
            PistachioQuantity = 0;
            PaperTowelQuantity = 0;
            CheetoQuantity = 0;
            GatoradeQuantity = 0;
            SnickersQuantity = 0;
            BroccoliQuantity = 0;
            WaterQuantity = 0;
            TomatoQuantity = 0;
            PeanutButterQuantity = 0;
            CocaColaQuantity = 0;
            MnMQuantity = 0;
            SugarQuantity = 0;
        }

        public void OpenLoginWindow()
        {
            LoginPage LoginPage = new LoginPage();
            LoginPage.Show();
        }

        public void UserLoggedIn()
        {
            this.IsLoggedIn = true;
            OnPropertyChanged(nameof(IsLoggedIn));
        }

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