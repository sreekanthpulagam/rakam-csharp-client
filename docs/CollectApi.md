# Rakam.Client.Api.CollectApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchEvents**](CollectApi.md#batchevents) | **POST** /event/batch | Collect multiple events
[**BulkEvents**](CollectApi.md#bulkevents) | **POST** /event/bulk | Collect Bulk events
[**BulkEventsRemote**](CollectApi.md#bulkeventsremote) | **POST** /event/bulk/remote | Collect bulk events from remote
[**CollectEvent**](CollectApi.md#collectevent) | **POST** /event/collect | Collect event
[**CommitBulkEvents**](CollectApi.md#commitbulkevents) | **POST** /event/bulk/commit | Commit Bulk events


<a name="batchevents"></a>
# **BatchEvents**
> int? BatchEvents (EventList eventList)

Collect multiple events

Returns 1 if the events are collected.

### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class BatchEventsExample
    {
        public void main()
        {
            
            var apiInstance = new CollectApi();
            var eventList = new EventList(); // EventList | 

            try
            {
                // Collect multiple events
                int? result = apiInstance.BatchEvents(eventList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectApi.BatchEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventList** | [**EventList**](EventList.md)|  | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkevents"></a>
# **BulkEvents**
> SuccessMessage BulkEvents (EventList eventList)

Collect Bulk events

Bulk API requires master_key as api key and designed to handle large value of data. The endpoint also accepts application/avro and text/csv formats. You need need to set 'collection' and 'master_key' query parameters if the content-type is not application/json.

### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class BulkEventsExample
    {
        public void main()
        {
            
            var apiInstance = new CollectApi();
            var eventList = new EventList(); // EventList | 

            try
            {
                // Collect Bulk events
                SuccessMessage result = apiInstance.BulkEvents(eventList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectApi.BulkEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventList** | [**EventList**](EventList.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkeventsremote"></a>
# **BulkEventsRemote**
> int? BulkEventsRemote (BulkEventRemote bulkEventRemote)

Collect bulk events from remote



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class BulkEventsRemoteExample
    {
        public void main()
        {
            
            var apiInstance = new CollectApi();
            var bulkEventRemote = new BulkEventRemote(); // BulkEventRemote | 

            try
            {
                // Collect bulk events from remote
                int? result = apiInstance.BulkEventsRemote(bulkEventRemote);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectApi.BulkEventsRemote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bulkEventRemote** | [**BulkEventRemote**](BulkEventRemote.md)|  | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectevent"></a>
# **CollectEvent**
> int? CollectEvent (ModelEvent _event)

Collect event



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CollectEventExample
    {
        public void main()
        {
            
            var apiInstance = new CollectApi();
            var _event = new ModelEvent(); // ModelEvent | 

            try
            {
                // Collect event
                int? result = apiInstance.CollectEvent(_event);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectApi.CollectEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_event** | [**ModelEvent**](ModelEvent.md)|  | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="commitbulkevents"></a>
# **CommitBulkEvents**
> SuccessMessage CommitBulkEvents (CommitBulkEvents commitBulkEvents)

Commit Bulk events



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CommitBulkEventsExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new CollectApi();
            var commitBulkEvents = new CommitBulkEvents(); // CommitBulkEvents | 

            try
            {
                // Commit Bulk events
                SuccessMessage result = apiInstance.CommitBulkEvents(commitBulkEvents);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectApi.CommitBulkEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commitBulkEvents** | [**CommitBulkEvents**](CommitBulkEvents.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

