using System;
using System.Collections.Generic;
using System.Text;

namespace Deposits
{
    public abstract class Deposit
    {
        protected double startSum;
        protected double amount;
        protected int period;

        public abstract string Type { get; }

        public double StartSum 
        {
            get { return startSum; }
        }

        public double Amount
        {
            get { return amount; }
        }

        public int Period
        {
            get { return period; }
        }

        public Deposit(double depositAmount, int depositPeriod)
        {
            startSum = depositAmount;
            period = depositPeriod;
        }

        public abstract double Income();

    }
}
