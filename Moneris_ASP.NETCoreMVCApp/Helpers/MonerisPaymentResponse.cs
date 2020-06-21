using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace  Moneris_ASP.NETCoreMVCApp.Helpers
{
    [Serializable, XmlRoot(ElementName = "response")]
    [XmlType("response")]
    public class MonerisPaymentResponse
    {
        [XmlElement("response_order_id")]
        public string OrderID{ get; set; }

        [XmlElement("bank_transaction_id")]
        public string BankTransactionID { get; set; }

        [XmlElement("response_code")]
        public string ResponseCode { get; set; }

        [XmlElement("iso_code")]
        public string ISOCode { get; set; }

        [XmlElement("bank_approval_code")]
        public string BankApprovalCode { get; set; }

        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

        [XmlElement("date_stamp")]
        public string DateStamp { get; set; }

        [XmlElement("trans_name")]
        public string TransactionName { get; set; }

        [XmlElement("message")]
        public string TransactionMessage { get; set; }

        [XmlElement("charge_total")]
        public string TotalAmountCharged { get; set; }

        [XmlElement("cardholder")]
        public string CardHolderNameSubmitted { get; set; }

        [XmlElement("card_num")]
        public string PartialCardNumber { get; set; }

        [XmlElement("card")]
        public string CardTypeAbbreviation { get; set; }

        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        [XmlElement("result")]
        public string Result { get; set; }

        [XmlElement("txn_num")]
        public string TransactionNumber { get; set; }

        [XmlElement("cavv_response_code")]
        public string CAVVResponseCode { get; set; }

    }
}