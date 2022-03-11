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
        string message, value_function_x, value_function_xy;

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
                value_function_x = inputFx.Text;
                value_function_xy = inputFxy.Text;
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

        private void x2_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 2, ref result);
            PrepareOutput(result);
        }

        private void x3_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 3, ref result);
            PrepareOutput(result);
        }

        private void x4_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 4, ref result);
            PrepareOutput(result);
        }

        private void x5_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 5, ref result);
            PrepareOutput(result);
        }

        private void x6_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 6, ref result);
            PrepareOutput(result);
        }

        private void x7_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 7, ref result);
            PrepareOutput(result);
        }

        private void x8_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 8, ref result);
            PrepareOutput(result);
        }

        private void x9_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.ElevateTo(value_1, 9, ref result);
            PrepareOutput(result);
        }

        private void x10_1_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 1, ref result);
            PrepareOutput(result);
        }

        private void x10_2_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 2, ref result);
            PrepareOutput(result);
        }

        private void x10_3_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 3, ref result);
            PrepareOutput(result);
        }

        private void x10_4_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 4, ref result);
            PrepareOutput(result);
        }

        private void x10_5_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 5, ref result);
            PrepareOutput(result);
        }

        private void x10_6_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 6, ref result);
            PrepareOutput(result);
        }

        private void x10_7_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 7, ref result);
            PrepareOutput(result);
        }

        private void x10_8_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 8, ref result);
            PrepareOutput(result);
        }

        private void x10_9_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 9, ref result);
            PrepareOutput(result);
        }

        private void x10_10_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 10, ref result);
            PrepareOutput(result);
        }

        private void x10_11_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 11, ref result);
            PrepareOutput(result);
        }

        private void x10_12_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.MultiplyX10ElaveteTo(value_1, 12, ref result);
            PrepareOutput(result);
        }

        private void Fx_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CalculateFunction(value_1, value_function_x, ref result);
            PrepareOutput(result);
        }

        private void Fxy_Click(object sender, EventArgs e)
        {
            PrepareInput();
            message = calculator.CalculateFunctionXY(value_1, value_2, value_function_xy, ref result);
            PrepareOutput(result);
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
