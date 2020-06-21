using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moneris_ASP.NETCoreMVCApp.Helpers;
using Moneris_ASP.NETCoreMVCApp.Models;

namespace Moneris_ASP.NETCoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;

        public HomeController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IActionResult Index()
        {
            string ps_store_id = configuration.GetSection("MonerisConfiguration").GetSection("ps_store_id").Value;
            string hpp_key = configuration.GetSection("MonerisConfiguration").GetSection("hpp_key").Value;
            string checkoutUrl = configuration.GetSection("MonerisConfiguration").GetSection("checkouturl").Value;

            CheckoutModel checkoutModel = new CheckoutModel();
            checkoutModel.PaymentGatewayConfig = new MonerisConfig() { StoreID = ps_store_id, HPPKey = hpp_key, CheckOutUrl = checkoutUrl };
            checkoutModel.OrderID = Guid.NewGuid().ToString();
            checkoutModel.Amount = "50.00";
            checkoutModel.CheckOurUrl = checkoutUrl;
            return View(checkoutModel);
        }

        /// <summary>
        /// Callback URL need to be configured on the Moneris Merchant Store portal with Path(""https://<yourapplication.com>/callback) to have async push/post to client application with information regarding the transaction. This is not required, unless 
        /// there should be a need to have backend confirmation, but this method is more reliable and secure.
        /// </summary>
        /// <returns></returns>
        public IActionResult CallBack()
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(HttpContext.Request.Body))
            {
                String xmlData = reader.ReadToEnd();
                string decodedtext = HttpUtility.UrlDecode(xmlData);
                string formattedXmlText = decodedtext.Replace("xml_response=<?xml version='1.0' standalone='yes'?>", ""); // The return XML is  formatted "differently" from Moneris side, so replacing  unncessary text to get properly formatted XML

                Serializer serializer = new Serializer();
                MonerisPaymentResponse responseObject = serializer.Deserialize<MonerisPaymentResponse>(formattedXmlText); // Deserilizing to an object for you to save into DB. Better to create DB table to log into DB table with all fields.
            }

            return new EmptyResult();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
