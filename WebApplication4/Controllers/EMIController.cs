using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpiMVC.Models;

namespace EpiMVC.Controllers
{
    public class EMIController : Controller
    {
        // GET: EMI
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MonthlyEmi()
        {
            return View();
        }

        public ActionResult DisplayEmi(double principal, double rate, double duration)
        {
            Request request = new Request();
            request.Principal = principal;
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;


            double MonthlyEmi = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 12, request.LoanDurationInYearCount * 12);
            double e = 2.7183;
            double ContinousEmi = (double)request.Principal * System.Math.Pow(e, (request.InterestRateInPercentage / 100 * request.LoanDurationInYearCount));
            double DailyEmi = ((double)request.Principal * System.Math.Pow(1 + ((request.InterestRateInPercentage / 100) / 365), 365 * request.LoanDurationInYearCount)) - (double)request.Principal;

            request.MonthlyEmi = MonthlyEmi;
            request.ContinousEmi = ContinousEmi;
            request.DailyEmi = DailyEmi;

            return View(request);

        }
    }
}