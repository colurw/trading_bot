#import <Foundation/Foundation.h>
#import "SWGConfiguration.h"

/**
* BitMEX API
* ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section. 
*
* OpenAPI spec version: 1.2.0
* Contact: support@bitmex.com
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/


@class SWGApiClient;

@interface SWGDefaultConfiguration : NSObject <SWGConfiguration>


/**
 * Default api logger
 */
@property (nonatomic, strong) SWGLogger * logger;

/**
 * Default base url
 */
@property (nonatomic) NSString *host;

/**
 * Api key values for Api Key type Authentication
 *
 * To add or remove api key, use `setApiKey:forApiKeyIdentifier:`.
 */
@property (readonly, nonatomic, strong) NSDictionary *apiKey;

/**
 * Api key prefix values to be prepend to the respective api key
 *
 * To add or remove prefix, use `setApiKeyPrefix:forApiKeyPrefixIdentifier:`.
 */
@property (readonly, nonatomic, strong) NSDictionary *apiKeyPrefix;

/**
 * Username for HTTP Basic Authentication
 */
 @property (nonatomic) NSString *username;

/**
 * Password for HTTP Basic Authentication
 */
@property (nonatomic) NSString *password;

/**
 * Access token for OAuth
 */
@property (nonatomic) NSString *accessToken;

/**
 * Temp folder for file download
 */
@property (nonatomic) NSString *tempFolderPath;

/**
 * Debug switch, default false
 */
@property (nonatomic) BOOL debug;

/**
 * Gets configuration singleton instance
 */
+ (instancetype) sharedConfig;

/**
 * SSL/TLS verification
 * Set this to NO to skip verifying SSL certificate when calling API from https server
 */
@property (nonatomic) BOOL verifySSL;

/**
 * SSL/TLS verification
 * Set this to customize the certificate file to verify the peer
 */
@property (nonatomic) NSString *sslCaCert;

/**
 * The time zone to use for date serialization
 */
@property (nonatomic) NSTimeZone *serializationTimeZone;

/**
 * Sets API key
 *
 * To remove a apiKey for an identifier, just set the apiKey to nil.
 *
 * @param apiKey     API key or token.
 * @param identifier API key identifier (authentication schema).
 *
 */
- (void) setApiKey:(NSString *)apiKey forApiKeyIdentifier:(NSString*)identifier;

/**
 * Removes api key
 *
 * @param identifier API key identifier.
 */
- (void) removeApiKey:(NSString *)identifier;

/**
 * Sets the prefix for API key
 *
 * @param prefix API key prefix.
 * @param identifier   API key identifier.
 */
- (void) setApiKeyPrefix:(NSString *)prefix forApiKeyPrefixIdentifier:(NSString *)identifier;

/**
 * Removes api key prefix
 *
 * @param identifier API key identifier.
 */
- (void) removeApiKeyPrefix:(NSString *)identifier;

/**
 * Gets API key (with prefix if set)
 */
- (NSString *) getApiKeyWithPrefix:(NSString *) key;

/**
 * Gets Basic Auth token
 */
- (NSString *) getBasicAuthToken;

/**
 * Gets OAuth access token
 */
- (NSString *) getAccessToken;

/**
 * Gets Authentication Settings
 */
- (NSDictionary *) authSettings;

/**
* Default headers for all services
*/
@property (readonly, nonatomic, strong) NSDictionary *defaultHeaders;

/**
* Removes header from defaultHeaders
*
* @param key Header name.
*/
-(void) removeDefaultHeaderForKey:(NSString*)key;

/**
* Sets the header for key
*
* @param value         Value for header name
* @param key           Header name
*/
-(void) setDefaultHeaderValue:(NSString*) value forKey:(NSString*)key;

/**
* @param key Header key name.
*/
-(NSString*) defaultHeaderForKey:(NSString*)key;

@end
