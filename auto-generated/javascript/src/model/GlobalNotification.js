/*
 * BitMEX API
 * ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.42-SNAPSHOT
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.BitMexApi) {
      root.BitMexApi = {};
    }
    root.BitMexApi.GlobalNotification = factory(root.BitMexApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The GlobalNotification model module.
   * @module model/GlobalNotification
   * @version 1.2.0
   */

  /**
   * Constructs a new <code>GlobalNotification</code>.
   * Account Notifications
   * @alias module:model/GlobalNotification
   * @class
   * @param _date {Date} 
   * @param title {String} 
   * @param body {String} 
   * @param ttl {Number} 
   */
  var exports = function(_date, title, body, ttl) {
    this._date = _date;
    this.title = title;
    this.body = body;
    this.ttl = ttl;
  };

  /**
   * Constructs a <code>GlobalNotification</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GlobalNotification} obj Optional instance to populate.
   * @return {module:model/GlobalNotification} The populated <code>GlobalNotification</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('id'))
        obj.id = ApiClient.convertToType(data['id'], 'Number');
      if (data.hasOwnProperty('date'))
        obj._date = ApiClient.convertToType(data['date'], 'Date');
      if (data.hasOwnProperty('title'))
        obj.title = ApiClient.convertToType(data['title'], 'String');
      if (data.hasOwnProperty('body'))
        obj.body = ApiClient.convertToType(data['body'], 'String');
      if (data.hasOwnProperty('ttl'))
        obj.ttl = ApiClient.convertToType(data['ttl'], 'Number');
      if (data.hasOwnProperty('type'))
        obj.type = ApiClient.convertToType(data['type'], 'String');
      if (data.hasOwnProperty('closable'))
        obj.closable = ApiClient.convertToType(data['closable'], 'Boolean');
      if (data.hasOwnProperty('persist'))
        obj.persist = ApiClient.convertToType(data['persist'], 'Boolean');
      if (data.hasOwnProperty('waitForVisibility'))
        obj.waitForVisibility = ApiClient.convertToType(data['waitForVisibility'], 'Boolean');
      if (data.hasOwnProperty('sound'))
        obj.sound = ApiClient.convertToType(data['sound'], 'String');
    }
    return obj;
  }

  /**
   * @member {Number} id
   */
  exports.prototype.id = undefined;

  /**
   * @member {Date} _date
   */
  exports.prototype._date = undefined;

  /**
   * @member {String} title
   */
  exports.prototype.title = undefined;

  /**
   * @member {String} body
   */
  exports.prototype.body = undefined;

  /**
   * @member {Number} ttl
   */
  exports.prototype.ttl = undefined;

  /**
   * @member {module:model/GlobalNotification.TypeEnum} type
   */
  exports.prototype.type = undefined;

  /**
   * @member {Boolean} closable
   * @default true
   */
  exports.prototype.closable = true;

  /**
   * @member {Boolean} persist
   * @default true
   */
  exports.prototype.persist = true;

  /**
   * @member {Boolean} waitForVisibility
   * @default true
   */
  exports.prototype.waitForVisibility = true;

  /**
   * @member {String} sound
   */
  exports.prototype.sound = undefined;



  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = {
    /**
     * value: "success"
     * @const
     */
    success: "success",

    /**
     * value: "error"
     * @const
     */
    error: "error",

    /**
     * value: "info"
     * @const
     */
    info: "info"
  };

  return exports;

}));
