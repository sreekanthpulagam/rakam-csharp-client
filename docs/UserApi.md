# Rakam.Client.Api.UserApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSegment**](UserApi.md#createsegment) | **POST** /user/create_segment | Get events of the user
[**CreateUser**](UserApi.md#createuser) | **POST** /user/create | Create new user
[**CreateUsers**](UserApi.md#createusers) | **POST** /user/batch/create | Create multiple new users
[**GetEvents**](UserApi.md#getevents) | **POST** /user/get_events | Get events of the user
[**GetMetadata**](UserApi.md#getmetadata) | **GET** /user/metadata | Get user storage metadata
[**GetUser**](UserApi.md#getuser) | **POST** /user/get | Get user
[**IncrementProperty**](UserApi.md#incrementproperty) | **POST** /user/increment_property | Set user property
[**SearchUsers**](UserApi.md#searchusers) | **POST** /user/search | Search users
[**SetProperties**](UserApi.md#setproperties) | **POST** /user/set_properties | Set user properties
[**SetPropertiesOnce**](UserApi.md#setpropertiesonce) | **POST** /user/set_properties_once | Set user properties once
[**UnsetProperty**](UserApi.md#unsetproperty) | **POST** /user/unset_properties | Unset user property


<a name="createsegment"></a>
# **CreateSegment**
> SuccessMessage CreateSegment (UserCreateSegment userCreateSegment)

Get events of the user



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateSegmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new UserApi();
            var userCreateSegment = new UserCreateSegment(); // UserCreateSegment | 

            try
            {
                // Get events of the user
                SuccessMessage result = apiInstance.CreateSegment(userCreateSegment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateSegment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userCreateSegment** | [**UserCreateSegment**](UserCreateSegment.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> int? CreateUser (User user)

Create new user



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var user = new User(); // User | 

            try
            {
                // Create new user
                int? result = apiInstance.CreateUser(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**User**](User.md)|  | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createusers"></a>
# **CreateUsers**
> List<Object> CreateUsers (UserCreateUsers userCreateUsers)

Create multiple new users

Returns user ids. User id may be string or numeric.

### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateUsersExample
    {
        public void main()
        {
            
            // Configure API key authorization: write_key
            Configuration.Default.ApiKey.Add("write_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("write_key", "Bearer");

            var apiInstance = new UserApi();
            var userCreateUsers = new UserCreateUsers(); // UserCreateUsers | 

            try
            {
                // Create multiple new users
                List&lt;Object&gt; result = apiInstance.CreateUsers(userCreateUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userCreateUsers** | [**UserCreateUsers**](UserCreateUsers.md)|  | 

### Return type

**List<Object>**

### Authorization

[write_key](../README.md#write_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> List<CollectionEvent> GetEvents (UserGetEvents userGetEvents)

Get events of the user



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new UserApi();
            var userGetEvents = new UserGetEvents(); // UserGetEvents | 

            try
            {
                // Get events of the user
                List&lt;CollectionEvent&gt; result = apiInstance.GetEvents(userGetEvents);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGetEvents** | [**UserGetEvents**](UserGetEvents.md)|  | 

### Return type

[**List<CollectionEvent>**](CollectionEvent.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata"></a>
# **GetMetadata**
> MetadataResponse GetMetadata ()

Get user storage metadata



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetMetadataExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                // Get user storage metadata
                MetadataResponse result = apiInstance.GetMetadata();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MetadataResponse**](MetadataResponse.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> User GetUser (UserGetUser userGetUser)

Get user



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new UserApi();
            var userGetUser = new UserGetUser(); // UserGetUser | 

            try
            {
                // Get user
                User result = apiInstance.GetUser(userGetUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGetUser** | [**UserGetUser**](UserGetUser.md)|  | 

### Return type

[**User**](User.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incrementproperty"></a>
# **IncrementProperty**
> SuccessMessage IncrementProperty (UserIncrementProperty userIncrementProperty)

Set user property



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class IncrementPropertyExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new UserApi();
            var userIncrementProperty = new UserIncrementProperty(); // UserIncrementProperty | 

            try
            {
                // Set user property
                SuccessMessage result = apiInstance.IncrementProperty(userIncrementProperty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.IncrementProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userIncrementProperty** | [**UserIncrementProperty**](UserIncrementProperty.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchusers"></a>
# **SearchUsers**
> QueryResult SearchUsers (UserSearchUsers userSearchUsers)

Search users



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new UserApi();
            var userSearchUsers = new UserSearchUsers(); // UserSearchUsers | 

            try
            {
                // Search users
                QueryResult result = apiInstance.SearchUsers(userSearchUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.SearchUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userSearchUsers** | [**UserSearchUsers**](UserSearchUsers.md)|  | 

### Return type

[**QueryResult**](QueryResult.md)

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setproperties"></a>
# **SetProperties**
> int? SetProperties (User user)

Set user properties



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class SetPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var user = new User(); // User | 

            try
            {
                // Set user properties
                int? result = apiInstance.SetProperties(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.SetProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**User**](User.md)|  | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpropertiesonce"></a>
# **SetPropertiesOnce**
> int? SetPropertiesOnce (User user)

Set user properties once



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class SetPropertiesOnceExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var user = new User(); // User | 

            try
            {
                // Set user properties once
                int? result = apiInstance.SetPropertiesOnce(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.SetPropertiesOnce: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**User**](User.md)|  | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsetproperty"></a>
# **UnsetProperty**
> SuccessMessage UnsetProperty (UserUnsetProperty userUnsetProperty)

Unset user property



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class UnsetPropertyExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var userUnsetProperty = new UserUnsetProperty(); // UserUnsetProperty | 

            try
            {
                // Unset user property
                SuccessMessage result = apiInstance.UnsetProperty(userUnsetProperty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UnsetProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userUnsetProperty** | [**UserUnsetProperty**](UserUnsetProperty.md)|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

