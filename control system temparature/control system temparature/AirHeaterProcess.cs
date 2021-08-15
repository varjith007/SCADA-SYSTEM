using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_system_temparature
{
    class AirHeaterProcess
    {
        // initizalising the database
        public double T_env { get; set; }
        public double Gain = 3.5;
        public double TimeConstant = 23;
        public double TimeDelay = 3;

        double[] Udelayed;

        double T_k;

        double Ts;

        public AirHeaterProcess()
        {
            T_env = 20;
            T_k = T_env;
        }

        public void IntiDelayedArray(double Samplingtime)
        {
            Ts = Samplingtime;
            int ArrayLength = Convert.ToInt32(Math.Round(TimeDelay / Ts) + 1);
            Udelayed = new double[ArrayLength];

        }

       

    }
}
