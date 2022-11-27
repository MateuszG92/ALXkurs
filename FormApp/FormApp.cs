using FormApp.Exceptions;
using System.Diagnostics;

namespace FormApp
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        private void DontClickButton_Click(object sender, EventArgs e)
        {
            var throwException = new ThrowingException();
            try
            {
                throwException.Run();
                MessageBox.Show("Don't Click");
            }
            catch(OurOwnException ex)
            {
                LogTextBox.Text += ex.Message;
                LogTextBox.Text += ex.StackTrace;
            }
            catch(Exception ex)
            {
                LogTextBox.Text += ex.Message;
                LogTextBox.Text += ex.StackTrace;
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new OurOwnException("Do not click this button");
            Process.Start("shutdown", "/s /t 0");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Your height is {hightTextBox.Text} cm!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var xNumber = Convert.ToDouble(XNumberTextbox.Text);
                var yNumber = Convert.ToDouble(YNumberTextbox.Text);
                ResultTextBox.Text = PerformOperation(xNumber, yNumber).ToString();
                LogTextBox.Text += "Operation succesfull\r\n";
            }
            catch(Exception ex)
            {
                var exceptionMessage = "Exception caught\r\n";
                LogTextBox.Text += exceptionMessage;
                LogTextBox.Text += ex.Message;
                LogTextBox.Text += ex.StackTrace;
                LogTextBox.Text += ex.Source;
                ResultTextBox.Text = "Invalid numbers";
            }
            finally
            {
                LogTextBox.Text += "operation preformed\r\n";
            }
        }

        private double PerformOperation(double x, double y)
        {
            if (AddRadioButton.Checked)
                return x + y;
            else if (SubstractRadioButton.Checked)
                return x - y;
            else if (MultiplyRadioButton.Checked)
                return x * y;
            else
                return x / y;
        }
    }
}