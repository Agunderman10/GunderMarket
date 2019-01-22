using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GunderMarket
{
    public class WithdrawWindowViewModel
    {
        private double _withdrawAmount;

        public double WithdrawAmount
        {
            get { return this._withdrawAmount; }
            set
            {
                if(this._withdrawAmount != value)
                {
                    this._withdrawAmount = value;
                }
            }
        }

        public ICommand FinishWithdraw
        {
            get { return new ButtonCommands(FinishWithdrawChecks); }
        }

        public void FinishWithdrawChecks()
        {
            MainWindow.mainWindowViewModel.CloseWithdrawWindow();
        }
    }
}
