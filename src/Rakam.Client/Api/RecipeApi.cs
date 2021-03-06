/* 
 * Rakam API Documentation
 *
 * An analytics platform API that lets you create your own analytics services.
 *
 * OpenAPI spec version: 0.5
 * Contact: contact@rakam.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Rakam.Client.Client;
using Rakam.Client.Model;

namespace Rakam.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecipeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>Recipe</returns>
        Recipe ExportRecipe (string accept);

        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>ApiResponse of Recipe</returns>
        ApiResponse<Recipe> ExportRecipeWithHttpInfo (string accept);
        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SuccessMessage</returns>
        SuccessMessage InstallRecipe ();

        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SuccessMessage</returns>
        ApiResponse<SuccessMessage> InstallRecipeWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>Task of Recipe</returns>
        System.Threading.Tasks.Task<Recipe> ExportRecipeAsync (string accept);

        /// <summary>
        /// Export recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>Task of ApiResponse (Recipe)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipe>> ExportRecipeAsyncWithHttpInfo (string accept);
        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SuccessMessage</returns>
        System.Threading.Tasks.Task<SuccessMessage> InstallRecipeAsync ();

        /// <summary>
        /// Install recipe
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SuccessMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessMessage>> InstallRecipeAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RecipeApi : IRecipeApi
    {
        private Rakam.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecipeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Rakam.Client.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecipeApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Rakam.Client.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Rakam.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Export recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>Recipe</returns>
        public Recipe ExportRecipe (string accept)
        {
             ApiResponse<Recipe> localVarResponse = ExportRecipeWithHttpInfo(accept);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Export recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>ApiResponse of Recipe</returns>
        public ApiResponse< Recipe > ExportRecipeWithHttpInfo (string accept)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling RecipeApi->ExportRecipe");

            var localVarPath = "/recipe/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accept != null) localVarHeaderParams.Add("Accept", Configuration.ApiClient.ParameterToString(accept)); // header parameter

            // authentication (master_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("master_key")))
            {
                localVarHeaderParams["master_key"] = Configuration.GetApiKeyWithPrefix("master_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExportRecipe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Recipe>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipe) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recipe)));
            
        }

        /// <summary>
        /// Export recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>Task of Recipe</returns>
        public async System.Threading.Tasks.Task<Recipe> ExportRecipeAsync (string accept)
        {
             ApiResponse<Recipe> localVarResponse = await ExportRecipeAsyncWithHttpInfo(accept);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Export recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <returns>Task of ApiResponse (Recipe)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipe>> ExportRecipeAsyncWithHttpInfo (string accept)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling RecipeApi->ExportRecipe");

            var localVarPath = "/recipe/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accept != null) localVarHeaderParams.Add("Accept", Configuration.ApiClient.ParameterToString(accept)); // header parameter

            // authentication (master_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("master_key")))
            {
                localVarHeaderParams["master_key"] = Configuration.GetApiKeyWithPrefix("master_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExportRecipe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Recipe>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipe) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recipe)));
            
        }

        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SuccessMessage</returns>
        public SuccessMessage InstallRecipe ()
        {
             ApiResponse<SuccessMessage> localVarResponse = InstallRecipeWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SuccessMessage</returns>
        public ApiResponse< SuccessMessage > InstallRecipeWithHttpInfo ()
        {

            var localVarPath = "/recipe/install";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (master_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("master_key")))
            {
                localVarHeaderParams["master_key"] = Configuration.GetApiKeyWithPrefix("master_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InstallRecipe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessMessage)));
            
        }

        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SuccessMessage</returns>
        public async System.Threading.Tasks.Task<SuccessMessage> InstallRecipeAsync ()
        {
             ApiResponse<SuccessMessage> localVarResponse = await InstallRecipeAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Install recipe 
        /// </summary>
        /// <exception cref="Rakam.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SuccessMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessMessage>> InstallRecipeAsyncWithHttpInfo ()
        {

            var localVarPath = "/recipe/install";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (master_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("master_key")))
            {
                localVarHeaderParams["master_key"] = Configuration.GetApiKeyWithPrefix("master_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InstallRecipe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessMessage)));
            
        }

    }
}
