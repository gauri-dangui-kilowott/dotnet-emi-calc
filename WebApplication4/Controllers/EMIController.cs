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

        public ActionResult CalculateMonthlyEMI(double principal, double rate, double duration)
        {
            Request request = new Request();
            request.Principal = principal;
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;


            double Result = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 12, request.LoanDurationInYearCount * 12);


            request.Result = Result;
            return View(request);

        }
    }
}