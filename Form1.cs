using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace role
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("1");
            }
            finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("49");
            }
            finally { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string degis = comboBox1.Text;
                serialPort.PortName = degis;
                serialPort.BaudRate = 9600;
                serialPort.Open();
                label2.Text("Bağlandı");
            }
            catch { 
                
            }

        }
    }
}
