using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Expense_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddExpense_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text.Trim();
            string amountText = txtAmount.Text.Trim();

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description cannot be empty.");
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a positive number.");
                return;
            }
            DateTime date = dtpDate.Value;
            string expenseEntry = $"{date.ToShortDateString()} - {description} - {amount:C}";
            lstExpenses.Items.Add(expenseEntry);

            txtDescription.Clear();
            txtAmount.Clear();

        }
    }
}
