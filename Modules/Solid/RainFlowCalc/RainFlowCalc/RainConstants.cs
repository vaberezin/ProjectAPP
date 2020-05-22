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
        double _beta; //вычисление происходит в методе double beta()
        public void beta(double n)              //need to test
        {
            if(n <= 0.4)
            {
                _beta = 0.8;                
            }
            else if(n < 0.5)
            {
                _beta = 0.75;                
            }
            else if(n < 0.7)
            {
                _beta = 0.7;                
            }
            else
            {
                _beta = 0.65;                
            }
        }
        public double incline;  // Уклон поверхности на трассе сети.
        
        public double betaCorrection1 //Корректировка коэффициента beta №1
        { 
            get 
            {
                
                if(incline >=0.03)
                {
                    return 1.0;
                }
                else
                {
                    return 0.9;
                }               
            }
            
        }
        int sectionsNumber; //Общее число участков на дождевом коллекторе или на участке притока сточных вод.
        public double betaCorrection2 //Корректировка коэффициента beta №2
        { 
            get 
            {
                
                if(sectionsNumber < 4)
                {
                    return 0.90;
                }
                else if(sectionsNumber < 10)
                {
                    return 0.85;
                }    
                else
                {
                    return 1;
                }           
            }
            
        }
         
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
