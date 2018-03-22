# IO.sprintpay - the C# library for the Sprint-pay payment for developper

This is a sample doc to use our sprint-pay payment api.

This C# SDK is created by rainbow-cl [sprintpay Codegen](https://github.com/sprintpay-api/) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.sprintpay.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.sprintpay.Api;
using IO.sprintpay.Client;
using IO.sprintpay.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.sprintpay.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.sprintpay.Api;
using IO.sprintpay.Client;
using IO.sprintpay.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: DateTime
            Configuration.Default.ApiKey.Add("datetime", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("datetime", "Bearer");
            // Configure API key authorization: autorization
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new CardPaymentApi();
            var transaction = new List<string>(); // List<string> | status of card payment

            try
            {
                // check the status of card payment request by transaction id 
                List<PaymentCardReponse> result = apiInstance.CardStatus(transaction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardPaymentApi.CardStatus: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://197.159.2.146:7086/sprintpayapi*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CardPaymentApi* | [**CardStatus**](docs/CardPaymentApi.md#cardstatus) | **GET** /payement/card/hosted/check | check the status of card payment request by transaction id 
*CardPaymentApi* | [**Paymentcard**](docs/CardPaymentApi.md#paymentcard) | **POST** /payement/card/hosted/url | Card payment
*MobilePaymentApi* | [**Mobilemoney**](docs/MobilePaymentApi.md#mobilemoney) | **POST** /payment/mobilemoney/request | Make a new mobilemoney payment
*MobilePaymentApi* | [**Mobilestatus**](docs/MobilePaymentApi.md#mobilestatus) | **GET** /payement/mobilemoney/check | check the status of mobile payment request using processingNumber
*MobilePaymentApi* | [**Orangemoney**](docs/MobilePaymentApi.md#orangemoney) | **POST** /payment/orangemoney/request | Make an payment using orangemoney


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiResponse](docs/ApiResponse.md)
 - [Model.Card](docs/Card.md)
 - [Model.Mobilemoney](docs/Mobilemoney.md)
 - [Model.Orangemoney](docs/Orangemoney.md)
 - [Model.PaymentCardReponse](docs/PaymentCardReponse.md)
 - [Model.PaymentMobileReponse](docs/PaymentMobileReponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="DateTime"></a>
### DateTime

- **Type**: API key
- **API key parameter name**: datetime
- **Location**: HTTP header

<a name="autorization"></a>
### autorization

- **Type**: API key
- **API key parameter name**: authorization
- **Location**: HTTP header

