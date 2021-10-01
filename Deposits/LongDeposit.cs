using System;
using System.Collections.Generic;
using System.Text;

namespace Deposits
{
    class LongDeposit : Deposit
    {
        private const string type = "LongTerm";

        public override string Type
        {
            get { return type; }
        }

        public LongDeposit(double depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override double Income()
        {
            amount = startSum;
            for (int i = 7; i <= Period; i++)
            {
                amount +=amount * 15 / 100;
            }
            amount = Math.Round(amount, 2);
            return Math.Round(amount - startSum, 2);
        }
    }
}
