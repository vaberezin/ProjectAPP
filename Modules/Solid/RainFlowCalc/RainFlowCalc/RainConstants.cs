using System;
using System.Collections.Generic;
using System.Text;

namespace RainFlowCalc
{
    class RainConstants
    {
        double F;
        double F_road;
        double F_green;
        double F_roof;
        double F_gravel;
        double n;
        double A;
        double Psy_mid;
        double Z_mid;
        double t_r;
        double t_con;
        double t_can;
        double t_p;
        double l_can;
        double v_can;
        double l_p;
        double v_p;
        double Q_rRain;
        double Q_rIce;
        double beta;
        double Q_cal;
        int Q_20;
        double P;
        double m_r;
        double gamma;
        double K;
        double Z_i;
        double Psy_i;
        int h_c;
        double t_c;
        double K_y;
        double F_y;

        public double F_roadRoof
        {
            get { return F_road + F_roof; }
            set { F_roadRoof = value; }
        }
    }
}
