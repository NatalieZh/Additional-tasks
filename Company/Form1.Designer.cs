
namespace Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabCompany = new System.Windows.Forms.TabControl();
            this.pageCompany = new System.Windows.Forms.TabPage();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btnDefaultBonus = new System.Windows.Forms.Button();
            this.lblMaxSalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfEmployees = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabCompany.SuspendLayout();
            this.pageCompany.SuspendLayout();
            this.listOfEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.pageCompany);
            this.tabCompany.Location = new System.Drawing.Point(9, 8);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.SelectedIndex = 0;
            this.tabCompany.Size = new System.Drawing.Size(896, 671);
            this.tabCompany.TabIndex = 0;
            // 
            // pageCompany
            // 
            this.pageCompany.Controls.Add(this.btnBonus);
            this.pageCompany.Controls.Add(this.btnDefaultBonus);
            this.pageCompany.Controls.Add(this.lblMaxSalary);
            this.pageCompany.Controls.Add(this.label1);
            this.pageCompany.Controls.Add(this.listOfEmployees);
            this.pageCompany.Location = new System.Drawing.Point(4, 34);
            this.pageCompany.Name = "pageCompany";
            this.pageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.pageCompany.Size = new System.Drawing.Size(888, 633);
            this.pageCompany.TabIndex = 0;
            this.pageCompany.Text = "Company";
            this.pageCompany.UseVisualStyleBackColor = true;
            // 
            // btnBonus
            // 
            this.btnBonus.Location = new System.Drawing.Point(212, 18);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(180, 34);
            this.btnBonus.TabIndex = 4;
            this.btnBonus.Text = "bonus 1500";
            this.btnBonus.UseVisualStyleBackColor = true;
            this.btnBonus.Click += new System.EventHandler(this.btnBonus_Click);
            // 
            // btnDefaultBonus
            // 
            this.btnDefaultBonus.Location = new System.Drawing.Point(24, 18);
            this.btnDefaultBonus.Name = "btnDefaultBonus";
            this.btnDefaultBonus.Size = new System.Drawing.Size(147, 35);
            this.btnDefaultBonus.TabIndex = 3;
            this.btnDefaultBonus.Text = "default bonus";
            this.btnDefaultBonus.UseVisualStyleBackColor = true;
            this.btnDefaultBonus.Click += new System.EventHandler(this.btnDefaultBonus_Click);
            // 
            // lblMaxSalary
            // 
            this.lblMaxSalary.AutoSize = true;
            this.lblMaxSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxSalary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaxSalary.Location = new System.Drawing.Point(271, 74);
            this.lblMaxSalary.Name = "lblMaxSalary";
            this.lblMaxSalary.Size = new System.Drawing.Size(121, 30);
            this.lblMaxSalary.TabIndex = 2;
            this.lblMaxSalary.Text = "                  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max salary has: ";
            // 
            // listOfEmployees
            // 
            this.listOfEmployees.Controls.Add(this.textBox1);
            this.listOfEmployees.Location = new System.Drawing.Point(5, 120);
            this.listOfEmployees.Name = "listOfEmployees";
            this.listOfEmployees.Size = new System.Drawing.Size(882, 512);
            this.listOfEmployees.TabIndex = 0;
            this.listOfEmployees.TabStop = false;
            this.listOfEmployees.Text = "List of all employees";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(870, 499);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 684);
            this.Controls.Add(this.tabCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MyCompany";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCompany.ResumeLayout(false);
            this.pageCompany.ResumeLayout(false);
            this.pageCompany.PerformLayout();
            this.listOfEmployees.ResumeLayout(false);
            this.listOfEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCompany;
        private System.Windows.Forms.TabPage pageCompany;
        private System.Windows.Forms.GroupBox listOfEmployees;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxSalary;
        private System.Windows.Forms.Button btnDefaultBonus;
        private System.Windows.Forms.Button btnBonus;
    }
}

