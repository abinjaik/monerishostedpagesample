using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moneris_ASP.NETCoreMVCApp.Models
{
    public class CheckoutModel
    {
        public string OrderID { get; set; }
        public string Amount { get; set; }

        public string CheckOurUrl { get; set; }

        public MonerisConfig PaymentGatewayConfig { get; set; }

    }
}
