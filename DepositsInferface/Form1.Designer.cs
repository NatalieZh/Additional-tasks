
namespace DepositsInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdDeposits = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.numPeriod = new System.Windows.Forms.NumericUpDown();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMaxIncome = new System.Windows.Forms.Label();
            this.lblProlongable = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.DepositNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prolongable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeposits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDeposits
            // 
            this.grdDeposits.AllowUserToAddRows = false;
            this.grdDeposits.AllowUserToDeleteRows = false;
            this.grdDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeposits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepositNumber,
            this.DepositType,
            this.StartSumm,
            this.Period,
            this.Prolongable,
            this.Income,
            this.TotalAmount,
            this.Delete});
            this.grdDeposits.Location = new System.Drawing.Point(12, 213);
            this.grdDeposits.Name = "grdDeposits";
            this.grdDeposits.ReadOnly = true;
            this.grdDeposits.RowHeadersWidth = 62;
            this.grdDeposits.RowTemplate.Height = 33;
            this.grdDeposits.Size = new System.Drawing.Size(1201, 538);
            this.grdDeposits.TabIndex = 1;
            this.grdDeposits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDeposits_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.numPeriod);
            this.groupBox1.Controls.Add(this.numAmount);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Deposit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMessage);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(18, 31);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(548, 25);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "If you want to create a deposit, add all fileds and click \"Add\" button";
            // 
            // numPeriod
            // 
            this.numPeriod.Location = new System.Drawing.Point(618, 34);
            this.numPeriod.Name = "numPeriod";
            this.numPeriod.Size = new System.Drawing.Size(180, 31);
            this.numPeriod.TabIndex = 7;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(342, 35);
            this.numAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(181, 31);
            this.numAmount.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Base",
            "Special",
            "LongTerm"});
            this.cmbType.Location = new System.Drawing.Point(61, 34);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(182, 33);
            this.cmbType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblMaxIncome);
            this.groupBox3.Controls.Add(this.lblProlongable);
            this.groupBox3.Controls.Add(this.lblTotalIncome);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(834, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 196);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additiona info";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "More info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMaxIncome
            // 
            this.lblMaxIncome.AutoSize = true;
            this.lblMaxIncome.Location = new System.Drawing.Point(137, 71);
            this.lblMaxIncome.Name = "lblMaxIncome";
            this.lblMaxIncome.Size = new System.Drawing.Size(67, 25);
            this.lblMaxIncome.TabIndex = 2;
            this.lblMaxIncome.Text = "           ";
            // 
            // lblProlongable
            // 
            this.lblProlongable.AutoSize = true;
            this.lblProlongable.Location = new System.Drawing.Point(137, 102);
            this.lblProlongable.Name = "lblProlongable";
            this.lblProlongable.Size = new System.Drawing.Size(67, 25);
            this.lblProlongable.TabIndex = 2;
            this.lblProlongable.Text = "           ";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(137, 37);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(0, 25);
            this.lblTotalIncome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prolongable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Income";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(271, 163);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(237, 37);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort deposits";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // DepositNumber
            // 
            this.DepositNumber.HeaderText = "#";
            this.DepositNumber.MinimumWidth = 8;
            this.DepositNumber.Name = "DepositNumber";
            this.DepositNumber.ReadOnly = true;
            this.DepositNumber.Width = 50;
            // 
            // DepositType
            // 
            this.DepositType.HeaderText = "Deposit Type";
            this.DepositType.MinimumWidth = 8;
            this.DepositType.Name = "DepositType";
            this.DepositType.ReadOnly = true;
            this.DepositType.Width = 170;
            // 
            // StartSumm
            // 
            this.StartSumm.HeaderText = "Start Summ";
            this.StartSumm.MinimumWidth = 8;
            this.StartSumm.Name = "StartSumm";
            this.StartSumm.ReadOnly = true;
            this.StartSumm.Width = 150;
            // 
            // Period
            // 
            this.Period.HeaderText = "Period";
            this.Period.MinimumWidth = 8;
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // Prolongable
            // 
            this.Prolongable.HeaderText = "Prolongable";
            this.Prolongable.MinimumWidth = 8;
            this.Prolongable.Name = "Prolongable";
            this.Prolongable.ReadOnly = true;
            this.Prolongable.Width = 120;
            // 
            // Income
            // 
            this.Income.HeaderText = "Income";
            this.Income.MinimumWidth = 8;
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            this.Income.Width = 150;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 8;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 170;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 763);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDeposits);
            this.Name = "Form1";
            this.Text = "Deposits";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeposits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdDeposits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPeriod;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProlongable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prolongable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

