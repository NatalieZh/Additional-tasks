using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Form1 : Form
    {
        Employee[] staff = new Employee[20];
        Company myCompany;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load company staff
            //Managers
            staff[0] = new Manager("Peterson", 8000, 70);
            staff[1] = new Manager("Ivanov", 8000, 170);
            staff[2] = new Manager("Petrov", 8000, 20);
            staff[3] = new Manager("Sidorov", 8000, 121);
            staff[4] = new Manager("Chernova", 8000, 77);
            //sales persons
            staff[5] = new SalesPerson("Kruzhkova", 7000, 77);
            staff[6] = new SalesPerson("Melova", 7000, 120);
            staff[7] = new SalesPerson("Krum", 7000, 180);
            staff[8] = new SalesPerson("Simon", 7000, 50);
            staff[8] = new SalesPerson("Cat", 7000, 250);
            staff[10] = new SalesPerson("Dog", 7000, 131);
            staff[11] = new SalesPerson("Mouse", 7000, 157);
            // other staff
            staff[11] = new Employee("Trumov", 5000);
            staff[12] = new Employee("Seryj", 5000);
            staff[13] = new Employee("Shalin", 5000);
            staff[14] = new Employee("Shedy", 5000);
            staff[15] = new Employee("Krasny", 5000);
            staff[15] = new Employee("Ivanova", 5000);
            staff[16] = new Employee("Petrova", 5000);
            staff[17] = new Employee("Sidorova", 5000);
            staff[18] = new Employee("Peter", 5000);
            staff[19] = new Employee("Bromel", 5000);

            myCompany = new Company(staff);

            GetInfo();
        }

        private void GetInfo()
        {
            textBox1.Text = myCompany.GetAllEmployees();
            lblMaxSalary.Text = myCompany.NameMaxSalary();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDefaultBonus_Click(object sender, EventArgs e)
        {
            myCompany.GiveEverybobyBonus();
            GetInfo();
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            myCompany.GiveEverybobyBonus(1500);
            GetInfo();
        }
    }
}
