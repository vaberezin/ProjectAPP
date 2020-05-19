using System;
using System.Collections.Generic;
using System.Text;

namespace RainFlowCalc
{
    class RainConstants
    {
        //Variables initialization
        string Region = "unassigned";
        double F; //ok
        double F_road; //ok
        double F_green;  //ok
        double F_roof; //ok
        double F_gravel; //ok
        double n; //Pril2 table
        double A;  //method
        double Psy_mid; //method
        double Z_mid; //method
        public double t_r //property+
        {
            get { return t_con + t_can + t_p; }            
        } 
        double t_con; //enum
        double t_can; //method
        double t_p; //method
        double l_can; //ok
        double v_can; //ok
        double l_p; //ok
        double v_p; //ok
        double Q_rRain; //method
        double Q_rIce; //method
        double beta; //table
        double Q_cal; //method
        int Q_20; //table
        double P; //table
        double m_r; //table
        double gamma; //table
        double K; //table
        double Z_i; //table
        double Psy_i; //table
        int h_c; //table
        public double t_c //property+
        {
            get { return t_p; }
        }
        public double K_y //property+
        {
            get { return 1-(F_y/F); }
        }
        double F_y //property+
        {
            get { return F_road; }
        }

        public double F_roadRoof //property+
        {
            get { return F_road + F_roof; }
            set { F_roadRoof = value; }
        }

        
    }
}
