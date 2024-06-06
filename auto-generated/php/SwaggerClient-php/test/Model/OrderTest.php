<?php
/**
 * OrderTest
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section.
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 2.4.42-SNAPSHOT
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Please update the test case below to test the model.
 */

namespace Swagger\Client;

/**
 * OrderTest Class Doc Comment
 *
 * @category    Class
 * @description Placement, Cancellation, Amending, and History
 * @package     Swagger\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class OrderTest extends \PHPUnit_Framework_TestCase
{

    /**
     * Setup before running any test case
     */
    public static function setUpBeforeClass()
    {
    }

    /**
     * Setup before running each test case
     */
    public function setUp()
    {
    }

    /**
     * Clean up after running each test case
     */
    public function tearDown()
    {
    }

    /**
     * Clean up after running all test cases
     */
    public static function tearDownAfterClass()
    {
    }

    /**
     * Test "Order"
     */
    public function testOrder()
    {
    }

    /**
     * Test attribute "order_id"
     */
    public function testPropertyOrderId()
    {
    }

    /**
     * Test attribute "cl_ord_id"
     */
    public function testPropertyClOrdId()
    {
    }

    /**
     * Test attribute "cl_ord_link_id"
     */
    public function testPropertyClOrdLinkId()
    {
    }

    /**
     * Test attribute "account"
     */
    public function testPropertyAccount()
    {
    }

    /**
     * Test attribute "symbol"
     */
    public function testPropertySymbol()
    {
    }

    /**
     * Test attribute "side"
     */
    public function testPropertySide()
    {
    }

    /**
     * Test attribute "order_qty"
     */
    public function testPropertyOrderQty()
    {
    }

    /**
     * Test attribute "price"
     */
    public function testPropertyPrice()
    {
    }

    /**
     * Test attribute "display_qty"
     */
    public function testPropertyDisplayQty()
    {
    }

    /**
     * Test attribute "stop_px"
     */
    public function testPropertyStopPx()
    {
    }

    /**
     * Test attribute "peg_offset_value"
     */
    public function testPropertyPegOffsetValue()
    {
    }

    /**
     * Test attribute "peg_price_type"
     */
    public function testPropertyPegPriceType()
    {
    }

    /**
     * Test attribute "currency"
     */
    public function testPropertyCurrency()
    {
    }

    /**
     * Test attribute "settl_currency"
     */
    public function testPropertySettlCurrency()
    {
    }

    /**
     * Test attribute "ord_type"
     */
    public function testPropertyOrdType()
    {
    }

    /**
     * Test attribute "time_in_force"
     */
    public function testPropertyTimeInForce()
    {
    }

    /**
     * Test attribute "exec_inst"
     */
    public function testPropertyExecInst()
    {
    }

    /**
     * Test attribute "contingency_type"
     */
    public function testPropertyContingencyType()
    {
    }

    /**
     * Test attribute "ord_status"
     */
    public function testPropertyOrdStatus()
    {
    }

    /**
     * Test attribute "triggered"
     */
    public function testPropertyTriggered()
    {
    }

    /**
     * Test attribute "working_indicator"
     */
    public function testPropertyWorkingIndicator()
    {
    }

    /**
     * Test attribute "ord_rej_reason"
     */
    public function testPropertyOrdRejReason()
    {
    }

    /**
     * Test attribute "leaves_qty"
     */
    public function testPropertyLeavesQty()
    {
    }

    /**
     * Test attribute "cum_qty"
     */
    public function testPropertyCumQty()
    {
    }

    /**
     * Test attribute "avg_px"
     */
    public function testPropertyAvgPx()
    {
    }

    /**
     * Test attribute "text"
     */
    public function testPropertyText()
    {
    }

    /**
     * Test attribute "transact_time"
     */
    public function testPropertyTransactTime()
    {
    }

    /**
     * Test attribute "timestamp"
     */
    public function testPropertyTimestamp()
    {
    }
}
