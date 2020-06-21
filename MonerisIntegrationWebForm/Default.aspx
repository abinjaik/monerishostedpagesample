<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MonerisIntegrationWebForm.Default" %>

<%@ Register Src="~/UserControl/MonerisCheckOutButton.ascx" TagPrefix="uc1" TagName="MonerisCheckOutButton" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    
       

    <uc1:MonerisCheckOutButton runat="server" id="MonerisCheckOutButton" /> <!--Add this Control and pass the ORDERID & Total Charge value, as defined  in the code behind"-->
    
</body>
</html>
