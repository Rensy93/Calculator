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
        double result = 0;
        String opertor = "";
        bool isOpertionPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (isOpertionPerformed))
                resultTextBox.Clear();

            isOpertionPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!resultTextBox.Text.Contains(","))
                    resultTextBox.Text = resultTextBox.Text + button.Text;

            }
            else
            resultTextBox.Text = resultTextBox.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if(result != 0)
            {
                    this.EqualButton.PerformClick();
                    opertor = button.Text;
                    currentOperationLable.Text = result + " " + opertor;
                    isOpertionPerformed = true;
            }
            
            opertor = button.Text;
            result = Double.Parse(resultTextBox.Text);
            currentOperationLable.Text = result + " " + opertor;
            resultTextBox.Clear();
            isOpertionPerformed = true;

        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            currentOperationLable.Text = "";
            result = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (opertor)
                {
                    case "+":
                        resultTextBox.Text = (result + Double.Parse(resultTextBox.Text)).ToString();
                        break;
                    case "-":
                        resultTextBox.Text = (result - Double.Parse(resultTextBox.Text)).ToString();
                        break;
                    case "x":
                        resultTextBox.Text = (result * Double.Parse(resultTextBox.Text)).ToString();
                        break;
                    case "/":
                        resultTextBox.Text = (result / Double.Parse(resultTextBox.Text)).ToString();
                        break;
                    case "√":
                        resultTextBox.Text = (Math.Sqrt(result)).ToString();
                        break;
                    default:
                        break;
                }
                result = Double.Parse(resultTextBox.Text);
                currentOperationLable.Text = "";

            }catch(Exception msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}