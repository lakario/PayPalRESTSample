using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayPal.Models
{
    public class ConfirmedViewData : PayPalViewData
    {
        public Guid Id { get; set; }

        public string Token { get; set; }

        public string PayerId { get; set; }

        public string AuthorizationId { get; set; }
    }
}