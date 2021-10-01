﻿using System;
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

        Client client = new Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void  GridLoad()
        {
            grdDeposits.Rows.Clear();
            for (int i = 0; i < client.Deposits.Length; i++)
            {
                Deposit tmpDeposit = client.Deposits[i];
                if (tmpDeposit != null)
                {
                    grdDeposits.Rows.Add(i + 1, tmpDeposit.Type, tmpDeposit.StartSum, tmpDeposit.Period, tmpDeposit.Income(), tmpDeposit.Amount);
                }
                else
                {
                    grdDeposits.Rows.Add(i + 1, "");

                }
            }

        }

        private void grdDeposits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                client.DeleteDeposit(e.RowIndex);
            }
            LoadInfo();
        }

        private void LoadInfo()
        {
            GridLoad();
            lblTotalIncome.Text = client.TotalIncome().ToString();
            lblMaxIncome.Text = client.MaxIncome().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cmbType.SelectedIndex == -1)
            {
                lblMessage.Text = "Select type!";
                lblMessage.ForeColor = Color.Red;
                error = true;
            }

            if (numAmount.Value == 0)
            {
                lblMessage.Text += " Enter Amount!";
                lblMessage.ForeColor = Color.Red;
                error = true;
            }
            if (numPeriod.Value == 0)
            {
                lblMessage.Text += " Enter Period!";
                lblMessage.ForeColor = Color.Red;
                error = true;
            }
            if (!error)
            {
                switch (cmbType.SelectedItem)
                {
                    case "Base":
                        client.AddDeposit(new BaseDeposit((double)numAmount.Value, (int)numPeriod.Value));
                        break;
                    case "Special":
                        client.AddDeposit(new SpecialDeposit((double)numAmount.Value, (int)numPeriod.Value));
                        break;
                    case "LongTerm":
                        client.AddDeposit(new LongDeposit((double)numAmount.Value, (int)numPeriod.Value));
                        break;
                }
                LoadInfo();
            }
        }
    }
}
