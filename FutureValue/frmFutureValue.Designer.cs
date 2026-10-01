namespace FutureValue
{
    partial class frmFutureValue
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
            label1 = new Label();
            txtMonthlyInvestment = new TextBox();
            label2 = new Label();
            txtInterestRate = new TextBox();
            label3 = new Label();
            txtYears = new TextBox();
            label4 = new Label();
            txtFutureValue = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Monthly Investment:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new Point(158, 12);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new Size(100, 23);
            txtMonthlyInvestment.TabIndex = 1;
            txtMonthlyInvestment.TextChanged += ClearFutureValue;
            txtMonthlyInvestment.MouseHover += ClearFutureValue;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 44);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Yearly Interest Rate:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(158, 41);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(100, 23);
            txtInterestRate.TabIndex = 3;
            txtInterestRate.TextChanged += ClearFutureValue;
            txtInterestRate.DoubleClick += txtInterestRate_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 73);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "Number of Years:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(158, 70);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(100, 23);
            txtYears.TabIndex = 5;
            txtYears.TextChanged += ClearFutureValue;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 102);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Future Value:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(158, 99);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new Size(100, 23);
            txtFutureValue.TabIndex = 7;
            txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(93, 137);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(183, 137);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmFutureValue
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(280, 174);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtFutureValue);
            Controls.Add(label4);
            Controls.Add(txtYears);
            Controls.Add(label3);
            Controls.Add(txtInterestRate);
            Controls.Add(label2);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(label1);
            Name = "frmFutureValue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Future Value";
            Load += frmFutureValue_Load;
            DoubleClick += frmFutureValue_DoubleClick_1;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtMonthlyInvestment;
        private Label label2;
        private TextBox txtInterestRate;
        private Label label3;
        private TextBox txtYears;
        private Label label4;
        private TextBox txtFutureValue;
        private Button btnCalculate;
        private Button btnExit;
    }
}