# IO.SprintPay.Api.MobilePaymentApi

All URIs are relative to *http://197.159.2.146:7086/sprintpayapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Mobilemoney**](MobilePaymentApi.md#mobilemoney) | **POST** /payment/mobilemoney/request | Make a new mobilemoney payment
[**Mobilestatus**](MobilePaymentApi.md#mobilestatus) | **GET** /payement/mobilemoney/check | check the status of mobile payment request using processingNumber
[**Orangemoney**](MobilePaymentApi.md#orangemoney) | **POST** /payment/orangemoney/request | Make an payment using orangemoney


<a name="mobilemoney"></a>
# **Mobilemoney**
> List<PaymentMobileReponse> Mobilemoney (Orangemoney body)

Make a new mobilemoney payment

Make an payment using MobileMoney

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SprintPay.Api;
using IO.SprintPay.Client;
using IO.SprintPay.Model;

namespace Example
{
    public class MobilemoneyExample
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

            var apiInstance = new MobilePaymentApi();
            var body = new Orangemoney(); // Orangemoney | Mobilemoney object that needs to be added to the body of request

            try
            {
                // Make a new mobilemoney payment
                List&lt;PaymentMobileReponse&gt; result = apiInstance.Mobilemoney(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobilePaymentApi.Mobilemoney: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Orangemoney**](Orangemoney.md)| Mobilemoney object that needs to be added to the body of request | 

### Return type

[**List<PaymentMobileReponse>**](PaymentMobileReponse.md)

### Authorization

[DateTime](../README.md#DateTime), [autorization](../README.md#autorization)

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mobilestatus"></a>
# **Mobilestatus**
> List<PaymentMobileReponse> Mobilestatus (List<string> processingNumber)

check the status of mobile payment request using processingNumber

processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SprintPay.Api;
using IO.SprintPay.Client;
using IO.SprintPay.Model;

namespace Example
{
    public class MobilestatusExample
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

            var apiInstance = new MobilePaymentApi();
            var processingNumber = new List<string>(); // List<string> | status by processingNumber

            try
            {
                // check the status of mobile payment request using processingNumber
                List&lt;PaymentMobileReponse&gt; result = apiInstance.Mobilestatus(processingNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobilePaymentApi.Mobilestatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processingNumber** | [**List&lt;string&gt;**](string.md)| status by processingNumber | 

### Return type

[**List<PaymentMobileReponse>**](PaymentMobileReponse.md)

### Authorization

[DateTime](../README.md#DateTime), [autorization](../README.md#autorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orangemoney"></a>
# **Orangemoney**
> List<PaymentMobileReponse> Orangemoney (Orangemoney body)

Make an payment using orangemoney

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SprintPay.Api;
using IO.SprintPay.Client;
using IO.SprintPay.Model;

namespace Example
{
    public class OrangemoneyExample
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

            var apiInstance = new MobilePaymentApi();
            var body = new Orangemoney(); // Orangemoney | object that needs to be added to the body of request

            try
            {
                // Make an payment using orangemoney
                List&lt;PaymentMobileReponse&gt; result = apiInstance.Orangemoney(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobilePaymentApi.Orangemoney: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Orangemoney**](Orangemoney.md)| object that needs to be added to the body of request | 

### Return type

[**List<PaymentMobileReponse>**](PaymentMobileReponse.md)

### Authorization

[DateTime](../README.md#DateTime), [autorization](../README.md#autorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

