using System;
using System.Collections.Generic;
using System.Text;

namespace DepositsInterface
{
    public abstract class Deposit : IComparable
    {
        protected double startSum;
        protected double amount;
        protected int period;

        public abstract string Type { get; }

        public double StartSum 
        {
            get { return startSum; }
        }

        public abstract double Amount { get; }

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

        public int CompareTo(Deposit deposit)
        {
            return Amount.CompareTo(deposit.Amount);
        }

        public int CompareTo(object obj)
        {
            return (obj as Deposit).Amount.CompareTo(Amount);
        }
    }
}
