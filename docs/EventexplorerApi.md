# Rakam.Client.Api.EventexplorerApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyzeEvents**](EventexplorerApi.md#analyzeevents) | **POST** /event-explorer/analyze | Perform simple query on event data
[**CreatePrecomputedTable**](EventexplorerApi.md#createprecomputedtable) | **POST** /event-explorer/pre_calculate | Create Pre-computed table
[**GetEventStatistics**](EventexplorerApi.md#geteventstatistics) | **POST** /event-explorer/statistics | Event statistics
[**GetExtraDimensions**](EventexplorerApi.md#getextradimensions) | **GET** /event-explorer/extra_dimensions | Event statistics


<a name="analyzeevents"></a>
# **AnalyzeEvents**
> QueryResult AnalyzeEvents (AnalyzeRequest analyzeRequest)

Perform simple query on event data



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class AnalyzeEventsExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new EventexplorerApi();
            var analyzeRequest = new AnalyzeRequest(); // AnalyzeRequest | 

            try
            {
                // Perform simple query on event data
                QueryResult result = apiInstance.AnalyzeEvents(analyzeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventexplorerApi.AnalyzeEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **analyzeRequest** | [**AnalyzeRequest**](AnalyzeRequest.md)|  | 

### Return type

[**QueryResult**](QueryResult.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprecomputedtable"></a>
# **CreatePrecomputedTable**
> PrecalculatedTable CreatePrecomputedTable (CreatePrecomputedTable createPrecomputedTable)

Create Pre-computed table



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreatePrecomputedTableExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new EventexplorerApi();
            var createPrecomputedTable = new CreatePrecomputedTable(); // CreatePrecomputedTable | 

            try
            {
                // Create Pre-computed table
                PrecalculatedTable result = apiInstance.CreatePrecomputedTable(createPrecomputedTable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventexplorerApi.CreatePrecomputedTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createPrecomputedTable** | [**CreatePrecomputedTable**](CreatePrecomputedTable.md)|  | 

### Return type

[**PrecalculatedTable**](PrecalculatedTable.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventstatistics"></a>
# **GetEventStatistics**
> QueryResult GetEventStatistics (EventExplorerGetEventStatistics eventExplorerGetEventStatistics)

Event statistics



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetEventStatisticsExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new EventexplorerApi();
            var eventExplorerGetEventStatistics = new EventExplorerGetEventStatistics(); // EventExplorerGetEventStatistics | 

            try
            {
                // Event statistics
                QueryResult result = apiInstance.GetEventStatistics(eventExplorerGetEventStatistics);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventexplorerApi.GetEventStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventExplorerGetEventStatistics** | [**EventExplorerGetEventStatistics**](EventExplorerGetEventStatistics.md)|  | 

### Return type

[**QueryResult**](QueryResult.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getextradimensions"></a>
# **GetExtraDimensions**
> Dictionary<string, List<string>> GetExtraDimensions ()

Event statistics



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetExtraDimensionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new EventexplorerApi();

            try
            {
                // Event statistics
                Dictionary&lt;string, List&lt;string&gt;&gt; result = apiInstance.GetExtraDimensions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventexplorerApi.GetExtraDimensions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, List<string>>**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

