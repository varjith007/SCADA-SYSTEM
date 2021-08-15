using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;
using NationalInstruments;
using NationalInstruments.NetworkVariable.WindowsForms;



namespace control_system_temparature
{
    public partial class Form4 : Form
    {


        public NetworkVariableReader<double> reader;
        public const string networkvariablelocation = @"\\localhost\OPC process\TEMPARATURE";
        public Form4()
        {
            InitializeComponent();
            connectOPCserver();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void connectOPCserver()
        {
            reader = new NetworkVariableReader<double>(networkvariablelocation);
            reader.Connect();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            /*NetworkVariableData<double> opcdata = null;
            try
            {
                opcdata = reader.ReadData();
                textBox1.Text = opcdata.GetValue().ToString("N3");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("The read time is out", "try again");
                return;
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NetworkVariableData<double> opcdata = null;
            try
            {
                opcdata = reader.ReadData();
                textBox1.Text = opcdata.GetValue().ToString("N1");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("The read time is out", "try again");
                return;
            }
        }
    }
}
