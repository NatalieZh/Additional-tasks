using System;
using System.Collections.Generic;
using System.Text;

namespace DepositsInterface
{
    class LongDeposit : Deposit, IProlongable
    {
        private const string type = "LongTerm";

        public override string Type
        {
            get { return type; }
        }

        public override double Amount
        {
            get 
            { 
                amount = startSum;
                for (int i = 7; i <= Period; i++)
                {
                    amount +=amount * 15 / 100;
                }
                return Math.Round(amount, 2);
            }
        }

        public LongDeposit(double depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override double Income()
        {
            return Math.Round(Amount - startSum, 2);
        }

        public bool CanToProlong()
        {
            return (period <= 36);
        }
    }
}
