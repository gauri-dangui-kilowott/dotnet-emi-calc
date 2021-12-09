using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiMVC.Models
{
    public class Request
    {
        public double Principal { get; set; }
        public double InterestRateInPercentage { get; set; }
        public double LoanDurationInYearCount { get; set; }
        public double Result { get; set; }


    }
}