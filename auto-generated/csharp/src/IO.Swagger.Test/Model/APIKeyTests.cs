/* 
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing APIKey
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class APIKeyTests
    {
        // TODO uncomment below to declare an instance variable for APIKey
        //private APIKey instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of APIKey
            //instance = new APIKey();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APIKey
        /// </summary>
        [Test]
        public void APIKeyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" APIKey
            //Assert.IsInstanceOfType<APIKey> (instance, "variable 'instance' is a APIKey");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Secret'
        /// </summary>
        [Test]
        public void SecretTest()
        {
            // TODO unit test for the property 'Secret'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Nonce'
        /// </summary>
        [Test]
        public void NonceTest()
        {
            // TODO unit test for the property 'Nonce'
        }
        /// <summary>
        /// Test the property 'Cidr'
        /// </summary>
        [Test]
        public void CidrTest()
        {
            // TODO unit test for the property 'Cidr'
        }
        /// <summary>
        /// Test the property 'Cidrs'
        /// </summary>
        [Test]
        public void CidrsTest()
        {
            // TODO unit test for the property 'Cidrs'
        }
        /// <summary>
        /// Test the property 'TargetAccountId'
        /// </summary>
        [Test]
        public void TargetAccountIdTest()
        {
            // TODO unit test for the property 'TargetAccountId'
        }
        /// <summary>
        /// Test the property 'Permissions'
        /// </summary>
        [Test]
        public void PermissionsTest()
        {
            // TODO unit test for the property 'Permissions'
        }
        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }

    }

}
