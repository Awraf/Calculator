using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private float? result = null;
        private string lastOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            CalcResult(this.add.Text);
        }

        private void CalcResult(string text)
        {
            try
            {
                var value = float.Parse(this.inputValue.Text);

                lastOperation = text;

                if (!result.HasValue)
                {
                    result = (text != "/" || text != "*") ? 0: 1;
                }

                switch (text)
                {
                    case "+":
                        result += value;
                        break;
                    case "-":
                        result -= value;
                        break;
                    case "*":
                        result *= value;
                        break;
                    case "/":
                        if (value > 0)
                        {
                            result /= value;
                        }
                        break;
                    default:
                        result = value;
                        break;
                }

                this.inputValue.Text = string.Empty;
            }
            catch
            {
                this.inputValue.Text = "";
                MessageBox.Show("Operation error. Please enter valid value.");
            }

            this.inputValue.Focus();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            CalcResult(this.mult.Text);
        }

        private void diff_Click(object sender, EventArgs e)
        {
            CalcResult(this.diff.Text);
        }

        private void dev_Click(object sender, EventArgs e)
        {
            CalcResult(this.dev.Text);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            CalcResult(lastOperation);

            if (!result.HasValue)
            {
                MessageBox.Show($"Please enter value.");
                this.inputValue.Focus();
            }
            else
            {
                MessageBox.Show($"Result: {result}");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result = null;
            this.inputValue.Text = "";
        }

        private void inputValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
