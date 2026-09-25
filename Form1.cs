namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultText_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;
            if (double.TryParse(txtFirstNumber.Text, out firstNumber) &&
            double.TryParse(txtSecondNumber.Text, out secondNumber))
            {
                result = firstNumber + secondNumber;
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(
                "Please enter valid numbers.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;
            if (double.TryParse(txtFirstNumber.Text, out firstNumber) &&
                double.TryParse(txtSecondNumber.Text, out secondNumber))
            {
                result = firstNumber - secondNumber;
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(
                "Please enter valid numbers.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;
            if (double.TryParse(txtFirstNumber.Text, out firstNumber) &&
            double.TryParse(txtSecondNumber.Text, out secondNumber))
            {
                result = firstNumber * secondNumber;
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(
                "Please enter valid numbers.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;
            if (double.TryParse(txtFirstNumber.Text, out firstNumber) &&
            double.TryParse(txtSecondNumber.Text, out secondNumber))
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show(
                    "Cannot divide by zero.",
                    "Calculation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return;
                }
                result = firstNumber / secondNumber;
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(
                "Please enter valid numbers.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
        );
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            lblResult.Text = "0";
            txtFirstNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit Calculator",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
