using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_side_of_chat_client
{
    public partial class window : Form
    {
        public String username;
        public String IP;
        public int port;
        public int pin;
        public window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           username = nameTextBox.Text;
            IP = ipTextBox.Text;
            try
            {
                port = Convert.ToInt32(portTextBox.Text);
            }
            catch (Exception z)
            {
                label5.Visible = true;
                label5.Text = "ERROR PORT NUMBER NOT VALID";
            }
            try
            {
                pin = Convert.ToInt32(portTextBox.Text);
            }
            catch (Exception x)
            {
                label5.Visible = true;
                label5.Text = "PIN MUST BE A SERIES OF 4 DIGET NUMBERS!";
            }
            TTS tts = new TTS();

        }
    }
}
