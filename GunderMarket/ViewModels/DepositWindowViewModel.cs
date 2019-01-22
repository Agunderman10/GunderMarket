namespace GunderMarket
{
    using System.Windows.Input;

    public class DepositWindowViewModel
    {
        private double _depositAmount;
        
        public double DepositAmount
        {
            get { return _depositAmount; }
            set
            {
                if(_depositAmount != value)
                {
                    _depositAmount = value;
                }
            }
        }

        public ICommand FinishDeposit
        {
            get { return new ButtonCommands(FinishDepositChecks); }
        }

        private void FinishDepositChecks()
        {
            MainWindow.mainWindowViewModel.CloseDepositWindow();
        }
    }
}
