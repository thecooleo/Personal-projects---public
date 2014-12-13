using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUILD_THE_GUI_INTERFACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string input=textBox1.Text;
            if (e.KeyCode == Keys.Enter&&input.Equals("HACK"))
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}
