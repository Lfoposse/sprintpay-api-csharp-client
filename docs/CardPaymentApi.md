# IO.SprintPay.Api.CardPaymentApi

All URIs are relative to *http://197.159.2.146:7086/sprintpayapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CardStatus**](CardPaymentApi.md#cardstatus) | **GET** /payement/card/hosted/check | check the status of card payment request by transaction id 
[**Paymentcard**](CardPaymentApi.md#paymentcard) | **POST** /payement/card/hosted/url | Card payment


<a name="cardstatus"></a>
# **CardStatus**
> List<PaymentCardReponse> CardStatus (List<string> transaction)

check the status of card payment request by transaction id 

check the status of card payment request using transaction id who are provider in the url of payment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SprintPay.Api;
using IO.SprintPay.Client;
using IO.SprintPay.Model;

namespace Example
{
    public class CardStatusExample
    {
        public void main()
        {
            // Configure API key authorization: DateTime
            Configuration.Default.AddApiKey("datetime", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("datetime", "Bearer");
            // Configure API key authorization: autorization
            Configuration.Default.AddApiKey("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("authorization", "Bearer");

            var apiInstance = new CardPaymentApi();
            var transaction = new List<string>(); // List<string> | status of card payment

            try
            {
                // check the status of card payment request by transaction id 
                List&lt;PaymentCardReponse&gt; result = apiInstance.CardStatus(transaction);
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transaction** | [**List&lt;string&gt;**](string.md)| status of card payment | 

### Return type

[**List<PaymentCardReponse>**](PaymentCardReponse.md)

### Authorization

[DateTime](../README.md#DateTime), [autorization](../README.md#autorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentcard"></a>
# **Paymentcard**
> void Paymentcard (Card body)

Card payment

Make an payment using credit card

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SprintPay.Api;
using IO.SprintPay.Client;
using IO.SprintPay.Model;

namespace Example
{
    public class PaymentcardExample
    {
        public void main()
        {
            // Configure API key authorization: DateTime
            Configuration.Default.AddApiKey("datetime", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("datetime", "Bearer");
            // Configure API key authorization: autorization
            Configuration.Default.AddApiKey("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("authorization", "Bearer");

            var apiInstance = new CardPaymentApi();
            var body = new Card(); // Card | Created card object

            try
            {
                // Card payment
                apiInstance.Paymentcard(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardPaymentApi.Paymentcard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Card**](Card.md)| Created card object | 

### Return type

void (empty response body)

### Authorization

[DateTime](../README.md#DateTime), [autorization](../README.md#autorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

