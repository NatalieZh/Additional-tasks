using System;
using System.Collections.Generic;
using System.Text;

namespace DepositsInterface
{
    public class BaseDeposit : Deposit
    {
        private const string type = "Base";
        public BaseDeposit(double depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override string Type
        {
            get { return type; }
        }

        public override double Amount
        {
            get 
            { 
                amount = startSum;
                for (int i = 1; i <= Period; i++)
                {
                    amount += amount* 5 / 100;
                }
                return Math.Round(amount, 2);
            }
        }

        public override double Income()
        {
            return Math.Round(Amount - startSum, 2);
        }
    }
}
