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
    ///  Class for testing Address
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AddressTests
    {
        // TODO uncomment below to declare an instance variable for Address
        //private Address instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Address
            //instance = new Address();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Address
        /// </summary>
        [Test]
        public void AddressInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Address
            //Assert.IsInstanceOfType<Address> (instance, "variable 'instance' is a Address");
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
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
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
        /// Test the property '_Address'
        /// </summary>
        [Test]
        public void _AddressTest()
        {
            // TODO unit test for the property '_Address'
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
        /// Test the property 'Note'
        /// </summary>
        [Test]
        public void NoteTest()
        {
            // TODO unit test for the property 'Note'
        }
        /// <summary>
        /// Test the property 'SkipConfirm'
        /// </summary>
        [Test]
        public void SkipConfirmTest()
        {
            // TODO unit test for the property 'SkipConfirm'
        }
        /// <summary>
        /// Test the property 'SkipConfirmVerified'
        /// </summary>
        [Test]
        public void SkipConfirmVerifiedTest()
        {
            // TODO unit test for the property 'SkipConfirmVerified'
        }
        /// <summary>
        /// Test the property 'Skip2FA'
        /// </summary>
        [Test]
        public void Skip2FATest()
        {
            // TODO unit test for the property 'Skip2FA'
        }
        /// <summary>
        /// Test the property 'Skip2FAVerified'
        /// </summary>
        [Test]
        public void Skip2FAVerifiedTest()
        {
            // TODO unit test for the property 'Skip2FAVerified'
        }
        /// <summary>
        /// Test the property 'Network'
        /// </summary>
        [Test]
        public void NetworkTest()
        {
            // TODO unit test for the property 'Network'
        }
        /// <summary>
        /// Test the property 'Memo'
        /// </summary>
        [Test]
        public void MemoTest()
        {
            // TODO unit test for the property 'Memo'
        }

    }

}
