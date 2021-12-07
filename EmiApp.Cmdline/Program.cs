using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
        

            ICalculator emiCalculator = new Calculator();

     
            var response = new Response();


            var emiContinous = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiContinous.ErrorMessage))
                Console.WriteLine($"{response.EmiPaymentType1} EMI is : {emiContinous.EmiPayment}");
            else
                Console.WriteLine(emiContinous.ErrorMessage);



            var emiDaily = emiCalculator.CalculateDailyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiDaily.ErrorMessage))
                Console.WriteLine($"{response.EmiPaymentType2} EMI is : {emiDaily.EmiPayment}");
            else
                Console.WriteLine(emiDaily.ErrorMessage);

            



            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"{response.EmiPaymentType3} EMI is : {emiMonthly.EmiPayment}");
            else
                Console.WriteLine(emiMonthly.ErrorMessage);


           













        }
    }
}

