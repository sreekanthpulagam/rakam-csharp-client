# Rakam.Client.Api.FunnelApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyzeFunnel**](FunnelApi.md#analyzefunnel) | **POST** /funnel/analyze | Execute query


<a name="analyzefunnel"></a>
# **AnalyzeFunnel**
> QueryResult AnalyzeFunnel (FunnelQuery funnelQuery)

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
    public class AnalyzeFunnelExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new FunnelApi();
            var funnelQuery = new FunnelQuery(); // FunnelQuery | 

            try
            {
                // Execute query
                QueryResult result = apiInstance.AnalyzeFunnel(funnelQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FunnelApi.AnalyzeFunnel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **funnelQuery** | [**FunnelQuery**](FunnelQuery.md)|  | 

### Return type

[**QueryResult**](QueryResult.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

