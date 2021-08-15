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
using System.Windows.Forms.DataVisualization.Charting;

namespace control_system_temparature
{
    public partial class Form1 : Form
    {
        int runTime = 100, timeDelay, plotszie =1;
        
        static public double gain = 2.5;
        static public double time_constant = 22;
        static public double time_delay = 3;
        static public double t_env = 22;
        static public Queue<double> DelayedSignals = new Queue<double>();
        static public double dt = 0.1;
        static public double T;
        static public double u;
        static public double ti;
        public static int timercount = 0;
        public static double u_man;
        public static string value;
        int x = 2; int y = 3; int d = 5;  

        List<double> yValuesT = new List<double>();
        List<double> xValuesT = new List<double>();
        List<double> yValuesC = new List<double>();
        List<double> xValuesC = new List<double>();

        public NetworkVariableReader<double> reader;
        public NetworkVariableReader<double> reader2;
        public const string networkvariablelocation = @"\\localhost\OPC\OPC Server\Simulation Items\Bucket Brigade\Real8";
        public const string networkvariablelocation2 = @"\\\\localhost\OPC\OPC Server\Simulation Items\Bucket Brigade\Real4";
        public Form1()
        {
            InitializeComponent();
            Signalarray();
            connectOPCserver();
            textBox2.Text = Convert.ToString(20.9);
            textBox3.Text = Convert.ToString(31.4);



        }

        public void connectOPCserver()
        {
            reader = new NetworkVariableReader<double>(networkvariablelocation);
            reader.Connect();
            //reader2 = new NetworkVariableReader<double>(networkvariablelocation2);
            //reader2.Connect();

        }

        public void Signalarray()
        {

            DelayedSignals = new Queue<double>();
            for (double t = 0; t < time_delay; t += dt)
                DelayedSignals.Enqueue(0);

        }


        /*private void chartC(double yValue)
        {
            yValuesC.Add(yValue);
            xValuesC.Add(plotszie);
            ChartArea area1 = chart2.ChartAreas[0];
            area1.AxisY.Minimum = 0;
            area1.AxisY.Maximum = 5;
            area1.AxisX.Minimum = 0;
            area1.AxisX.Maximum = 100;
            area1.BackColor = Color.DarkGray;
            chart2.BorderlineColor = Color.DarkGray;
            chart2.Legends[0].BackColor = Color.DarkGray;
            chart2.Series["Control Signal"].Color = Color.Black;
            chart2.Series["Control Signal"].Points.DataBindXY(xValuesC, yValuesC);
            chart2.Invalidate();
            plotszie++;
            if (plotszie > 100)
            {
                plotszie = 1;
                yValuesC.Clear();
                yValuesT.Clear();
                xValuesC.Clear();
                xValuesT.Clear();
            }
        }*/
        private void chartT(double yValue)
        {
            yValuesT.Add(yValue);
            xValuesT.Add(plotszie);
            ChartArea area2 = chart1.ChartAreas[0];
            area2.AxisY.Minimum = 20;
            area2.AxisY.Maximum = 50;
            area2.AxisX.Minimum = 0;
            area2.AxisX.Maximum = 100;
            area2.BackColor = Color.DarkGray;
            chart1.Legends[0].BackColor = Color.DarkGray;
            chart1.Series["Temparature"].Color = Color.Black;
            chart1.Series["Temparature"].Points.DataBindXY(xValuesT, yValuesT);
            chart1.Invalidate();
            plotszie++;
            if (plotszie > 100)
            {
                plotszie = 1;
                yValuesC.Clear();
                yValuesT.Clear();
                xValuesC.Clear();
                xValuesT.Clear();
            }
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //label9.Text = Convert.ToString(trackBar1.Value *0.1);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scadaSystemDataSet2.ACKNOWELEGED_ALARAM' table. You can move, or remove it, as needed.
            this.aCKNOWELEGED_ALARAMTableAdapter.Fill(this.scadaSystemDataSet2.ACKNOWELEGED_ALARAM);
            // TODO: This line of code loads data into the 'scadaSystemDataSet.ALARM' table. You can move, or remove it, as needed.
            this.aLARMTableAdapter.Fill(this.scadaSystemDataSet.ALARM);
            //textBoxSignal.Text = Convert.ToString(33.1);
           


            /*if (checkBox1.Checked == true)
            {

                u = Form2.controlsignal;
                
   
            }
            else
            {
                //u = Convert.ToDouble(labeltracksignal.Text);
                u = u_man;
            }

            timer1.Start();
            textGain.Text = Convert.ToString(gain);
            textEnTemp.Text = Convert.ToString(time_constant);
            textTimeConstant.Text = Convert.ToString(t_env);
            textDelay.Text = Convert.ToString(time_delay);
            label9.Text = Convert.ToString(ti);
            //textSignal.Text = Convert.ToString(T);
            //label9.Text = Convert.ToString(u_man);
            */
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //AirHeater.calculatetemparature();
            ++timercount;
            DelayedSignals.Enqueue(u);

            if (timercount < DelayedSignals.Count)
            {
                DelayedSignals.Dequeue();
            }

            double DT_dt = (1 / time_constant) * ((t_env - T) + gain * u);
            T += dt * DT_dt;
            //textBoxSignal.Text = Convert.ToString(T);

            NetworkVariableData<double> opcdata = null;
            opcdata = reader.ReadData();
            textBoxSignal.Text = opcdata.GetValue().ToString("N1");
            value = textBoxSignal.Text;
            chartT(opcdata.GetValue());

            /*NetworkVariableData<double> opcsignal = null;
            opcsignal = reader2.ReadData();
            label9.Text = opcsignal.GetValue().ToString("N1");
            value = label9.Text;
            chartC(opcsignal.GetValue());*/


        }

        
        
    }
}
