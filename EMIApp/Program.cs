using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
            ICalculator emiCalculator = new Calculator();

            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);

            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))

                Console.WriteLine("The Monthly EMI for the amount is :" + emiMonthly.EmiPayment);
            else
                Console.WriteLine(emiMonthly.ErrorMessage);



        }
    }
}


