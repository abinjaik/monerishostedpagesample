using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonerisIntegrationWebForm
{
    public partial class PaymentStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TEST CODE TO Display transaction result
            if (Application["PaymentData"] != null)
            {
                var response = ((MonerisPaymentResponse)Application["PaymentData"]);
                Literal1.Text = "Bank TransactionID : " + response.BankTransactionID + " , Name : " + response.CardHolderNameSubmitted + ", Message : "+response.TransactionMessage;
            }
            else
            {
                Literal1.Text = "Waiting for transaction information from payment system...<a href='/'></a>";
            }
        }
    }
}