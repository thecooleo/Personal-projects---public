using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_browser
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }

       
        //called when menu exit item is selected
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //displays message when they click about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by brodie!");
        }
        
        public void navigateToPage()
        {
            webBrowser2.Navigate(textBox2.Text);
            button4.Enabled = false;
            textBox2.Enabled = false;
           
         
        }

    

        private void button4_Click_1(object sender, EventArgs e)
        {
            navigateToPage();
         
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                navigateToPage();
            }
        }

        private void webBrowser2_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            button4.Enabled = true;
            textBox2.Enabled = true;
            foreach (HtmlElement image in webBrowser2.Document.Images)
            {
                image.SetAttribute("src", "http://upload.wikimedia.org/wikipedia/commons/7/7c/Ostrich,_mouth_open.jpg");
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("www.reddit.com");
        }

       
    }
}
