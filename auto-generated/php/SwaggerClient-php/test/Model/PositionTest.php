<?php
/**
 * PositionTest
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
 * PositionTest Class Doc Comment
 *
 * @category    Class
 * @description Summary of Open and Closed Positions
 * @package     Swagger\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class PositionTest extends \PHPUnit_Framework_TestCase
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
     * Test "Position"
     */
    public function testPosition()
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
     * Test attribute "currency"
     */
    public function testPropertyCurrency()
    {
    }

    /**
     * Test attribute "underlying"
     */
    public function testPropertyUnderlying()
    {
    }

    /**
     * Test attribute "quote_currency"
     */
    public function testPropertyQuoteCurrency()
    {
    }

    /**
     * Test attribute "commission"
     */
    public function testPropertyCommission()
    {
    }

    /**
     * Test attribute "init_margin_req"
     */
    public function testPropertyInitMarginReq()
    {
    }

    /**
     * Test attribute "maint_margin_req"
     */
    public function testPropertyMaintMarginReq()
    {
    }

    /**
     * Test attribute "risk_limit"
     */
    public function testPropertyRiskLimit()
    {
    }

    /**
     * Test attribute "leverage"
     */
    public function testPropertyLeverage()
    {
    }

    /**
     * Test attribute "cross_margin"
     */
    public function testPropertyCrossMargin()
    {
    }

    /**
     * Test attribute "deleverage_percentile"
     */
    public function testPropertyDeleveragePercentile()
    {
    }

    /**
     * Test attribute "rebalanced_pnl"
     */
    public function testPropertyRebalancedPnl()
    {
    }

    /**
     * Test attribute "prev_realised_pnl"
     */
    public function testPropertyPrevRealisedPnl()
    {
    }

    /**
     * Test attribute "prev_unrealised_pnl"
     */
    public function testPropertyPrevUnrealisedPnl()
    {
    }

    /**
     * Test attribute "opening_qty"
     */
    public function testPropertyOpeningQty()
    {
    }

    /**
     * Test attribute "open_order_buy_qty"
     */
    public function testPropertyOpenOrderBuyQty()
    {
    }

    /**
     * Test attribute "open_order_buy_cost"
     */
    public function testPropertyOpenOrderBuyCost()
    {
    }

    /**
     * Test attribute "open_order_buy_premium"
     */
    public function testPropertyOpenOrderBuyPremium()
    {
    }

    /**
     * Test attribute "open_order_sell_qty"
     */
    public function testPropertyOpenOrderSellQty()
    {
    }

    /**
     * Test attribute "open_order_sell_cost"
     */
    public function testPropertyOpenOrderSellCost()
    {
    }

    /**
     * Test attribute "open_order_sell_premium"
     */
    public function testPropertyOpenOrderSellPremium()
    {
    }

    /**
     * Test attribute "current_qty"
     */
    public function testPropertyCurrentQty()
    {
    }

    /**
     * Test attribute "current_cost"
     */
    public function testPropertyCurrentCost()
    {
    }

    /**
     * Test attribute "current_comm"
     */
    public function testPropertyCurrentComm()
    {
    }

    /**
     * Test attribute "realised_cost"
     */
    public function testPropertyRealisedCost()
    {
    }

    /**
     * Test attribute "unrealised_cost"
     */
    public function testPropertyUnrealisedCost()
    {
    }

    /**
     * Test attribute "gross_open_premium"
     */
    public function testPropertyGrossOpenPremium()
    {
    }

    /**
     * Test attribute "is_open"
     */
    public function testPropertyIsOpen()
    {
    }

    /**
     * Test attribute "mark_price"
     */
    public function testPropertyMarkPrice()
    {
    }

    /**
     * Test attribute "mark_value"
     */
    public function testPropertyMarkValue()
    {
    }

    /**
     * Test attribute "risk_value"
     */
    public function testPropertyRiskValue()
    {
    }

    /**
     * Test attribute "home_notional"
     */
    public function testPropertyHomeNotional()
    {
    }

    /**
     * Test attribute "foreign_notional"
     */
    public function testPropertyForeignNotional()
    {
    }

    /**
     * Test attribute "pos_state"
     */
    public function testPropertyPosState()
    {
    }

    /**
     * Test attribute "pos_cost"
     */
    public function testPropertyPosCost()
    {
    }

    /**
     * Test attribute "pos_cross"
     */
    public function testPropertyPosCross()
    {
    }

    /**
     * Test attribute "pos_comm"
     */
    public function testPropertyPosComm()
    {
    }

    /**
     * Test attribute "pos_loss"
     */
    public function testPropertyPosLoss()
    {
    }

    /**
     * Test attribute "pos_margin"
     */
    public function testPropertyPosMargin()
    {
    }

    /**
     * Test attribute "pos_maint"
     */
    public function testPropertyPosMaint()
    {
    }

    /**
     * Test attribute "init_margin"
     */
    public function testPropertyInitMargin()
    {
    }

    /**
     * Test attribute "maint_margin"
     */
    public function testPropertyMaintMargin()
    {
    }

    /**
     * Test attribute "realised_pnl"
     */
    public function testPropertyRealisedPnl()
    {
    }

    /**
     * Test attribute "unrealised_pnl"
     */
    public function testPropertyUnrealisedPnl()
    {
    }

    /**
     * Test attribute "unrealised_pnl_pcnt"
     */
    public function testPropertyUnrealisedPnlPcnt()
    {
    }

    /**
     * Test attribute "unrealised_roe_pcnt"
     */
    public function testPropertyUnrealisedRoePcnt()
    {
    }

    /**
     * Test attribute "avg_cost_price"
     */
    public function testPropertyAvgCostPrice()
    {
    }

    /**
     * Test attribute "avg_entry_price"
     */
    public function testPropertyAvgEntryPrice()
    {
    }

    /**
     * Test attribute "break_even_price"
     */
    public function testPropertyBreakEvenPrice()
    {
    }

    /**
     * Test attribute "margin_call_price"
     */
    public function testPropertyMarginCallPrice()
    {
    }

    /**
     * Test attribute "liquidation_price"
     */
    public function testPropertyLiquidationPrice()
    {
    }

    /**
     * Test attribute "bankrupt_price"
     */
    public function testPropertyBankruptPrice()
    {
    }

    /**
     * Test attribute "timestamp"
     */
    public function testPropertyTimestamp()
    {
    }
}
