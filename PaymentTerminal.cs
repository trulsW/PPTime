using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTime
{
    public class PaymentTerminal
    {
        public decimal TotalBankBalance { get; private set; }
        public decimal Payment { get; set; }

        public PaymentTerminal(decimal totalBankBalance, decimal payment)
        {
            TotalBankBalance = 0 + payment;
            Payment = payment;
        }

        
    }
}
