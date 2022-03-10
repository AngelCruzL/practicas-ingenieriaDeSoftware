using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFcruzlara
{
    public partial class Form1 : Form
    {
        double value_1, value_2, result;
        BasicCalculator calculator;
        string message;

        public Form1()
        {
            InitializeComponent();
            output.Items.Clear();
            messageLabel.Text = "";
            calculator = new BasicCalculator();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        public void PrepareInput()
        {
            try
            {
                value_1 = double.Parse(input1.Text);
                value_2 = double.Parse(input2.Text);
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void PrepareOutput(double res)
        {
            output.Items.Add(res);
            messageLabel.Text = message;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.Subtraction(value_1, value_2, ref result);
            PrepareOutput(result);
        }

        private void division_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.Division(value_1, value_2, ref result);
            PrepareOutput(result);
        }

        private void exponential_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.Exponential(value_1, value_2, ref result);
            PrepareOutput(result);
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.Factorial(value_1, ref result);
            PrepareOutput(result);
        }

        private void sen_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.SenFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CosFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.TanFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void cot_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CotFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void sec_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.SecFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void csc_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CscFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void senh_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.SenhFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CoshFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.TanhFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void coth_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CothFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void sech_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.SechFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void csch_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CschFunction(value_1, ref result);
            PrepareOutput(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.Multiplication(value_1, value_2, ref result);
            PrepareOutput(result);
        }  

        private void sum_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.Sum(value_1, value_2, ref result);
            PrepareOutput(result);
        }
    }
}
