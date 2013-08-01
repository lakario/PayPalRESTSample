using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayPal.Models
{
    public class PayPalViewData
    {
        public string JsonRequest { get; set; }
        public string JsonResponse { get; set; }
        public string ErrorMessage { get; set; }
    }
}