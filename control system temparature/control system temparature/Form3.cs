using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_system_temparature
{
    public partial class Form3 : Form
    {

        public double fSignal, OfSignal, Tf, Ts;
        public Form3()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scadaSystemDataSet1.MEASUREMENTDATA' table. You can move, or remove it, as needed.
            this.mEASUREMENTDATATableAdapter.Fill(this.scadaSystemDataSet1.MEASUREMENTDATA);
            // TODO: This line of code loads data into the 'scadaSystemDataSet.ALARM' table. You can move, or remove it, as needed.
            this.aLARMTableAdapter.Fill(this.scadaSystemDataSet.ALARM);
            

        }

        public double LawpassFilter(double Signal)
        {
            double a = Ts / (Ts + Tf);
            fSignal = (1 - a) * OfSignal + a * Signal;
            OfSignal = fSignal;
            return fSignal;
        }


        
    }
}
