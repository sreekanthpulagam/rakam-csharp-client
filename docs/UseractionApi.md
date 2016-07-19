# Rakam.Client.Api.UseractionApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batch**](UseractionApi.md#batch) | **POST** /user/action/email/batch | Apply batch operation
[**Send**](UseractionApi.md#send) | **POST** /user/action/email/single | Perform action for single user


<a name="batch"></a>
# **Batch**
> long? Batch (UserEmailActionBatch userEmailActionBatch)

Apply batch operation



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class BatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new UseractionApi();
            var userEmailActionBatch = new UserEmailActionBatch(); // UserEmailActionBatch | 

            try
            {
                // Apply batch operation
                long? result = apiInstance.Batch(userEmailActionBatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UseractionApi.Batch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userEmailActionBatch** | [**UserEmailActionBatch**](UserEmailActionBatch.md)|  | 

### Return type

**long?**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="send"></a>
# **Send**
> bool? Send (UserEmailActionSend userEmailActionSend)

Perform action for single user



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class SendExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new UseractionApi();
            var userEmailActionSend = new UserEmailActionSend(); // UserEmailActionSend | 

            try
            {
                // Perform action for single user
                bool? result = apiInstance.Send(userEmailActionSend);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UseractionApi.Send: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userEmailActionSend** | [**UserEmailActionSend**](UserEmailActionSend.md)|  | 

### Return type

**bool?**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

