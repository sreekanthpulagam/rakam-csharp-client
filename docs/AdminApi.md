# Rakam.Client.Api.AdminApi

All URIs are relative to *https://app.rakam.io/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomFieldsToSchema**](AdminApi.md#addcustomfieldstoschema) | **POST** /project/schema/add/custom | Add fields to collections by transforming other schemas
[**AddFieldsToSchema**](AdminApi.md#addfieldstoschema) | **POST** /project/schema/add | Add fields to collections
[**CheckApiKeys**](AdminApi.md#checkapikeys) | **POST** /project/check-api-keys | Create API Keys
[**CheckLockKey**](AdminApi.md#checklockkey) | **POST** /admin/lock_key | Check lock key
[**Collections**](AdminApi.md#collections) | **POST** /project/collection | Get collection names
[**CreateApiKeys**](AdminApi.md#createapikeys) | **POST** /project/create-api-keys | Create API Keys
[**CreateProject**](AdminApi.md#createproject) | **POST** /project/create | Create project
[**DeleteProject**](AdminApi.md#deleteproject) | **DELETE** /project/delete | Delete project
[**GetConfigurations**](AdminApi.md#getconfigurations) | **GET** /admin/configurations | List installed modules
[**GetProjects**](AdminApi.md#getprojects) | **GET** /project/list | List created projects
[**GetStats**](AdminApi.md#getstats) | **POST** /project/stats | Get project stats
[**GetTypes**](AdminApi.md#gettypes) | **GET** /admin/types | Get types
[**RevokeApiKeys**](AdminApi.md#revokeapikeys) | **DELETE** /project/revoke-api-keys | Revoke API Keys
[**Schema**](AdminApi.md#schema) | **POST** /project/schema | Get collection schema


<a name="addcustomfieldstoschema"></a>
# **AddCustomFieldsToSchema**
> List<SchemaField> AddCustomFieldsToSchema (ProjectAddCustomFieldsToSchema projectAddCustomFieldsToSchema)

Add fields to collections by transforming other schemas



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class AddCustomFieldsToSchemaExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();
            var projectAddCustomFieldsToSchema = new ProjectAddCustomFieldsToSchema(); // ProjectAddCustomFieldsToSchema | 

            try
            {
                // Add fields to collections by transforming other schemas
                List&lt;SchemaField&gt; result = apiInstance.AddCustomFieldsToSchema(projectAddCustomFieldsToSchema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AddCustomFieldsToSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectAddCustomFieldsToSchema** | [**ProjectAddCustomFieldsToSchema**](ProjectAddCustomFieldsToSchema.md)|  | 

### Return type

[**List<SchemaField>**](SchemaField.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfieldstoschema"></a>
# **AddFieldsToSchema**
> List<SchemaField> AddFieldsToSchema (ProjectAddFieldsToSchema projectAddFieldsToSchema)

Add fields to collections



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class AddFieldsToSchemaExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();
            var projectAddFieldsToSchema = new ProjectAddFieldsToSchema(); // ProjectAddFieldsToSchema | 

            try
            {
                // Add fields to collections
                List&lt;SchemaField&gt; result = apiInstance.AddFieldsToSchema(projectAddFieldsToSchema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AddFieldsToSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectAddFieldsToSchema** | [**ProjectAddFieldsToSchema**](ProjectAddFieldsToSchema.md)|  | 

### Return type

[**List<SchemaField>**](SchemaField.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkapikeys"></a>
# **CheckApiKeys**
> List<bool?> CheckApiKeys (ProjectCheckApiKeys projectCheckApiKeys)

Create API Keys



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CheckApiKeysExample
    {
        public void main()
        {
            
            var apiInstance = new AdminApi();
            var projectCheckApiKeys = new ProjectCheckApiKeys(); // ProjectCheckApiKeys | 

            try
            {
                // Create API Keys
                List&lt;bool?&gt; result = apiInstance.CheckApiKeys(projectCheckApiKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.CheckApiKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectCheckApiKeys** | [**ProjectCheckApiKeys**](ProjectCheckApiKeys.md)|  | 

### Return type

**List<bool?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checklockkey"></a>
# **CheckLockKey**
> bool? CheckLockKey (CheckLockKey checkLockKey)

Check lock key



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CheckLockKeyExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();
            var checkLockKey = new CheckLockKey(); // CheckLockKey | 

            try
            {
                // Check lock key
                bool? result = apiInstance.CheckLockKey(checkLockKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.CheckLockKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **checkLockKey** | [**CheckLockKey**](CheckLockKey.md)|  | 

### Return type

**bool?**

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collections"></a>
# **Collections**
> List<string> Collections ()

Get collection names



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CollectionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new AdminApi();

            try
            {
                // Get collection names
                List&lt;string&gt; result = apiInstance.Collections();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.Collections: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapikeys"></a>
# **CreateApiKeys**
> ProjectApiKeys CreateApiKeys ()

Create API Keys



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateApiKeysExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();

            try
            {
                // Create API Keys
                ProjectApiKeys result = apiInstance.CreateApiKeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.CreateApiKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProjectApiKeys**](ProjectApiKeys.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproject"></a>
# **CreateProject**
> ProjectApiKeys CreateProject (CreateProject createProject)

Create project



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class CreateProjectExample
    {
        public void main()
        {
            
            var apiInstance = new AdminApi();
            var createProject = new CreateProject(); // CreateProject | 

            try
            {
                // Create project
                ProjectApiKeys result = apiInstance.CreateProject(createProject);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.CreateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createProject** | [**CreateProject**](CreateProject.md)|  | 

### Return type

[**ProjectApiKeys**](ProjectApiKeys.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproject"></a>
# **DeleteProject**
> SuccessMessage DeleteProject ()

Delete project



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class DeleteProjectExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();

            try
            {
                // Delete project
                SuccessMessage result = apiInstance.DeleteProject();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.DeleteProject: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigurations"></a>
# **GetConfigurations**
> List<ModuleDescriptor> GetConfigurations ()

List installed modules



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetConfigurationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();

            try
            {
                // List installed modules
                List&lt;ModuleDescriptor&gt; result = apiInstance.GetConfigurations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.GetConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModuleDescriptor>**](ModuleDescriptor.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojects"></a>
# **GetProjects**
> List<string> GetProjects ()

List created projects



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new AdminApi();

            try
            {
                // List created projects
                List&lt;string&gt; result = apiInstance.GetProjects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.GetProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstats"></a>
# **GetStats**
> Dictionary<string, Stats> GetStats (ProjectGetStats projectGetStats)

Get project stats



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetStatsExample
    {
        public void main()
        {
            
            var apiInstance = new AdminApi();
            var projectGetStats = new ProjectGetStats(); // ProjectGetStats | 

            try
            {
                // Get project stats
                Dictionary&lt;string, Stats&gt; result = apiInstance.GetStats(projectGetStats);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.GetStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectGetStats** | [**ProjectGetStats**](ProjectGetStats.md)|  | 

### Return type

[**Dictionary<string, Stats>**](Stats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettypes"></a>
# **GetTypes**
> Dictionary<string, string> GetTypes ()

Get types



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class GetTypesExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();

            try
            {
                // Get types
                Dictionary&lt;string, string&gt; result = apiInstance.GetTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.GetTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, string>**

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokeapikeys"></a>
# **RevokeApiKeys**
> SuccessMessage RevokeApiKeys (string masterKey)

Revoke API Keys



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class RevokeApiKeysExample
    {
        public void main()
        {
            
            // Configure API key authorization: master_key
            Configuration.Default.ApiKey.Add("master_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("master_key", "Bearer");

            var apiInstance = new AdminApi();
            var masterKey = masterKey_example;  // string | 

            try
            {
                // Revoke API Keys
                SuccessMessage result = apiInstance.RevokeApiKeys(masterKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.RevokeApiKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterKey** | **string**|  | 

### Return type

[**SuccessMessage**](SuccessMessage.md)

### Authorization

[master_key](../README.md#master_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schema"></a>
# **Schema**
> List<Collection> Schema (ProjectSchema projectSchema)

Get collection schema



### Example
```csharp
using System;
using System.Diagnostics;
using Rakam.Client.Api;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Example
{
    public class SchemaExample
    {
        public void main()
        {
            
            // Configure API key authorization: read_key
            Configuration.Default.ApiKey.Add("read_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("read_key", "Bearer");

            var apiInstance = new AdminApi();
            var projectSchema = new ProjectSchema(); // ProjectSchema | 

            try
            {
                // Get collection schema
                List&lt;Collection&gt; result = apiInstance.Schema(projectSchema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.Schema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectSchema** | [**ProjectSchema**](ProjectSchema.md)|  | 

### Return type

**List<Collection>**

### Authorization

[read_key](../README.md#read_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

