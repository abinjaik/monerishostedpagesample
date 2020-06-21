using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonerisIntegrationWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MonerisCheckOutButton.OrderId =  Guid.NewGuid().ToString(); // THIS Can be any unique identifier which identifies the purchase, so that it can be tracked back from the call back. -- See callback.aspx
            MonerisCheckOutButton.TotalCharge = "5.00"; //THIS Format is required.
        }

        
    }
}