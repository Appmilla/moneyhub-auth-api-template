# moneyhub-auth-api-template
.Net CLI template for a Moneyhub API using ASP.NET Core to provide access tokens protected using Identity Server v6

Using the client SDK from https://github.com/Appmilla/moneyhub-api-client

Example Xamarin.Forms clients for Android and iOS can be found in this repo:- https://github.com/Appmilla/moneyhub-security

This is built using .Net 6.0, I've tested this using Visual Studio 2022 on Windows and Rider EAP on MacOS https://www.jetbrains.com/rider/nextversion/

To install the template from the nuget package:- dotnet new --install Appmilla.MoneyhubAuthApi::1.0.1

The installed template should be listed like this:-

Moneyhub ASP.NET Auth API moneyhubauthapi [C#] Web/MVC/Razor Pages

To create a new API project use :

dotnet new moneyhubauthapi -n YOUR_NAME_FOR_THE_API

Running the project should display the API page on port 5001

Edit the Program.cs options.Authority to point to the URL of your IdentityServer.

The Api uses secrets for the ClientId and ClientSecret. Right-click the project file and choose 'Manage User Secrets' to set this up locally - you will need to have registered with MoneyHub to obtain these from the portal.

A template to create an IdentityServer v6 host can be found at:- https://www.nuget.org/packages/Appmilla.IdentityUserReg/
