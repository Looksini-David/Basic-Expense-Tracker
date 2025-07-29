namespace Basic_Expense_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstExpenses
            // 
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.ItemHeight = 16;
            this.lstExpenses.Location = new System.Drawing.Point(72, 287);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.Size = new System.Drawing.Size(571, 100);
            this.lstExpenses.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(325, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(324, 126);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(337, 201);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(121, 43);
            this.btnAddExpense.TabIndex = 3;
            this.btnAddExpense.Text = "button1";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.BtnAddExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Des";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(329, 169);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lstExpenses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstExpenses;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

