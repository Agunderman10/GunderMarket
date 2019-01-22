using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GunderMarket
{
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

        public void FinishDepositChecks()
        {
            MainWindow.mainWindowViewModel.CloseDepositWindow();
        }
    }
}
