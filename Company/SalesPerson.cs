using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class SalesPerson : Employee
    {
        private int percent;

        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
            this.percent = percent;
        }

        public int Percent
        {
            get { return percent; }
            set { percent = value;  }       
        }

        public override void SetBonus(decimal bonus)
        {
            if (percent > 100 && percent <= 200)
            {
                base.SetBonus(bonus * 2);
            }
            else if (percent > 200)
            {
                base.SetBonus(bonus * 3);
            }
            else
            {
                base.SetBonus(bonus);
            }
        }

        public override string ToString()
        {
            return $"{Name, -10}(sales)    percent: {percent,-7} salay: {Salary,-10} bonus: {Bonus,-7} total: {ToPay()} ";
        }
    }
}
