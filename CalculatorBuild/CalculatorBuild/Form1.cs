using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBuild
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

        private void go_Click(object sender, EventArgs e)
        {
            double first=0, second=0;
            try
            {
                first = Convert.ToDouble(one.Text);
                second = Convert.ToDouble(two.Text);
            }
            catch (Exception ee)
            {
               
            }
                double answer = checkBoxes(first, second);
            output.AppendText(answer + "\n");


        }
        private double checkBoxes(double first, double second)
        {
            if (Add.Checked)
            {
                return add(first, second);
            }
            else if (subtract.Checked == true)
            {
                return Subtract(first, second);
            }
            else if (mult.Checked)
            {
                return multiply(first, second);
            }
            else if (div.Checked)
            {
                return Divide(first, second);
            }
            else if (sine.Checked)
            {
                
                return Math.Sin(first);

            }
            else if (cosine.Checked)
            {
                return Math.Cos(first);
            }
            else if (tangent.Checked)
            {
                return Math.Tan(first);
            }
            
            
            
        return -1;
        }
        private double add(double a, double b)
        {
            return a + b;
        }
        private double Subtract(double a, double b)
        {
            return a - b;
        }
        private double Divide(double a, double b)
        {
            return a / b;
        }
        private double multiply(double a, double b)
        {
            return a * b;
        }

        private void sine_CheckedChanged(object sender, EventArgs e)
        {
            changed();
        }

        private void cosine_CheckedChanged(object sender, EventArgs e)
        {
            changed();
        }

        private void tangent_CheckedChanged(object sender, EventArgs e)
        {
            changed();
        }
        private void changed()
        {
            if (two.Enabled)
                two.Enabled = false;

            else
                two.Enabled = true;
        }
    }
}
