namespace SimpleCalculator
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
            lblTitle = new Label();
            lblFirstNumber = new Label();
            txtFirstNumber = new TextBox();
            lblSecondNumber = new Label();
            txtSecondNumber = new TextBox();
            lblResultText = new Label();
            lblResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(87, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SIMPLE CALCULATOR";
            // 
            // lblFirstNumber
            // 
            lblFirstNumber.AutoSize = true;
            lblFirstNumber.Location = new Point(45, 92);
            lblFirstNumber.Name = "lblFirstNumber";
            lblFirstNumber.Size = new Size(97, 20);
            lblFirstNumber.TabIndex = 1;
            lblFirstNumber.Text = "First Number:";
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new Point(148, 89);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(88, 27);
            txtFirstNumber.TabIndex = 2;
            // 
            // lblSecondNumber
            // 
            lblSecondNumber.AutoSize = true;
            lblSecondNumber.Location = new Point(23, 123);
            lblSecondNumber.Name = "lblSecondNumber";
            lblSecondNumber.Size = new Size(119, 20);
            lblSecondNumber.TabIndex = 3;
            lblSecondNumber.Text = "Second Number:";
            lblSecondNumber.Click += label1_Click;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(148, 120);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(88, 27);
            txtSecondNumber.TabIndex = 4;
            // 
            // lblResultText
            // 
            lblResultText.AutoSize = true;
            lblResultText.Location = new Point(67, 269);
            lblResultText.Name = "lblResultText";
            lblResultText.Size = new Size(52, 20);
            lblResultText.TabIndex = 5;
            lblResultText.Text = "Result:";
            lblResultText.Click += lblResultText_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(125, 269);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(17, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(48, 177);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "btnAdd";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(lblResultText);
            Controls.Add(txtSecondNumber);
            Controls.Add(lblSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(lblFirstNumber);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFirstNumber;
        private TextBox txtFirstNumber;
        private Label lblSecondNumber;
        private TextBox txtSecondNumber;
        private Label lblResultText;
        private Label lblResult;
        private Button button1;
    }
}
