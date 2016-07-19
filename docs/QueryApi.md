# Rakam.Client.Api.QueryApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Execute**](QueryApi.md#execute) | **POST** /query/execute | Execute query on event data-set
[**Explain**](QueryApi.md#explain) | **POST** /query/explain | Explain query
[**Metadata**](QueryApi.md#metadata) | **POST** /query/metadata | Test query


<a name="execute"></a>
# **Execute**
> QueryResult Execute (Execute execute)

Execute query on event data-set



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class ExecuteExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new QueryApi();
            var execute = new Execute(); // Execute | 

            try
            {
                // Execute query on event data-set
                QueryResult result = apiInstance.Execute(execute);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueryApi.Execute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execute** | [**Execute**](Execute.md)|  | 

### Return type

[**QueryResult**](QueryResult.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="explain"></a>
# **Explain**
> ResponseQuery Explain (Explain explain)

Explain query



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class ExplainExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new QueryApi();
            var explain = new Explain(); // Explain | 

            try
            {
                // Explain query
                ResponseQuery result = apiInstance.Explain(explain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueryApi.Explain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **explain** | [**Explain**](Explain.md)|  | 

### Return type

[**ResponseQuery**](ResponseQuery.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metadata"></a>
# **Metadata**
> List<SchemaField> Metadata (QueryMetadata queryMetadata)

Test query



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class MetadataExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new QueryApi();
            var queryMetadata = new QueryMetadata(); // QueryMetadata | 

            try
            {
                // Test query
                List&lt;SchemaField&gt; result = apiInstance.Metadata(queryMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueryApi.Metadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryMetadata** | [**QueryMetadata**](QueryMetadata.md)|  | 

### Return type

[**List<SchemaField>**](SchemaField.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

