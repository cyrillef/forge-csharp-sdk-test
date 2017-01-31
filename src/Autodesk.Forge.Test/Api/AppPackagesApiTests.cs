/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
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

using Autodesk.Forge.Client;
using Autodesk.Forge;
using Autodesk.Forge.Model;

namespace Autodesk.Forge.Test
{
    /// <summary>
    ///  Class for testing AppPackagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AppPackagesApiTests
    {
        private AppPackagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AppPackagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AppPackagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AppPackagesApi
            //Assert.IsInstanceOfType(typeof(AppPackagesApi), instance, "instance is a AppPackagesApi");
        }

        
        /// <summary>
        /// Test CreateAppPackage
        /// </summary>
        [Test]
        public void CreateAppPackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppPackage appPackage = null;
            //var response = instance.CreateAppPackage(appPackage);
            //Assert.IsInstanceOf<AppPackage> (response, "response is AppPackage");
        }
        
        /// <summary>
        /// Test DeleteAppPackage
        /// </summary>
        [Test]
        public void DeleteAppPackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteAppPackage(id);
            
        }
        
        /// <summary>
        /// Test DeleteAppPackageHistory
        /// </summary>
        [Test]
        public void DeleteAppPackageHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteAppPackageHistory(id);
            
        }
        
        /// <summary>
        /// Test GetAllAppPackages
        /// </summary>
        [Test]
        public void GetAllAppPackagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllAppPackages();
            //Assert.IsInstanceOf<List<AppPackage>> (response, "response is List<AppPackage>");
        }
        
        /// <summary>
        /// Test GetAppPackage
        /// </summary>
        [Test]
        public void GetAppPackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetAppPackage(id);
            //Assert.IsInstanceOf<AppPackage> (response, "response is AppPackage");
        }
        
        /// <summary>
        /// Test GetAppPackageVersions
        /// </summary>
        [Test]
        public void GetAppPackageVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetAppPackageVersions(id);
            //Assert.IsInstanceOf<List<AppPackage>> (response, "response is List<AppPackage>");
        }
        
        /// <summary>
        /// Test GetUploadUrl
        /// </summary>
        [Test]
        public void GetUploadUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetUploadUrl();
            
        }
        
        /// <summary>
        /// Test GetUploadUrlWithRequireContentType
        /// </summary>
        [Test]
        public void GetUploadUrlWithRequireContentTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? require = null;
            //instance.GetUploadUrlWithRequireContentType(require);
            
        }
        
        /// <summary>
        /// Test PatchAppPackage
        /// </summary>
        [Test]
        public void PatchAppPackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppPackageOptional appPackage = null;
            //instance.PatchAppPackage(id, appPackage);
            
        }
        
        /// <summary>
        /// Test SetAppPackageVersion
        /// </summary>
        [Test]
        public void SetAppPackageVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppPackageVersion appPackageVersion = null;
            //instance.SetAppPackageVersion(id, appPackageVersion);
            
        }
        
        /// <summary>
        /// Test UpdateAppPackage
        /// </summary>
        [Test]
        public void UpdateAppPackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppPackage appPackage = null;
            //instance.UpdateAppPackage(id, appPackage);
            
        }
        
    }

}
