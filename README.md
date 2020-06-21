# Moneris Payment Gateway Hosted Page Integration Model.
This sample demonstrates the Moneris Payment Gateway's Hosted Payment form sample for **ASP.NET Core** Application as well as for legacy Web forms.

## Getting started
Moneris offers multiple ways to integrate their Payment Gateway to your web application. 
There are mainly 2 methods  - using "APIs/ Web Services" and/or using "Hosted Payment model". This sample code demonstrates/walks you through the "Host payment page model" in which we can redirect our customers to Moneris hosted payment form to enter Credit Card details 
to complete the checkout/transaction. This way is suggested when client application dont want to handle security, revolving changes around Credit card validation etc. 
So, before deep diving into this sample code kindly confirm the integration method you want to pursue.

### Signing up with Moneris for Development/sandbox testing purpose
Create a *development moneris account* at https://developer.moneris.com to get the TEST Credentials. Once you get the TEST credentials, login to the 
"TEST Merchant resource center" at https://esqa.moneris.com/mpg/ to create/generate **ps_store_id** and **hpp_key**
More information regarding TEST Credit Card accounts & other test stores can be found here - https://developer.moneris.com/en/More/Testing/Testing%20a%20Solution

### Using this code samples
This code sample solution consists of 2 .NET based web applications. One is developed for **.NET Core** developers and other sample is based legacy ASP.NET Webforms. Both samples have similar functionality integration with **async** callback to confirm the transactions, even end users completing the payments on Moneris payment forms.

#### Regarding ASP.NET Core Sample
Inside ASP.NET Core MVC project's appsettings.json there is JSON section to enter Moneris configuration 
like PS_STORE_ID, HPPKEY, along with configurable checkout page url. 
For the demonstration purposes, the check out URL is set as https://esqa.moneris.com/mpg . Please enter these configurations before trying out the project.

#### Regarding ASP.NET WebForms Sample
This sample is very straight forward, with Moneris configurations are stored in Web.config.The checkout control is created a UserControl with properties created inside, to set  up inside the payment page.

##Note
This code sample is **NOT** production ready, but just for reference. I suggest to incorporate security settings for CORS,XSS before implement this to Production.
