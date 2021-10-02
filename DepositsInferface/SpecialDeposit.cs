using System;
using System.Collections.Generic;
using System.Text;

namespace DepositsInterface
{
    class SpecialDeposit : Deposit, IProlongable
    {
        private const string type = "Special";

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
                    amount += amount * i / 100;
                }
                return Math.Round(amount, 2);
            }
        }

        public SpecialDeposit(double depositAmount, int depositPeriod) : base(depositAmount, depositPeriod) { }

        public override double Income()
        {
            return Math.Round(Amount - startSum, 2);
        }

        public bool CanToProlong()
        {
            return (startSum > 1000);
        }
    }
}
