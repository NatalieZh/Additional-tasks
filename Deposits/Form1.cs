using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //temp check
            BaseDeposit dep1 = new BaseDeposit(1000, 5);
            textBox1.Text += dep1.Income().ToString() + System.Environment.NewLine;
            SpecialDeposit dep2 = new SpecialDeposit(1000, 5);
            textBox1.Text += dep2.Income().ToString() + System.Environment.NewLine;
            LongDeposit dep3 = new LongDeposit(1000, 5);
            textBox1.Text += dep3.Income().ToString() + System.Environment.NewLine;
            LongDeposit dep4 = new LongDeposit(1000, 6);
            textBox1.Text += dep4.Income().ToString() + System.Environment.NewLine;
            LongDeposit dep5 = new LongDeposit(1000, 10);
            textBox1.Text += dep5.Income().ToString() + System.Environment.NewLine;

            Client client = new Client();
            client.AddDeposit(new BaseDeposit(1000, 5));
            client.AddDeposit(new SpecialDeposit(1000, 5));
            client.AddDeposit(new LongDeposit(1000, 5));
            client.AddDeposit(new LongDeposit(1000, 6));
            client.AddDeposit(new LongDeposit(1000, 5));
            client.AddDeposit(new LongDeposit(1000, 10));

            textBox1.Text += "Client info" + System.Environment.NewLine;
            textBox1.Text += client.GetClientDeposits() + System.Environment.NewLine;
            textBox1.Text += "TotalIncome" + System.Environment.NewLine;
            textBox1.Text += client.TotalIncome() + System.Environment.NewLine;
            textBox1.Text += "MaxIncome" + System.Environment.NewLine;
            textBox1.Text += client.MaxIncome() + System.Environment.NewLine;
            textBox1.Text += "GetIncomeByNumber 8" + System.Environment.NewLine;
            textBox1.Text += client.GetIncomeByNumber(8) + System.Environment.NewLine;
            textBox1.Text += "GetIncomeByNumber 2" + System.Environment.NewLine;
            textBox1.Text += client.GetIncomeByNumber(2) + System.Environment.NewLine;

        }
    }
}
