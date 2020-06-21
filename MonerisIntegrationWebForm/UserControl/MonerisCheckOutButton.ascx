<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MonerisCheckOutButton.ascx.cs" Inherits="MonerisIntegrationWebForm.UserControl.MonerisCheckOutButton" %>

<style>
    .checkout {
        background-color: #008CBA; /* Bluish */
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 14px;
    }
</style>


<form method="POST" action="<%=this.MonerisCheckOutUrl %>">

    <input type="HIDDEN" name="ps_store_id" value="<%=this.Moneris_ps_store_id %>" />


    <input type="HIDDEN" name="hpp_key" value="<%=this.Moneris_hpp_key %>" />

    <input type="HIDDEN" name="charge_total" value="<%=this.TotalCharge.ToString() %>" />



    <!--MORE OPTIONAL VARIABLES CAN BE DEFINED HERE -->
    <input type="hidden" name="order_id" value="<%=this.OrderId %>" />





    <input type="SUBMIT" class="checkout" name="SUBMIT" value="<%=this.CheckOutButtonText %>">
</form>
