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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Rakam.Client.Client;
using Rakam.Client.Api;
using Rakam.Client.Model;

namespace Rakam.Client.Test
{
    /// <summary>
    ///  Class for testing MaterializedviewApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MaterializedviewApiTests
    {
        private MaterializedviewApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MaterializedviewApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MaterializedviewApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' MaterializedviewApi
            Assert.IsInstanceOfType(typeof(MaterializedviewApi), instance, "instance is a MaterializedviewApi");
        }

        
        /// <summary>
        /// Test CreateView
        /// </summary>
        [Test]
        public void CreateViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MaterializedView materializedView = null;
            //var response = instance.CreateView(materializedView);
            //Assert.IsInstanceOf<SuccessMessage> (response, "response is SuccessMessage");
        }
        
        /// <summary>
        /// Test DeleteView
        /// </summary>
        [Test]
        public void DeleteViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MaterializedViewDeleteView materializedViewDeleteView = null;
            //var response = instance.DeleteView(materializedViewDeleteView);
            //Assert.IsInstanceOf<SuccessMessage> (response, "response is SuccessMessage");
        }
        
        /// <summary>
        /// Test GetSchemaOfView
        /// </summary>
        [Test]
        public void GetSchemaOfViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MaterializedViewGetSchemaOfView materializedViewGetSchemaOfView = null;
            //var response = instance.GetSchemaOfView(materializedViewGetSchemaOfView);
            //Assert.IsInstanceOf<List<MaterializedViewSchema>> (response, "response is List<MaterializedViewSchema>");
        }
        
        /// <summary>
        /// Test GetView
        /// </summary>
        [Test]
        public void GetViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MaterializedViewGetView materializedViewGetView = null;
            //var response = instance.GetView(materializedViewGetView);
            //Assert.IsInstanceOf<MaterializedView> (response, "response is MaterializedView");
        }
        
        /// <summary>
        /// Test ListViews
        /// </summary>
        [Test]
        public void ListViewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListViews();
            //Assert.IsInstanceOf<List<MaterializedView>> (response, "response is List<MaterializedView>");
        }
        
    }

}
