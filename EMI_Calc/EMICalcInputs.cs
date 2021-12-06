using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMICalc
{
    internal class EMICalcInputs
    {
        int  n,t;
        int PrincipalAmt;
        double RateOfInterest;
            
        public void GetPrincipal (int p )
        {
            PrincipalAmt = p;
            
        }

        public void GetRate(double  r)
        {
            RateOfInterest = r;
            
        }

        public void GetDuration (int m)
        {
            t = m;
        }

        public void GetMonthlyCompound ( int x)
        {
            n = x;
        }

        public void EmiCalculation ()
        {
            decimal emi;
            emi = 0;
            emi = (decimal)(PrincipalAmt * Math.Pow((1 + RateOfInterest / n), (t * n)));
             emi = emi / 24;
            Console.WriteLine("The calculated EMI is : " + Math.Round(emi, 2));
        }




    }
}
