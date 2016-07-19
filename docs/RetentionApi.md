# Rakam.Client.Api.RetentionApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyzeRetention**](RetentionApi.md#analyzeretention) | **POST** /retention/analyze | Execute query


<a name="analyzeretention"></a>
# **AnalyzeRetention**
> QueryResult AnalyzeRetention (RetentionQuery retentionQuery)

Execute query



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class AnalyzeRetentionExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new RetentionApi();
            var retentionQuery = new RetentionQuery(); // RetentionQuery | 

            try
            {
                // Execute query
                QueryResult result = apiInstance.AnalyzeRetention(retentionQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RetentionApi.AnalyzeRetention: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **retentionQuery** | [**RetentionQuery**](RetentionQuery.md)|  | 

### Return type

[**QueryResult**](QueryResult.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

