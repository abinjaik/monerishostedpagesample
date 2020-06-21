using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonerisIntegrationWebForm.UserControl
{
    public partial class MonerisCheckOutButton : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.OrderId))
            {
                throw new Exception("OrderID for purchase cannot be null");
            }                             
        }

        public string MonerisCheckOutUrl { get; } = ConfigurationManager.AppSettings["MonerisCheckOutUrl"].ToString();
        public string Moneris_ps_store_id { get; } = ConfigurationManager.AppSettings["Moneris_ps_store_id"].ToString();

        public string Moneris_hpp_key
        {
            get;
        } = ConfigurationManager.AppSettings["Moneris_hpp_key"].ToString();

        public string CheckOutButtonText
        {
            get;
        } = ConfigurationManager.AppSettings["Moneris_CheckoutButtontext"].ToString();

        public string OrderId
        {
            get; set;
        }

        public string TotalCharge
        {
            get; set;
        }
    }
}