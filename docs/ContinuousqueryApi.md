# Rakam.Client.Api.ContinuousqueryApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateQuery**](ContinuousqueryApi.md#createquery) | **POST** /continuous-query/create | Create stream
[**DeleteQuery**](ContinuousqueryApi.md#deletequery) | **POST** /continuous-query/delete | Delete stream
[**GetQuery**](ContinuousqueryApi.md#getquery) | **POST** /continuous-query/get | Get continuous query
[**GetSchemaOfQuery**](ContinuousqueryApi.md#getschemaofquery) | **POST** /continuous-query/schema | Get query schema
[**ListQueries**](ContinuousqueryApi.md#listqueries) | **POST** /continuous-query/list | List queries
[**TestQuery**](ContinuousqueryApi.md#testquery) | **POST** /continuous-query/test | Test continuous query


<a name="createquery"></a>
# **CreateQuery**
> SuccessMessage CreateQuery (ContinuousQuery continuousQuery)

Create stream

Creates a new continuous query for specified SQL query. Rakam will process data in batches keep the result of query in-memory all the time. Compared to reports, continuous queries continuously aggregate the data on the fly and the result is always available either in-memory or disk.

### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateQueryExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new ContinuousqueryApi();
            var continuousQuery = new ContinuousQuery(); // ContinuousQuery | 

            try
            {
                // Create stream
                SuccessMessage result = apiInstance.CreateQuery(continuousQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContinuousqueryApi.CreateQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **continuousQuery** | [**ContinuousQuery**](ContinuousQuery.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequery"></a>
# **DeleteQuery**
> SuccessMessage DeleteQuery (ContinuousQueryDeleteQuery continuousQueryDeleteQuery)

Delete stream



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class DeleteQueryExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new ContinuousqueryApi();
            var continuousQueryDeleteQuery = new ContinuousQueryDeleteQuery(); // ContinuousQueryDeleteQuery | 

            try
            {
                // Delete stream
                SuccessMessage result = apiInstance.DeleteQuery(continuousQueryDeleteQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContinuousqueryApi.DeleteQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **continuousQueryDeleteQuery** | [**ContinuousQueryDeleteQuery**](ContinuousQueryDeleteQuery.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquery"></a>
# **GetQuery**
> ContinuousQuery GetQuery (ContinuousQueryGetQuery continuousQueryGetQuery)

Get continuous query



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetQueryExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new ContinuousqueryApi();
            var continuousQueryGetQuery = new ContinuousQueryGetQuery(); // ContinuousQueryGetQuery | 

            try
            {
                // Get continuous query
                ContinuousQuery result = apiInstance.GetQuery(continuousQueryGetQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContinuousqueryApi.GetQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **continuousQueryGetQuery** | [**ContinuousQueryGetQuery**](ContinuousQueryGetQuery.md)|  | 

### Return type

[**ContinuousQuery**](ContinuousQuery.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschemaofquery"></a>
# **GetSchemaOfQuery**
> List<Collection> GetSchemaOfQuery (ContinuousQueryGetSchemaOfQuery continuousQueryGetSchemaOfQuery)

Get query schema



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetSchemaOfQueryExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new ContinuousqueryApi();
            var continuousQueryGetSchemaOfQuery = new ContinuousQueryGetSchemaOfQuery(); // ContinuousQueryGetSchemaOfQuery | 

            try
            {
                // Get query schema
                List&lt;Collection&gt; result = apiInstance.GetSchemaOfQuery(continuousQueryGetSchemaOfQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContinuousqueryApi.GetSchemaOfQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **continuousQueryGetSchemaOfQuery** | [**ContinuousQueryGetSchemaOfQuery**](ContinuousQueryGetSchemaOfQuery.md)|  | 

### Return type

**List<Collection>**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listqueries"></a>
# **ListQueries**
> List<ContinuousQuery> ListQueries ()

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
    public class ListQueriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new ContinuousqueryApi();

            try
            {
                // List queries
                List&lt;ContinuousQuery&gt; result = apiInstance.ListQueries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContinuousqueryApi.ListQueries: " + e.Message );
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

<a name="testquery"></a>
# **TestQuery**
> bool? TestQuery (ContinuousQueryTestQuery continuousQueryTestQuery)

Test continuous query



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class TestQueryExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new ContinuousqueryApi();
            var continuousQueryTestQuery = new ContinuousQueryTestQuery(); // ContinuousQueryTestQuery | 

            try
            {
                // Test continuous query
                bool? result = apiInstance.TestQuery(continuousQueryTestQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContinuousqueryApi.TestQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **continuousQueryTestQuery** | [**ContinuousQueryTestQuery**](ContinuousQueryTestQuery.md)|  | 

### Return type

**bool?**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

