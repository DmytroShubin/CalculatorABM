using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorABM
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operatorPerform = "";
        bool isperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }
        private void button_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") || (isperformed))
            {
                textBox1.Clear();
            }
            isperformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
            
          
        }

        private void operatorButtons(object sender, EventArgs e)
        {
            Button operatorsButtons = (Button)sender;
            operatorPerform = operatorsButtons.Text;
            resultValue = Convert.ToDouble(textBox1.Text);
            label1.Text = resultValue + " " + operatorPerform;
            isperformed = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operatorPerform)
            {
                case "+":
                    textBox1.Text =(resultValue+ Convert.ToDouble(textBox1.Text)).ToString(); 
                    break;
                case "-":
                    textBox1.Text = (resultValue - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "%":
                    textBox1.Text = (resultValue % Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
