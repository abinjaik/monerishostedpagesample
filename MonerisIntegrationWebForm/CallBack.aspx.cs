using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace MonerisIntegrationWebForm
{
    public partial class CallBack : System.Web.UI.Page
    {
        /// <summary>
        /// Parsing locic for the XML callback response. this page is just for callback from Moneris system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Response.ContentType = "text/xml";
            using (System.IO.StreamReader reader = new System.IO.StreamReader(Page.Request.InputStream))
            {
                String xmlData = reader.ReadToEnd();                
                string decodedtext = HttpUtility.UrlDecode(xmlData);
                string formattedXmlText = decodedtext.Replace("xml_response=<?xml version='1.0' standalone='yes'?>", ""); // The return XML is not properly formatted from Moneris, so replacing  unncessary text to get properly formatted XML
                
                Serializer serializer = new Serializer();
                MonerisPaymentResponse responseObject = serializer.Deserialize<MonerisPaymentResponse>(formattedXmlText); // Deserilizing to an object for you to save into DB. Better to create DB table to log into DB table with all fields.

                Application["PaymentData"] = responseObject; //TODO: THIS line is TEMP CODE for Demo to store inside Application variable. Please save response object in a secure DB table.
               
            }

        }
    }
}