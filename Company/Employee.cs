using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Employee
    {
        private string name;
        private decimal salary, bonus;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public decimal Bonus
        {
            get { return bonus; }
        }

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        public decimal ToPay()
        {
            return Salary + bonus;
        }

        public override string ToString()
        {
            return $"{Name, -10}(employee)    salay: {Salary,-10} bonus: {Bonus,-7} total: {ToPay()} ";
        }

    }
}
