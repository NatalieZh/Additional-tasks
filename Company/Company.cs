using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Company
    {
        private Employee[] employees;
        private const decimal defaultBonus = 1000;

        public  Employee[] Employees
        {
            get { return employees; }
        }

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public Company(int amountOfEmployees)
        {
            employees =  new Employee[amountOfEmployees];
        }

        public void GiveEverybobyBonus(decimal companyBonus)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    employees[i].SetBonus(companyBonus);
                }
            }
        }

        public void GiveEverybobyBonus()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    employees[i].SetBonus(defaultBonus);
                }
            }
        }

        public decimal TotalToPay()
        {
            decimal total = 0;

            foreach (Employee employee in employees) 
            {
                total += employee != null ? employee.ToPay() : 0;               
            }
            
            return total;
        }

        public string NameMaxSalary()
        {
            string name = string.Empty;
            decimal maxSalary = 0;

            foreach (Employee employee in employees)
            {
                if(employee != null)
                {
                    if (employee.ToPay() > maxSalary) 
                    { 
                        maxSalary = employee.ToPay();
                        name = employee.Name;
                    }
                    
                }
            }
            return name;
        }

        public string GetAllEmployees()
        {
            string result = string.Empty;

            foreach (Employee employee in employees)
            {
                
                result += (employee != null) ?  employee.ToString()+ System.Environment.NewLine : "";
            }

            return result;
        }

    }
}
