using System;

namespace EMI_Calc
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int t, n, PrincipalAmt;
            double interest;
            Console.WriteLine("Enter the Principal Amount :");
            PrincipalAmt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest :");
            interest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the loan duration :");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the monthly compound :");
            n = Convert.ToInt32(Console.ReadLine());

            var emiObject = new EMI_Calc_Inputs();
            emiObject.GetPrincipal(PrincipalAmt);
            emiObject.GetRate(interest);
            emiObject.GetMonthlyCompound(n);
            emiObject.GetDuration(t);


        }
    }
}


