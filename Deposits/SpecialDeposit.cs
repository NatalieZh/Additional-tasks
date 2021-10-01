using System;
using System.Collections.Generic;
using System.Text;

namespace Deposits
{
    class SpecialDeposit : Deposit
    {
        private const string type = "Special";

        public override string Type
        {
            get { return type; }
        }

        public SpecialDeposit(double depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override double Income()
        {
            amount = startSum;
            for (int i = 1; i <= Period; i++)
            {
                amount += amount * i / 100;
            }
            amount = Math.Round(amount, 2);
            return Math.Round(amount - startSum, 2);
        }
    }
}
