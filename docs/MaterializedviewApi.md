# Rakam.Client.Api.MaterializedviewApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateView**](MaterializedviewApi.md#createview) | **POST** /materialized-view/create | Create view
[**DeleteView**](MaterializedviewApi.md#deleteview) | **POST** /materialized-view/delete | Delete materialized view
[**GetSchemaOfView**](MaterializedviewApi.md#getschemaofview) | **POST** /materialized-view/schema | Get schemas
[**GetView**](MaterializedviewApi.md#getview) | **POST** /materialized-view/get | Get view
[**ListViews**](MaterializedviewApi.md#listviews) | **POST** /materialized-view/list | List views


<a name="createview"></a>
# **CreateView**
> SuccessMessage CreateView (MaterializedView materializedView)

Create view



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateViewExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new MaterializedviewApi();
            var materializedView = new MaterializedView(); // MaterializedView | 

            try
            {
                // Create view
                SuccessMessage result = apiInstance.CreateView(materializedView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterializedviewApi.CreateView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **materializedView** | [**MaterializedView**](MaterializedView.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteview"></a>
# **DeleteView**
> SuccessMessage DeleteView (MaterializedViewDeleteView materializedViewDeleteView)

Delete materialized view



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class DeleteViewExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new MaterializedviewApi();
            var materializedViewDeleteView = new MaterializedViewDeleteView(); // MaterializedViewDeleteView | 

            try
            {
                // Delete materialized view
                SuccessMessage result = apiInstance.DeleteView(materializedViewDeleteView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterializedviewApi.DeleteView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **materializedViewDeleteView** | [**MaterializedViewDeleteView**](MaterializedViewDeleteView.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschemaofview"></a>
# **GetSchemaOfView**
> List<MaterializedViewSchema> GetSchemaOfView (MaterializedViewGetSchemaOfView materializedViewGetSchemaOfView)

Get schemas



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetSchemaOfViewExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new MaterializedviewApi();
            var materializedViewGetSchemaOfView = new MaterializedViewGetSchemaOfView(); // MaterializedViewGetSchemaOfView | 

            try
            {
                // Get schemas
                List&lt;MaterializedViewSchema&gt; result = apiInstance.GetSchemaOfView(materializedViewGetSchemaOfView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterializedviewApi.GetSchemaOfView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **materializedViewGetSchemaOfView** | [**MaterializedViewGetSchemaOfView**](MaterializedViewGetSchemaOfView.md)|  | 

### Return type

[**List<MaterializedViewSchema>**](MaterializedViewSchema.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getview"></a>
# **GetView**
> MaterializedView GetView (MaterializedViewGetView materializedViewGetView)

Get view



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetViewExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new MaterializedviewApi();
            var materializedViewGetView = new MaterializedViewGetView(); // MaterializedViewGetView | 

            try
            {
                // Get view
                MaterializedView result = apiInstance.GetView(materializedViewGetView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterializedviewApi.GetView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **materializedViewGetView** | [**MaterializedViewGetView**](MaterializedViewGetView.md)|  | 

### Return type

[**MaterializedView**](MaterializedView.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listviews"></a>
# **ListViews**
> List<MaterializedView> ListViews ()

List views



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class ListViewsExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new MaterializedviewApi();

            try
            {
                // List views
                List&lt;MaterializedView&gt; result = apiInstance.ListViews();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterializedviewApi.ListViews: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MaterializedView>**](MaterializedView.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

