using System;
using System.Collections.Generic;
using System.Text;

namespace Deposits
{
    class Client
    {
        //15.20  stoped
        // 15.30 start
        //end 15:40

        private Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            bool result = false;
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    result = true;
                    break;
                }
            }
            return result;
        }

        public double TotalIncome()
        {
            double result = 0;
            for (int i = 0; i < deposits.Length; i++)
            {
                result += deposits[i] != null ? deposits[i].Income() : 0;
            }
            return result;
        }

        public double MaxIncome()
        {
            double maxIncome = 0;
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null && deposits[i].Income() > maxIncome)
                {
                    maxIncome = deposits[i].Income();
                }
            }
            return maxIncome;
        }

        public double GetIncomeByNumber(int number)
        {
            return deposits[number] != null ? deposits[number].Income() : 0;
        }

        public string GetClientDeposits()
        {
            string info = string.Empty;
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    info += $"Deposit #{i} - nothing" + System.Environment.NewLine;
                }
                else
                {
                    info += $"Deposit #{i} - start: {deposits[i].StartSum}, income: {deposits[i].Income()}, amount: {deposits[i].Amount}" + System.Environment.NewLine;
                }
            }

            return info;
        }
    }
}
