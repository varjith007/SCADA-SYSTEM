using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.form1

namespace control_system_temparature
{
    public partial class Form2 : Form
    {

        //Form1.AirHeater Heater = new Form1.AirHeater();
       // public static double x = 0;
        public static double controlsignal;
        


        public double GenerateSignal()
        {
            //Form1 frm1 = new Form1();
            double T_i = 8;
            double T_d = 1;
            double T_s = 0.5;
            double K_p = 2.94;
            double integralbuffer = 0;

            double setpoint = Convert.ToDouble(textBox1.Text);
            double processvariable = Convert.ToDouble(Form1.value);
            double error = setpoint - processvariable;
            controlsignal = K_p * error + (K_p / T_i) * integralbuffer;
            integralbuffer += T_s * error;
            return controlsignal;

        }
        public Form2()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();

           

        }

        private void Off(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GenerateSignal();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(32.0);
            textBox2.Text = Convert.ToString(32.3);
            textBox3.Text = Convert.ToString(2.92);
            textBox4.Text = Convert.ToString(40);
            textBox5.Text = Convert.ToString(10);
            textBox6.Text = Convert.ToString(0);

        }
    }
}
