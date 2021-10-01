using System;
using System.Collections.Generic;
using System.Text;

namespace Deposits
{
    public class BaseDeposit : Deposit
    {
        private const string type = "Base";
        public BaseDeposit(double depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override string Type
        {
            get { return type; }
        }

        public override double Income()
        {
            amount = startSum;
            for (int i = 1; i <= Period; i++)
            {
                amount += amount * 5 / 100;
            }
            amount = Math.Round(amount, 2);
            return Math.Round(amount - startSum, 2);
        }
    }
}
