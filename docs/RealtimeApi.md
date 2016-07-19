# Rakam.Client.Api.RealtimeApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTable**](RealtimeApi.md#createtable) | **POST** /realtime/create | Create report
[**DeleteTable**](RealtimeApi.md#deletetable) | **POST** /realtime/delete | Delete report
[**ListTables**](RealtimeApi.md#listtables) | **POST** /realtime/list | List queries
[**QueryTable**](RealtimeApi.md#querytable) | **POST** /realtime/get | Get report


<a name="createtable"></a>
# **CreateTable**
> SuccessMessage CreateTable (RealTimeReport realTimeReport)

Create report



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateTableExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new RealtimeApi();
            var realTimeReport = new RealTimeReport(); // RealTimeReport | 

            try
            {
                // Create report
                SuccessMessage result = apiInstance.CreateTable(realTimeReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealtimeApi.CreateTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realTimeReport** | [**RealTimeReport**](RealTimeReport.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetable"></a>
# **DeleteTable**
> SuccessMessage DeleteTable (RealtimeDeleteTable realtimeDeleteTable)

Delete report



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class DeleteTableExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new RealtimeApi();
            var realtimeDeleteTable = new RealtimeDeleteTable(); // RealtimeDeleteTable | 

            try
            {
                // Delete report
                SuccessMessage result = apiInstance.DeleteTable(realtimeDeleteTable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealtimeApi.DeleteTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realtimeDeleteTable** | [**RealtimeDeleteTable**](RealtimeDeleteTable.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtables"></a>
# **ListTables**
> List<ContinuousQuery> ListTables ()

List queries



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class ListTablesExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new RealtimeApi();

            try
            {
                // List queries
                List&lt;ContinuousQuery&gt; result = apiInstance.ListTables();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealtimeApi.ListTables: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ContinuousQuery>**](ContinuousQuery.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querytable"></a>
# **QueryTable**
> RealTimeQueryResult QueryTable (RealtimeQueryTable realtimeQueryTable)

Get report



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class QueryTableExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new RealtimeApi();
            var realtimeQueryTable = new RealtimeQueryTable(); // RealtimeQueryTable | 

            try
            {
                // Get report
                RealTimeQueryResult result = apiInstance.QueryTable(realtimeQueryTable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealtimeApi.QueryTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realtimeQueryTable** | [**RealtimeQueryTable**](RealtimeQueryTable.md)|  | 

### Return type

[**RealTimeQueryResult**](RealTimeQueryResult.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

