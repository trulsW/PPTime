using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTime
{
    public class CashRegister
    {
        public int _TotalCashBalance { get; set; }
        public int _Change { get; set; }
        public int _CashPayment { get;  set; }
        public decimal _TotalBalance { get;  set; }
        public decimal _Returns { get;  set; }

        public PaymentTerminal paymentTerminal = new PaymentTerminal(0, 0);

        public CashRegister()
        {

        }

        public CashRegister(int totalCashBalance, int change, decimal totalBalance, int cashPayment, decimal returns)
        {
            _TotalCashBalance = 500 + cashPayment;
            _Change = 500;
            _CashPayment = cashPayment;
            _TotalBalance = _TotalCashBalance + paymentTerminal.TotalBankBalance;
            _Returns = returns;
        }

        public void ShowTotalBalance()
        {
            Console.WriteLine($"The total balance is: {_TotalBalance}");
        }

        public void ShowTodaysProfit()
        {
            var todaysProfit = _TotalBalance - _Change;
            Console.WriteLine($"Today's profit is: {todaysProfit}");
        }
    }
}
