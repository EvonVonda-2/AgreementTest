using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AgreementTest
{
    public partial class Form1 : Form
    {

        private SerialPort serialPort=new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeSerialPortSettings()
        {
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(new object[] {"4800","9600","19200","38400","57600","115200"});
            comboBox5.SelectedIndex = 1;


        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
